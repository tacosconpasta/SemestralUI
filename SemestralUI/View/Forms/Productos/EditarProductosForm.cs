using SemestralUI.Models;
using SemestralUI.Models.DTOs;
using SemestralUI.Models.Events;
using System.Globalization;
using System.Text;
using System.Text.Json;

namespace SemestralUI.View.Forms.Productos {
  public partial class EditarProductosForm : Form {

    //URL base de la API
    private const string API_BASE = "http://srv595743.hstgr.cloud:5000/api";

    //Cliente HTTP reutilizable
    private readonly HttpClient _http = new HttpClient();

    //Evento para volver al listado
    public event EventHandler<NavegacionEventArgs>? SolicitarCambioListarProductosForm;

    //Id del artículo a editar
    private readonly int articuloId;

    public EditarProductosForm(int id) {
      InitializeComponent();

      //Asignar id del artículo
      articuloId = id;

      //Cargar categorías y datos del artículo al iniciar
      Load += EditarProductosForm_Load;
    }

    //Evento Load del formulario
    private async void EditarProductosForm_Load(object sender, EventArgs e) {
      await CargarCategoriasAsync();
      await CargarDatosArticuloAsync();
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

    //Fetch de datos del artículo
    private async Task CargarDatosArticuloAsync() {
      try {
        //GET /api/articulos/{id}
        var response = await _http.GetAsync($"{API_BASE}/articulos/{articuloId}");

        //Validar respuesta
        if (!response.IsSuccessStatusCode) {
          MessageBox.Show("No se pudo cargar el artículo.");
          return;
        }

        //Leer JSON
        var json = await response.Content.ReadAsStringAsync();

        //Deserializar artículo
        var articulo = JsonSerializer.Deserialize<Articulo>(
          json,
          new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
        );

        //Si no hay artículo, salir
        if (articulo == null)
          return;

        //Asignar datos a controles
        txtNombre.Text = articulo.Nombre;
        textBox3.Text = articulo.Descripcion;
        textBox2.Text = articulo.Precio.ToString(CultureInfo.InvariantCulture);
        textBox1.Text = articulo.Stock.ToString();
        chkITBMS.Checked = articulo.Paga_itbms;

        //Cargar categorías asignadas
        var responseCats = await _http.GetAsync($"{API_BASE}/articulos/{articuloId}/categorias");
        if (!responseCats.IsSuccessStatusCode)
          return;

        var jsonCats = await responseCats.Content.ReadAsStringAsync();
        var categoriasArticulo = JsonSerializer.Deserialize<List<Categoria>>(
          jsonCats,
          new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
        );

        //Marcar categorías seleccionadas
        if (categoriasArticulo != null) {
          for (int i = 0; i < checkedCategorias.Items.Count; i++) {
            var cat = (Categoria) checkedCategorias.Items[i];
            if (categoriasArticulo.Any(c => c.Id == cat.Id)) {
              checkedCategorias.SetItemChecked(i, true);
            }
          }
        }

      } catch (Exception ex) {
        MessageBox.Show($"Error cargando datos del artículo:\n{ex.Message}");
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

      if (!int.TryParse(textBox1.Text, out int stock)) {
        MessageBox.Show("El stock debe ser un número entero.");
        return false;
      }

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

      if (!float.TryParse(
        textBox2.Text,
        NumberStyles.Float,
        CultureInfo.InvariantCulture,
        out float precio
      )) {
        MessageBox.Show("Precio inválido. Use punto para decimales.");
        return false;
      }

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

    //Validar categorías
    private bool ValidarCategorias() {
      if (checkedCategorias.CheckedItems.Count == 0) {
        MessageBox.Show("Seleccione al menos una categoría.");
        return false;
      }

      return true;
    }

    //Actualizar artículo y asignar categorías
    private async Task<bool> ActualizarArticuloConCategoriasAsync() {
      try {
        //Construir request de artículo
        var articuloReq = new InsertarArticuloRequest {
          Nombre = txtNombre.Text.Trim(),
          Descripcion = textBox3.Text.Trim(),
          Precio = float.Parse(textBox2.Text, CultureInfo.InvariantCulture),
          Stock = int.Parse(textBox1.Text),
          PagaITBMS = chkITBMS.Checked
        };

        //Serializar a JSON
        var jsonArticulo = JsonSerializer.Serialize(articuloReq);
        var contentArticulo = new StringContent(jsonArticulo, Encoding.UTF8, "application/json");

        //PUT /api/articulos/{id}
        var responseArticulo = await _http.PutAsync(
          $"{API_BASE}/articulos/{articuloId}",
          contentArticulo
        );

        if (!responseArticulo.IsSuccessStatusCode) {
          MessageBox.Show("No se pudo actualizar el artículo.");
          return false;
        }

        //Obtener ids de categorías seleccionadas
        var categoriasIds = checkedCategorias.CheckedItems
          .Cast<Categoria>()
          .Select(c => c.Id)
          .ToList();

        //Request de categorías
        var categoriasReq = new AgregarCategoriasArticuloRequest {
          CategoriasIds = categoriasIds
        };

        var jsonCategorias = JsonSerializer.Serialize(categoriasReq);
        var contentCategorias = new StringContent(jsonCategorias, Encoding.UTF8, "application/json");

        //POST /api/articulos/{id}/categorias
        var responseCategorias = await _http.PostAsync(
          $"{API_BASE}/articulos/{articuloId}/categorias",
          contentCategorias
        );

        if (!responseCategorias.IsSuccessStatusCode) {
          MessageBox.Show("El artículo se actualizó pero no se asignaron las categorías.");
          return false;
        }

        return true;

      } catch (Exception ex) {
        MessageBox.Show($"Error inesperado:\n{ex.Message}");
        return false;
      }
    }

    //Cancelar
    private void btnCancelar_Click(object sender, EventArgs e) {
      SolicitarCambioListarProductosForm?.Invoke(this, new NavegacionEventArgs(0));
    }

    //Guardar cambios
    private async void btnEditar_Click(object sender, EventArgs e) {

      if (!ValidarNombre()) return;
      if (!ValidarStock()) return;
      if (!ValidarPrecio()) return;
      if (!ValidarDescripcion()) return;
      if (!ValidarCategorias()) return;

      bool actualizado = await ActualizarArticuloConCategoriasAsync();

      if (actualizado)
        SolicitarCambioListarProductosForm?.Invoke(this, new NavegacionEventArgs(0));
    }
  }
}
