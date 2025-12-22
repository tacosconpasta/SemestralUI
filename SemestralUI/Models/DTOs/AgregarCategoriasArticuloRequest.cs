using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralUI.Models.DTOs {
  public class AgregarCategoriasArticuloRequest {
    public List<int> CategoriasIds { get; set; } = new();
  }

}
