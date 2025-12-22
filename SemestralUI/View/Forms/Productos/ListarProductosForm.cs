using SemestralUI.Models;
using SemestralUI.Models.Events;
using SemestralUI.View.Controls.Components;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemestralUI.View.Forms {
  public partial class ListarProductosForm : Form {
    //Constantes
    private const string API_BASE = "http://srv595743.hstgr.cloud:5000/api";
    private readonly HttpClient _http = new HttpClient();

    //Eventos para cambiar de pantalla
    public event EventHandler<NavegacionEventArgs>? SolicitarCambioAgregarProductosForm;
    public event EventHandler<NavegacionEventArgs>? SolicitarCambioEditarProductosForm;


    public ListarProductosForm() {
      InitializeComponent();

      //Cargar artículos al iniciar
      _ = CargarArticulosAsync();
    }

    //Cargar y renderizar artículos
    private async Task CargarArticulosAsync() {
      try {
        //Limpiar artículos de render previo
        articulosListContainer.Controls.Clear();

        //Obtener artículos
        var response = await _http.GetAsync($"{API_BASE}/articulos");
        response.EnsureSuccessStatusCode();

        //Leer la petición como cadena
        string json = await response.Content.ReadAsStringAsync();

        //parsearJson
        var root = JsonDocument.Parse(json);
        var articulosJson = root.RootElement.GetProperty("articulos");

        //Deserealizar
        var articulos = JsonSerializer.Deserialize<List<Articulo>>(
          articulosJson.GetRawText(),
          new JsonSerializerOptions {
            PropertyNameCaseInsensitive = true
          }
        );

        if (articulos == null) return;

        //Espaciado vertical entre artículos renderizados
        int yOffset = 0;

        //Renderizar cada artículo
        foreach (var articulo in articulos) {

          var categorias = await ObtenerCategoriasArticuloAsync(articulo.Id);

          var control = new ArticuloRenderControl(articulo, categorias) {
            AutoSize = true,
            Location = new Point(0, yOffset)
          };

          // Eventos (si los usas)
          control.EditarClick += ArticuloEditar;
          control.EliminarClick += ArticuloEliminar;

          articulosListContainer.Controls.Add(control);

          //Espaciado vertical
          yOffset += control.Height + 10;
        }
      } catch (Exception ex) {
        MessageBox.Show(
          $"Error cargando artículos:\n{ex.Message}",
          "Error",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error
        );
      }
    }

    //Obtener categorías por artículo
    private async Task<List<Categoria>> ObtenerCategoriasArticuloAsync(int articuloId) {
      try {
        var response = await _http.GetAsync(
          $"{API_BASE}/articulos/{articuloId}/categorias"
        );

        if (!response.IsSuccessStatusCode)
          return new List<Categoria>();

        string json = await response.Content.ReadAsStringAsync();

        return JsonSerializer.Deserialize<List<Categoria>>(
          json,
          new JsonSerializerOptions {
            PropertyNameCaseInsensitive = true
          }
        ) ?? new List<Categoria>();
      } catch {
        return new List<Categoria>();
      }
    }

    //Eventos del control
    private void ArticuloEditar(object? sender, int articuloId) {
      MessageBox.Show($"Editar artículo {articuloId}");
    }

    private void ArticuloEliminar(object? sender, int articuloId) {
      MessageBox.Show($"Eliminar artículo {articuloId}");
    }

    private void btnAgregarArticulos_Click(object sender, EventArgs e) {
      SolicitarCambioAgregarProductosForm?.Invoke(this, new NavegacionEventArgs(0));
    }
  }
}
