using System.Linq;
using SemestralUI.Models;

namespace SemestralUI.View.Controls.Components {
  public partial class ArticuloRenderControl : UserControl {

    private Articulo _articulo;
    private List<Categoria> _categorias;

    public event EventHandler<int> EditarClick;
    public event EventHandler<int> EliminarClick;

    public ArticuloRenderControl(Articulo articulo, List<Categoria> categorias) {
      InitializeComponent();
      _articulo = articulo;
      _categorias = categorias;

      Renderizar();
    }

    public ArticuloRenderControl() {
      InitializeComponent();
    }

    private void Renderizar() {
      lblNombre.Text = _articulo.Nombre;
      lblPrecio.Text = $"${_articulo.Precio:0.00}";

      lblCategorias.Text =
        _categorias != null && _categorias.Count > 0
          ? string.Join(", ", _categorias.Select(c => c.Nombre))
          : "—";

      btnEditar.Click += (_, __) => EditarClick?.Invoke(this, _articulo.Id);
      btnEliminar.Click += (_, __) => EliminarClick?.Invoke(this, _articulo.Id);
    }
  }
}
