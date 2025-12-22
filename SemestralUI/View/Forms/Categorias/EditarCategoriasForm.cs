using SemestralUI.Models;
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
  public partial class EditarCategoriasForm : Form {

    private const string API_BASE = "http://srv595743.hstgr.cloud:5000/api";
    private readonly HttpClient _http = new HttpClient();

    private readonly int categoriaId;
    private Categoria? categoriaActual;

    public event EventHandler<NavegacionEventArgs>? SolicitarCambioListarCategoriasForm;

    public EditarCategoriasForm(int id) {
      InitializeComponent();
      categoriaId = id;

      Load += EditarCategoriasForm_Load;
    }

    private async void EditarCategoriasForm_Load(object sender, EventArgs e) {
      await CargarCategoriasAsync();
      await CargarCategoriaActualAsync();
    }

    // Cargar todas las categorías como posibles padres
    private async Task CargarCategoriasAsync() {
      try {
        var response = await _http.GetAsync($"{API_BASE}/categorias");
        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadAsStringAsync();
        var categorias = JsonSerializer.Deserialize<List<Categoria>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

        if (categorias == null) return;

        checkedCategorias.Items.Clear();
        foreach (var cat in categorias) {
          if (cat.Id != categoriaId) // evitar poner a sí misma como padre
            checkedCategorias.Items.Add(cat);
        }
        checkedCategorias.DisplayMember = "Nombre";

      } catch (Exception ex) {
        MessageBox.Show($"Error cargando categorías:\n{ex.Message}");
      }
    }

    // Cargar datos de la categoría a editar
    private async Task CargarCategoriaActualAsync() {
      try {
        var response = await _http.GetAsync($"{API_BASE}/categorias/{categoriaId}");
        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadAsStringAsync();
        categoriaActual = JsonSerializer.Deserialize<Categoria>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

        if (categoriaActual == null) return;

        txtNombre.Text = categoriaActual.Nombre;

        if (categoriaActual.CategoriaPadreId > 0) {
          for (int i = 0; i < checkedCategorias.Items.Count; i++) {
            if (((Categoria) checkedCategorias.Items[i]).Id == categoriaActual.CategoriaPadreId) {
              checkedCategorias.SetItemChecked(i, true);
              break;
            }
          }
        }

      } catch (Exception ex) {
        MessageBox.Show($"Error cargando categoría:\n{ex.Message}");
      }
    }

    // Validaciones
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

    private bool ValidarCategoriaPadre(out int padreId) {
      padreId = 0;
      if (checkedCategorias.CheckedItems.Count > 1) {
        MessageBox.Show("Solo se puede seleccionar una categoría padre.");
        return false;
      }
      if (checkedCategorias.CheckedItems.Count == 1) {
        padreId = ((Categoria) checkedCategorias.CheckedItems[0]).Id;
      }
      return true;
    }

    // Actualizar categoría
    private async Task<bool> ActualizarCategoriaAsync() {
      try {
        int padreId;
        if (!ValidarCategoriaPadre(out padreId)) return false;

        var categoriaReq = new Categoria {
          Id = categoriaId,
          Nombre = txtNombre.Text.Trim(),
          CategoriaPadreId = padreId
        };

        var json = JsonSerializer.Serialize(categoriaReq);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _http.PutAsync($"{API_BASE}/categorias", content);

        return response.IsSuccessStatusCode;

      } catch (Exception ex) {
        MessageBox.Show($"Error inesperado:\n{ex.Message}");
        return false;
      }
    }

    private void btnCancelar_Click(object sender, EventArgs e) {
      SolicitarCambioListarCategoriasForm?.Invoke(this, new NavegacionEventArgs(1));
    }

    private async void btnEditar_Click(object sender, EventArgs e) {
      if (!ValidarNombre()) return;

      bool actualizado = await ActualizarCategoriaAsync();

      if (actualizado) {
        MessageBox.Show("Categoría actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        SolicitarCambioListarCategoriasForm?.Invoke(this, new NavegacionEventArgs(1));
      } else {
        MessageBox.Show("No se pudo actualizar la categoría. Por favor verifique su conexión a internet y vuelva a intentarlo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }
  }
}
