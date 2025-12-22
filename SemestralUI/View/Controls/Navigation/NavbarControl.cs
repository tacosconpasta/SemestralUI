using SemestralUI.Models.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemestralUI.View.Controls {
  public partial class NavbarControl : UserControl {

    private List<Label> _items;
    public event EventHandler<NavegacionEventArgs>? NavegacionSolicitada;


    //Indice seleccionado para marcar en negritas
    private int _selectedIndex = -1;

    public NavbarControl() {
      InitializeComponent();
      InicializarNavbar();

      lblArtículos.Click += (_, __) => EmitirNavegacion(0);
      lblCategorias.Click += (_, __) => EmitirNavegacion(1);
      lblOrdenes.Click += (_, __) => EmitirNavegacion(2);
      lblTransacciones.Click += (_, __) => EmitirNavegacion(3);
    }

    private void InicializarNavbar() {
      _items = new List<Label> {
        lblArtículos,       //0
        lblCategorias,      //1
        lblOrdenes,         //2
        lblTransacciones    //3
      };

      // Hacerlos clickeables
      for (int i = 0; i < _items.Count; i++) {
        int index = i; // evitar closure bug
        _items[i].Cursor = Cursors.Hand;
        _items[i].Click += (_, __) => SelectedIndex = index;
      }
    }

    //gettersy setters de selected index
    public int SelectedIndex {
      get => _selectedIndex;
      set {
        if (value < 0 || value >= _items.Count) return;

        _selectedIndex = value;
        ActualizarEstilos();
      }
    }

    //Actualizar Estilos dependiendo del selected index
    private void ActualizarEstilos() {
      for (int i = 0; i < _items.Count; i++) {
        _items[i].Font = new Font(
          _items[i].Font.FontFamily,
          12F,
          i == _selectedIndex ? FontStyle.Bold : FontStyle.Regular
        );

        _items[i].ForeColor = i == _selectedIndex
          ? Color.White
          : Color.Gray;
      }
    }

    private void EmitirNavegacion(int indice) {
      NavegacionSolicitada?.Invoke(
        this,
        new NavegacionEventArgs(indice)
      );
    }
  }
}

