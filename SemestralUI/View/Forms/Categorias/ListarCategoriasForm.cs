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
        // Limpiar lista previa
        categoriasListContainer.Controls.Clear();

        // Encabezado
        var encabezado = new CategoriaRenderControl();
        //Header de nombre
        encabezado.lblNombre.Text = "Nombre";
        //Header de descripción
        encabezado.lblPadre.Text = "Categoría Padre";

        //Ocultar botones
        encabezado.btnEditar.Visible = false; 
        encabezado.btnEliminar.Visible = false;

        //Margen Encabezado
        encabezado.Margin = new Padding(0, 10, 0, 0);

        //Bold
        encabezado.lblNombre.Font = new Font(encabezado.lblNombre.Font, FontStyle.Bold);
        encabezado.lblPadre.Font = new Font(encabezado.lblPadre.Font, FontStyle.Bold);

        categoriasListContainer.Controls.Add(encabezado);

        //Obtener categorías
        var response = await _http.GetAsync($"{API_BASE}/categorias");
        response.EnsureSuccessStatusCode();

        string json = await response.Content.ReadAsStringAsync();
        var categorias = JsonSerializer.Deserialize<List<Categoria>>(
            json,
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
        );
        if (categorias == null) return;

        // Crear un diccionario de categorías por Id para no hacer múltiples requests
        var categoriasPorId = new Dictionary<int, Categoria>();
        foreach (var cat in categorias) {
          categoriasPorId[cat.Id] = cat;
        }

        int yOffset = encabezado.Height + 10;

        // Renderizar cada categoría
        foreach (var categoria in categorias) {
          var control = new CategoriaRenderControl(categoria) {
            AutoSize = true,
            Location = new Point(0, yOffset)
          };

          // Determinar categoría padre
          control.lblPadre.Text = (categoria.CategoriaPadreId.HasValue && categoria.CategoriaPadreId.Value != 0 && categoriasPorId.ContainsKey(categoria.CategoriaPadreId.Value))
              ? categoriasPorId[categoria.CategoriaPadreId.Value].Nombre
              : "—";

          // Eventos del control
          control.EditarClick += CategoriaEditar;
          control.EliminarClick += CategoriaEliminar;

          categoriasListContainer.Controls.Add(control);

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
      var resultado = MessageBox.Show(
        "¿Estás seguro que deseas eliminar esta categoría?",
        "Confirmar eliminación",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning
      );

      if (resultado != DialogResult.Yes) return;

      try {
        var response = await _http.DeleteAsync($"{API_BASE}/categorias/{categoriaId}");

        if (!response.IsSuccessStatusCode) {
          string mensajeError = await response.Content.ReadAsStringAsync();
          MessageBox.Show($"No se pudo eliminar la categoría.\n{mensajeError}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }

        MessageBox.Show("Categoría eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        // Recargar categorías
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
