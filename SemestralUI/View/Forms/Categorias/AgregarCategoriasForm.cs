using SemestralUI.Models;
using SemestralUI.Models.DTOs;
using SemestralUI.Models.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemestralUI.View.Forms.Categorias {
  public partial class AgregarCategoriasForm : Form {

    //URL base de la API
    private const string API_BASE = "http://srv595743.hstgr.cloud:5000/api";

    //Cliente HTTP reutilizable
    private readonly HttpClient _http = new HttpClient();

    //Evento para volver al listado
    public event EventHandler<NavegacionEventArgs>? SolicitarCambioListarCategoriasForm;

    public AgregarCategoriasForm() {
      InitializeComponent();

      //Cargar categorías al iniciar el formulario
      Load += AgregarCategoriasForm_Load;

      //Eventos de botones
      btnAgregar.Click += BtnAgregar_Click;
      btnCancelar.Click += BtnCancelar_Click;
    }

    //Evento Load
    private async void AgregarCategoriasForm_Load(object sender, EventArgs e) {
      await CargarCategoriasAsync();
    }

    //Cargar categorías existentes
    private async Task CargarCategoriasAsync() {
      try {
        var response = await _http.GetAsync($"{API_BASE}/categorias");
        response.EnsureSuccessStatusCode();

        string json = await response.Content.ReadAsStringAsync();
        var categorias = JsonSerializer.Deserialize<List<Categoria>>(
          json,
          new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
        );

        if (categorias == null) return;

        //Limpiar lista antes de renderizar
        checkedCategorias.Items.Clear();

        //Agregar categorías como posibles padres
        foreach (var categoria in categorias) {
          checkedCategorias.Items.Add(categoria);
        }

        checkedCategorias.DisplayMember = "Nombre";

      } catch (Exception ex) {
        MessageBox.Show($"Error cargando categorías:\n{ex.Message}");
      }
    }

    //Validar nombre
    private bool ValidarNombre() {
      string nombre = txtNombre.Text.Trim();
      if (string.IsNullOrWhiteSpace(nombre)) {
        MessageBox.Show("Ingrese el nombre de la categoría.");
        return false;
      }

      if (nombre.Length > 30) {
        MessageBox.Show("El nombre no puede exceder 30 caracteres.");
        return false;
      }

      return true;
    }

    //Validar selección de categoría padre
    private bool ValidarCategoriaPadre(out int padreId) {
      padreId = 0;

      //Solo se permite seleccionar máximo un padre
      if (checkedCategorias.CheckedItems.Count > 1) {
        MessageBox.Show("Solo se puede seleccionar una categoría padre.");
        return false;
      }

      if (checkedCategorias.CheckedItems.Count == 1) {
        padreId = ((Categoria) checkedCategorias.CheckedItems[0]).Id;
      }

      return true;
    }

    //Crear categoría
    private async Task<bool> CrearCategoriaAsync(string nombre, int padreId) {
      try {
        var categoriaReq = new InsertarCategoriaRequest {
          Nombre = nombre,
          CategoriaPadreId = padreId
        };

        var json = JsonSerializer.Serialize(categoriaReq);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _http.PostAsync($"{API_BASE}/categorias", content);

        if (response.IsSuccessStatusCode) {
          MessageBox.Show("Categoría creada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
          return true;
        }

        string error = await response.Content.ReadAsStringAsync();
        MessageBox.Show($"No se pudo crear la categoría:\n{error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;

      } catch (Exception ex) {
        MessageBox.Show($"Error inesperado:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
    }

    //Cancelar
    private void BtnCancelar_Click(object? sender, EventArgs e) {
      SolicitarCambioListarCategoriasForm?.Invoke(this, new NavegacionEventArgs(1));
    }

    //Agregar categoría
    private async void BtnAgregar_Click(object? sender, EventArgs e) {
      if (!ValidarNombre()) return;
      if (!ValidarCategoriaPadre(out int padreId)) return;

      bool creado = await CrearCategoriaAsync(txtNombre.Text.Trim(), padreId);

      if (creado)
        SolicitarCambioListarCategoriasForm?.Invoke(this, new NavegacionEventArgs(1));
    }
  }
}
