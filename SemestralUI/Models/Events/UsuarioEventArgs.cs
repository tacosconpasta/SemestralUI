using SemestralUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralUI.Models.Events {
  public class UsuarioEventArgs : EventArgs {
    //Permite obtener Jugador
    public Usuario User { get; }

    public UsuarioEventArgs(Usuario usuario) {
      User = usuario;
    }
  }
}
