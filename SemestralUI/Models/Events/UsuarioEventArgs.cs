using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralUI.Models.Events {
  public class UsuarioEventArgs : EventArgs {
    //Permite obtener Usuario de eventos
    public Usuario User { get; }

    public UsuarioEventArgs(Usuario usuario) {
      User = usuario;
    }
  }
}
