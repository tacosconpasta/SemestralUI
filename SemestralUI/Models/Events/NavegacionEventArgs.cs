using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralUI.Models.Events {
  public class NavegacionEventArgs : EventArgs {
    public int Indice { get; }

    public NavegacionEventArgs(int indice) {
      Indice = indice;
    }
  }
}
