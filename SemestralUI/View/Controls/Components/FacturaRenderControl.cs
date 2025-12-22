using System;
using System.Windows.Forms;
using SemestralUI.Models.DTOs;

namespace SemestralUI.View.Controls.Components {
  public partial class FacturaRenderControl : UserControl {

    public FacturaRenderControl() {
      InitializeComponent();
    }

    //Asignar datos al control
    public void SetData(FacturaRenderDTO factura) {
      lblId.Text = factura.Id.ToString();
      lblUsuario.Text = factura.Usuario_Nombre;
      lblFecha.Text = factura.Fecha.ToString("dd/MM/yyyy");
      lblSubtotal.Text = $"${factura.Subtotal:F2}";
      lblItbms.Text = $"${factura.Itbms:F2}";
      lblTotal.Text = $"${factura.Total:F2}";
      Tag = factura.Id;
    }
  }
}
