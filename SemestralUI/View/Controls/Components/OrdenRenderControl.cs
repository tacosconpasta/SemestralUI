using System;
using System.Windows.Forms;
using SemestralUI.Models.DTOs;

namespace SemestralUI.View.Controls.Components {
  public partial class OrdenRenderControl : UserControl {

    public event EventHandler<int>? AceptarOrdenClicked;
    public event EventHandler<int>? CancelarOrdenClicked;

    public OrdenRenderControl() {
      InitializeComponent();
    }

    public void SetData(OrdenRenderDTO orden) {
      lblId.Text = orden.Id.ToString();
      lblUsuario.Text = orden.Usuario_Nombre;
      lblTotal.Text = $"${orden.Total:F2}";
      Tag = orden.Id; //Se guarda el ordenId en tag para botones y renderizaciones futuras
    }

    private void btnAceptar_Click(object sender, EventArgs e) {
      if (Tag is int ordenId)
        AceptarOrdenClicked?.Invoke(this, ordenId);
    }

    private void btnCancelar_Click(object sender, EventArgs e) {
      if (Tag is int ordenId)
        CancelarOrdenClicked?.Invoke(this, ordenId);
    }
  }
}
