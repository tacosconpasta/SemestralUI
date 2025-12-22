using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralUI.Models.DTOs {
  public class InsertarArticuloRequest {
    public string Nombre { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
    public float Precio { get; set; }
    public int Stock { get; set; }
    public bool PagaITBMS { get; set; }
  }

}
