using SemestralUI.Models;
using SemestralUI.Models.DTOs;
using SemestralUI.View.Controls.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemestralUI.View.Forms.Ordenes {
  public partial class ListarOrdenesForm : Form {

    //Base de la API
    private const string API_BASE = "http://srv595743.hstgr.cloud:5000/api";
    private readonly HttpClient _http = new HttpClient();

    public ListarOrdenesForm() {
      InitializeComponent();
      _ = CargarOrdenesAsync(); //Cargar órdenes al iniciar
    }

    //Cargar y renderizar órdenes
    private async Task CargarOrdenesAsync() {
      try {
        ordenesListContainer.Controls.Clear(); //Limpiar lista previa

        // --- Insertar encabezado ---
        var encabezado = new OrdenRenderControl();
        encabezado.lblUsuario.Text = "Usuario";
        encabezado.lblTotal.Text = "Total";
        encabezado.btnAceptar.Visible = false;
        encabezado.btnCancelar.Visible = false;
        encabezado.Margin = new Padding(0, 10, 0, 0);

        ordenesListContainer.Controls.Add(encabezado);

        // Poner en negrita los encabezados
        encabezado.lblUsuario.Font = new Font(encabezado.lblUsuario.Font, FontStyle.Bold);
        encabezado.lblTotal.Font = new Font(encabezado.lblTotal.Font, FontStyle.Bold);

        // Obtener órdenes en revisión
        var response = await _http.GetAsync($"{API_BASE}/ordenes/revision");
        if (!response.IsSuccessStatusCode) return;

        string json = await response.Content.ReadAsStringAsync();
        var ordenesRaw = JsonSerializer.Deserialize<List<Orden>>(
          json,
          new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
        );
        if (ordenesRaw == null) return;

        //Mapear usuarios a nombres
        var usuariosPorId = new Dictionary<int, string>();
        var usuarioIds = new HashSet<int>(ordenesRaw.Select(o => o.Usuario_Id));

        foreach (var usuarioId in usuarioIds) {
          var respUsuario = await _http.GetAsync($"{API_BASE}/auth/usuario/{usuarioId}");
          if (!respUsuario.IsSuccessStatusCode) {
            usuariosPorId[usuarioId] = "Desconocido";
            continue;
          }

          string jsonUsuario = await respUsuario.Content.ReadAsStringAsync();
          var usuario = JsonSerializer.Deserialize<Usuario>(
            jsonUsuario,
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
          );

          usuariosPorId[usuarioId] = usuario?.User ?? "Desconocido";
        }

        //Convertir a DTO para render
        var ordenesParaRender = new List<OrdenRenderDTO>();
        foreach (var o in ordenesRaw) {
          string nombreUsuario = usuariosPorId.ContainsKey(o.Usuario_Id)
            ? usuariosPorId[o.Usuario_Id]
            : "Desconocido";

          ordenesParaRender.Add(new OrdenRenderDTO {
            Id = o.Id,
            Usuario_Nombre = nombreUsuario,
            Total = o.Total
          });
        }

        //Renderizar controles
        int yOffset = encabezado.Height + 10; // Iniciar después del encabezado
        foreach (var orden in ordenesParaRender) {
          var control = new OrdenRenderControl {
            AutoSize = true,
            Location = new Point(0, yOffset)
          };

          control.SetData(orden); //Asignar datos
          control.AceptarOrdenClicked += OrdenAceptar;
          control.CancelarOrdenClicked += OrdenCancelar;

          ordenesListContainer.Controls.Add(control);
          yOffset += control.Height + 10;
        }

      } catch (Exception ex) {
        MessageBox.Show($"Error cargando órdenes:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    //Aceptar orden
    private async void OrdenAceptar(object? sender, int ordenId) {
      try {
        var response = await _http.PutAsync($"{API_BASE}/ordenes/finalizar/{ordenId}", null);
        if (response.IsSuccessStatusCode) {
          MessageBox.Show("Orden aceptada y factura generada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
          _ = CargarOrdenesAsync();
        } else {
          MessageBox.Show("No se pudo aceptar la orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      } catch (Exception ex) {
        MessageBox.Show($"Error al aceptar orden:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    //Cancelar orden
    private async void OrdenCancelar(object? sender, int ordenId) {
      try {
        var content = new StringContent("{\"Estado\":\"completada\"}", System.Text.Encoding.UTF8, "application/json");
        var response = await _http.PutAsync($"{API_BASE}/ordenes/{ordenId}", content);
        if (response.IsSuccessStatusCode) {
          MessageBox.Show("Orden cancelada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
          _ = CargarOrdenesAsync();
        } else {
          MessageBox.Show("No se pudo cancelar la orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      } catch (Exception ex) {
        MessageBox.Show($"Error al cancelar orden:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
