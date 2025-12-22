using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralUI.Models.DTOs {
  public class OrdenRenderDTO {
    public int Id { get; set; }                 // Id de la orden
    public string Usuario_Nombre { get; set; } // Nombre del usuario
    public decimal Total { get; set; }         // Total de la orden

    // Constructor opcional para facilidad
    public OrdenRenderDTO(int id, string usuarioNombre, decimal total) {
      Id = id;
      Usuario_Nombre = usuarioNombre;
      Total = total;
    }

    public OrdenRenderDTO() { }
  }
}
