using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralUI.Models.Events {
  public class IdentificadorEventArgs : EventArgs {
    public int Id { get; }

    public IdentificadorEventArgs(int id) {
      Id = id;
    }
  }
}
