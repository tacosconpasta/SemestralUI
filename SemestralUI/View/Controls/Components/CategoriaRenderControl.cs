using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SemestralUI.Models;

namespace SemestralUI.View.Controls.Components {
  public partial class CategoriaRenderControl : UserControl {

    private Categoria _categoria;

    public event EventHandler<int> EditarClick;
    public event EventHandler<int> EliminarClick;

    public CategoriaRenderControl(Categoria categoria) {
      InitializeComponent();
      _categoria = categoria;

      Renderizar();
    }

    public CategoriaRenderControl() {
      InitializeComponent();
    }

    private void Renderizar() {
      lblNombre.Text = _categoria.Nombre;

      lblPadre.Text = _categoria.CategoriaPadreId.HasValue
        ? _categoria.CategoriaPadreId.Value.ToString()
        : "—";

      btnEditar.Click += (_, __) => EditarClick?.Invoke(this, _categoria.Id);
      btnEliminar.Click += (_, __) => EliminarClick?.Invoke(this, _categoria.Id);
    }
  }
}
