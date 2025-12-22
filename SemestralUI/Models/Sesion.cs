using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralUI.Models {
  //Una sesión es el objeto devuelto por la API cuando un cliente inicia sesión
  //Si un usuario administrador inicia sesión, sólo devuelve usuario

  //Esta clase existe para que, si un Cliente intenta iniciar sesión desde esta interfaz de Admin,
  //Se le pueda indicar que es un cliente y no un administrador y no tiene acceso a la interfaz
  //Para prevención de errores
  public class Sesion {
    public Usuario usuario { get; set; }
    public Cliente? cliente { get; set; }
  }
}
