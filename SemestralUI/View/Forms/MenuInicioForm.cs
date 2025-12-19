using SemestralUI.Models;
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

namespace SemestralUI.View.Forms {
  public partial class MenuInicioForm : Form {
    //Evento Solicitar cambio de pantalla
    public event EventHandler<UsuarioEventArgs>? SolicitarCambio;

    Usuario usuario;

    public MenuInicioForm(Usuario usuario) {
      InitializeComponent();

      //Asignar usuario parámetro a atributo
      this.usuario = usuario;
    }
  }
}
