using System;

namespace SemestralUI.Models.DTOs {
  public class FacturaRenderDTO {
    public int Id { get; set; }               // Id de la factura
    public string Usuario_Nombre { get; set; } // Nombre del usuario que generó la factura
    public DateTime Fecha { get; set; }       // Fecha de la factura
    public float Subtotal { get; set; }       // Subtotal de la factura
    public float Itbms { get; set; }          // Impuesto aplicado
    public float Total { get; set; }          // Total final
  }
}
