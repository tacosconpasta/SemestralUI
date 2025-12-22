using SemestralUI.Models;
using SemestralUI.Models.Events;
using SemestralUI.View.Controls.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemestralUI.View.Forms.Categorias {
  public partial class ListarCategoriasForm : Form {
    //Constantes
    private const string API_BASE = "http://srv595743.hstgr.cloud:5000/api";
    private readonly HttpClient _http = new HttpClient();

    //Eventos para cambiar de pantalla
    public event EventHandler<NavegacionEventArgs>? SolicitarCambioAgregarCategoriasForm;
    public event EventHandler<IdentificadorEventArgs>? SolicitarCambioEditarCategoriasForm;

    public ListarCategoriasForm() {
      InitializeComponent();

      //Cargar categorías al iniciar
      _ = CargarCategoriasAsync();
    }

    //Cargar y renderizar categorías
    private async Task CargarCategoriasAsync() {
      try {
        //Limpiar lista previa
        categoriasListContainer.Controls.Clear();

        //Obtener categorías
        var response = await _http.GetAsync($"{API_BASE}/categorias");
        response.EnsureSuccessStatusCode();

        //Leer JSON
        string json = await response.Content.ReadAsStringAsync();

        //Deserializar
        var categorias = JsonSerializer.Deserialize<List<Categoria>>(
          json,
          new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
        );

        if (categorias == null) return;

        //Espaciado vertical entre controles
        int yOffset = 0;

        //Renderizar cada categoría
        foreach (var categoria in categorias) {

          var control = new CategoriaRenderControl(categoria) {
            AutoSize = true,
            Location = new Point(0, yOffset)
          };

          //Eventos del control
          control.EditarClick += CategoriaEditar;
          control.EliminarClick += CategoriaEliminar;

          categoriasListContainer.Controls.Add(control);

          //Espaciado vertical
          yOffset += control.Height + 10;
        }
      } catch (Exception ex) {
        MessageBox.Show(
          $"Error cargando categorías:\n{ex.Message}",
          "Error",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error
        );
      }
    }

    //Eventos del control
    private void CategoriaEditar(object? sender, int categoriaId) {
      SolicitarCambioEditarCategoriasForm?.Invoke(this, new IdentificadorEventArgs(categoriaId));
    }

    private async void CategoriaEliminar(object? sender, int categoriaId) {
      //Pregunta de confirmación
      var resultado = MessageBox.Show(
        "¿Estás seguro que deseas eliminar esta categoría?",
        "Confirmar eliminación",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning
      );

      //Si usuario cancela, salir
      if (resultado != DialogResult.Yes)
        return;

      try {
        //Llamada al endpoint DELETE /api/categorias/{id}
        var response = await _http.DeleteAsync($"{API_BASE}/categorias/{categoriaId}");

        //Validar respuesta
        if (!response.IsSuccessStatusCode) {
          string mensajeError = await response.Content.ReadAsStringAsync();
          MessageBox.Show($"No se pudo eliminar la categoría.\n{mensajeError}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }

        //Mensaje de éxito
        MessageBox.Show("Categoría eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //Recargar categorías para refrescar UI
        _ = CargarCategoriasAsync();

      } catch (Exception ex) {
        MessageBox.Show($"Error inesperado al eliminar categoría:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnAgregarCategorias_Click(object sender, EventArgs e) {
      SolicitarCambioAgregarCategoriasForm?.Invoke(this, new NavegacionEventArgs(1));
    }
  }
}
