using SemestralUI.Models;
using SemestralUI.Models.DTOs;
using SemestralUI.Models.Events;
using System.Globalization;
using System.Text;
using System.Text.Json;

namespace SemestralUI.View.Forms.Productos {
  public partial class AgregarProductosForm : Form {

    //URL base de la API
    private const string API_BASE = "http://srv595743.hstgr.cloud:5000/api";

    //Cliente HTTP reutilizable
    private readonly HttpClient _http = new HttpClient();

    //Evento para volver al listado
    public event EventHandler<NavegacionEventArgs>? SolicitarCambioListarProductosForm;

    public AgregarProductosForm() {
      InitializeComponent();

      //Cargar categorías al iniciar el formulario
      Load += AgregarProductosForm_Load;
    }

    //Evento Load del formulario
    private async void AgregarProductosForm_Load(object sender, EventArgs e) {
      await CargarCategoriasAsync();
    }

    //Fetch de categorías desde el backend
    private async Task CargarCategoriasAsync() {
      try {
        //GET /api/categorias
        var response = await _http.GetAsync($"{API_BASE}/categorias");

        //Validar respuesta HTTP
        if (!response.IsSuccessStatusCode) {
          MessageBox.Show("No se pudieron cargar las categorías.");
          return;
        }

        //Leer JSON de respuesta
        var json = await response.Content.ReadAsStringAsync();

        //Deserializar a lista de categorías
        var categorias = JsonSerializer.Deserialize<List<Categoria>>(
          json,
          new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
        );

        //Si no hay datos válidos, salir
        if (categorias == null || categorias.Count == 0)
          return;

        //Limpiar lista antes de renderizar
        checkedCategorias.Items.Clear();

        //Agregar categorías al CheckedListBox
        foreach (var categoria in categorias) {
          checkedCategorias.Items.Add(categoria);
        }

        //Indicar qué propiedad se muestra
        checkedCategorias.DisplayMember = "Nombre";

      } catch (Exception ex) {
        MessageBox.Show($"Error cargando categorías:\n{ex.Message}");
      }
    }

    //Validar nombre
    private bool ValidarNombre() {
      string nombre = txtNombre.Text.Trim();

      if (string.IsNullOrWhiteSpace(nombre)) {
        MessageBox.Show("Ingrese el nombre del artículo.");
        return false;
      }

      if (nombre.Length > 30) {
        MessageBox.Show("El nombre no puede exceder 30 caracteres.");
        return false;
      }

      return true;
    }

    //Validar stock
    private bool ValidarStock() {
      if (string.IsNullOrWhiteSpace(textBox1.Text)) {
        MessageBox.Show("Ingrese una cantidad de stock.");
        return false;
      }

      //Parseo seguro
      if (!int.TryParse(textBox1.Text, out int stock)) {
        MessageBox.Show("El stock debe ser un número entero.");
        return false;
      }

      //Validar rango
      if (stock <= 0 || stock > 10_000_000) {
        MessageBox.Show("Stock fuera de rango válido.");
        return false;
      }

      return true;
    }

    //Validar precio
    private bool ValidarPrecio() {
      if (string.IsNullOrWhiteSpace(textBox2.Text)) {
        MessageBox.Show("Ingrese un precio.");
        return false;
      }

      //Parseo con cultura invariante
      if (!float.TryParse(
        textBox2.Text,
        NumberStyles.Float,
        CultureInfo.InvariantCulture,
        out float precio
      )) {
        MessageBox.Show("Precio inválido. Use punto para decimales.");
        return false;
      }

      //Validar rango
      if (precio <= 0 || precio > 10_000_000) {
        MessageBox.Show("Precio fuera de rango válido.");
        return false;
      }

      return true;
    }

    //Validar descripción
    private bool ValidarDescripcion() {
      string descripcion = textBox3.Text.Trim();

      if (string.IsNullOrWhiteSpace(descripcion)) {
        MessageBox.Show("Ingrese una descripción.");
        return false;
      }

      if (descripcion.Length > 60) {
        MessageBox.Show("La descripción no puede exceder 60 caracteres.");
        return false;
      }

      return true;
    }

    //Validar categorías seleccionadas
    private bool ValidarCategorias() {
      if (checkedCategorias.CheckedItems.Count == 0) {
        MessageBox.Show("Seleccione al menos una categoría.");
        return false;
      }

      return true;
    }

    //Crear artículo y asignar categorías
    private async Task<bool> CrearArticuloConCategoriasAsync() {
      try {
        //Construir request de artículo
        var articuloReq = new InsertarArticuloRequest {
          Nombre = txtNombre.Text.Trim(),
          Descripcion = textBox3.Text.Trim(),
          Precio = float.Parse(textBox2.Text, CultureInfo.InvariantCulture),
          Stock = int.Parse(textBox1.Text),
          PagaITBMS = chkITBMS.Checked
        };

        //Serializar artículo a JSON
        var jsonArticulo = JsonSerializer.Serialize(articuloReq);
        var contentArticulo = new StringContent(jsonArticulo, Encoding.UTF8, "application/json");

        //POST /api/articulos
        var responseArticulo = await _http.PostAsync(
          $"{API_BASE}/articulos",
          contentArticulo
        );

        //Validar creación
        if (!responseArticulo.IsSuccessStatusCode) {
          MessageBox.Show("No se pudo crear el artículo.");
          return false;
        }

        //Leer artículo creado
        var articuloCreado = JsonSerializer.Deserialize<Articulo>(
          await responseArticulo.Content.ReadAsStringAsync(),
          new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
        );

        //Validar id devuelto
        if (articuloCreado == null || articuloCreado.Id <= 0)
          return false;

        //Obtener ids de categorías seleccionadas
        var categoriasIds = checkedCategorias.CheckedItems
          .Cast<Categoria>()
          .Select(c => c.Id)
          .ToList();

        //Construir request de categorías
        var categoriasReq = new AgregarCategoriasArticuloRequest {
          CategoriasIds = categoriasIds
        };

        //Serializar categorías
        var jsonCategorias = JsonSerializer.Serialize(categoriasReq);
        var contentCategorias = new StringContent(jsonCategorias, Encoding.UTF8, "application/json");

        //POST /api/articulos/{id}/categorias
        var responseCategorias = await _http.PostAsync(
          $"{API_BASE}/articulos/{articuloCreado.Id}/categorias",
          contentCategorias
        );

        //Validar asignación
        if (!responseCategorias.IsSuccessStatusCode) {
          MessageBox.Show("El artículo se creó pero no se asignaron las categorías.");
          return false;
        }

        return true;

      } catch (Exception ex) {
        MessageBox.Show($"Error inesperado:\n{ex.Message}");
        return false;
      }
    }

    //Cancelar y volver al listado
    private void btnCancelar_Click(object sender, EventArgs e) {
      SolicitarCambioListarProductosForm?.Invoke(this, new NavegacionEventArgs(0));
    }

    //Agregar producto
    private async void btnAgregar_Click(object sender, EventArgs e) {

      //Validaciones previas al fetch
      if (!ValidarNombre()) return;
      if (!ValidarStock()) return;
      if (!ValidarPrecio()) return;
      if (!ValidarDescripcion()) return;
      if (!ValidarCategorias()) return;

      //Crear artículo y categorías
      bool creado = await CrearArticuloConCategoriasAsync();

      //Volver al listado si fue exitoso
      if (creado)
        SolicitarCambioListarProductosForm?.Invoke(this, new NavegacionEventArgs(0));
    }
  }
}
