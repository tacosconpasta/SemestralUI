using SemestralUI.Models;
using SemestralUI.Models.DTOs;
using SemestralUI.View.Controls.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemestralUI.View.Forms.Facturas {
  public partial class ListarFacturasForm : Form {

    //Constantes
    private const string API_BASE = "http://srv595743.hstgr.cloud:5000/api";
    private readonly HttpClient _http = new HttpClient();

    public ListarFacturasForm() {
      InitializeComponent();
      _ = CargarFacturasAsync(); //Cargar facturas al iniciar
    }

    //Cargar y renderizar facturas
    private async Task CargarFacturasAsync() {
      try {
        //Limpiar lista previa
        facturasListContainer.Controls.Clear();

        // --- Insertar encabezado ---
        var encabezado = new FacturaRenderControl();
        encabezado.lblUsuario.Text = "Usuario";
        encabezado.lblFecha.Text = "Fecha";
        encabezado.lblSubtotal.Text = "Subtotal";
        encabezado.lblItbms.Text = "ITBMS";
        encabezado.lblTotal.Text = "Total";

        // Poner en negrita los encabezados
        encabezado.lblUsuario.Font = new Font(encabezado.lblUsuario.Font, FontStyle.Bold);
        encabezado.lblFecha.Font = new Font(encabezado.lblFecha.Font, FontStyle.Bold);
        encabezado.lblSubtotal.Font = new Font(encabezado.lblSubtotal.Font, FontStyle.Bold);
        encabezado.lblItbms.Font = new Font(encabezado.lblItbms.Font, FontStyle.Bold);
        encabezado.lblTotal.Font = new Font(encabezado.lblTotal.Font, FontStyle.Bold);

        // Espaciado superior
        encabezado.Margin = new Padding(0, 10, 0, 0);

        facturasListContainer.Controls.Add(encabezado);

        // Obtener facturas
        var response = await _http.GetAsync($"{API_BASE}/facturas");
        if (!response.IsSuccessStatusCode) return;

        string json = await response.Content.ReadAsStringAsync();

        var facturasRaw = JsonSerializer.Deserialize<List<Factura>>(
          json,
          new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
        );

        if (facturasRaw == null) return;

        //Lista de DTOs
        var facturas = new List<FacturaRenderDTO>();

        //Mapear facturas a DTO con nombre de usuario
        foreach (var f in facturasRaw) {
          string nombreUsuario = await ObtenerNombreUsuario(f.UsuarioId);

          facturas.Add(new FacturaRenderDTO {
            Id = f.Id,
            Usuario_Nombre = nombreUsuario,
            Fecha = f.Fecha,
            Subtotal = f.Subtotal,
            Itbms = f.Itbms,
            Total = f.Total
          });
        }

        int yOffset = encabezado.Height + 10; // Iniciar debajo del encabezado

        //Renderizar cada factura
        foreach (var factura in facturas) {
          var control = new FacturaRenderControl {
            AutoSize = true,
            Location = new Point(0, yOffset)
          };

          control.SetData(factura);

          facturasListContainer.Controls.Add(control);

          //Espaciado vertical
          yOffset += control.Height + 10;
        }

      } catch (Exception ex) {
        MessageBox.Show($"Error cargando facturas:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    //Obtener nombre de usuario por Id
    private async Task<string> ObtenerNombreUsuario(int usuarioId) {
      try {
        var response = await _http.GetAsync($"{API_BASE}/auth/usuario/{usuarioId}");
        if (!response.IsSuccessStatusCode) return "Desconocido";

        string json = await response.Content.ReadAsStringAsync();

        var usuario = JsonSerializer.Deserialize<SemestralUI.Models.Usuario>(
          json,
          new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
        );

        return usuario?.User ?? "Desconocido";
      } catch {
        return "Desconocido";
      }
    }
  }
}
