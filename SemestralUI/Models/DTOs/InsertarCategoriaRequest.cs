using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralUI.Models.DTOs {

  public class InsertarCategoriaRequest {
    public string Nombre { get; set; }
    public int CategoriaPadreId { get; set; }
  }
}
