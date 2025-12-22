using SemestralUI.Forms;
using SemestralUI.Models;
using SemestralUI.Models.Events;
using SemestralUI.View.Controls;
using SemestralUI.View.Forms;
using SemestralUI.View.Forms.Categorias;
using SemestralUI.View.Forms.Productos;

namespace Parcial2 {
  public partial class MainForm : Form {

    //Usuario autenticado actualmente
    Usuario? usuario;

    //Indice de navegación seleccionado
    int indiceNavegacion;

    public MainForm() {
      InitializeComponent();
      indiceNavegacion = 0;
    }

    public void MainForm_Load(object sender, EventArgs e) {

      //Instanciar formulario de inicio de sesión
      InicioSesionForm inicioSesionForm = new InicioSesionForm();

      //Suscribirse al evento que notifica login exitoso
      inicioSesionForm.SolicitarCambio += InicioSesionHandler!;

      //Renderizar login como primera vista
      RenderizarForm(inicioSesionForm);
    }

    private void RenderizarForm(Form formARenderizar) {

      //Permitir que el formulario ocupe todo el panel
      formARenderizar.Dock = DockStyle.Fill;

      //Evitar que se comporte como ventana independiente
      formARenderizar.TopLevel = false;

      //Eliminar bordes del formulario renderizado
      formARenderizar.FormBorderStyle = FormBorderStyle.None;

      //Si ya hay formularios renderizados
      if (renderPanel.Controls.Count > 0) {

        //Cerrar cada formulario existente antes de reemplazarlo
        foreach (Form form in renderPanel.Controls) {
          form.Close();
        }

        //Eliminar referencias de controles antiguos
        renderPanel.Controls.Clear();
      }

      //Añadir nuevo formulario al panel
      renderPanel.Controls.Add(formARenderizar);

      //Mostrar formulario renderizado
      formARenderizar.Show();
    }

    private void InicioSesionHandler(object sender, UsuarioEventArgs e) {

      //Guardar usuario autenticado recibido desde el login
      usuario = e.User;

      //Activar barra de navegación
      navbarPanel.Visible = true;

      //Escuchar eventos de navegación emitidos por la barra
      navbarPanel.NavegacionSolicitada += NavegacionHandler!;

      //Anclar barra en la parte superior
      navbarPanel.Dock = DockStyle.Top;

      //Renderizar vista inicial luego del login
      NavegarA(0);
    }

    private void NavegacionHandler(object sender, NavegacionEventArgs e) {

      //Actualizar indice de navegación solicitado por la barra
      NavegarA(e.Indice);
    }

    private void AgregarProductosHandler(object? sender, EventArgs e) {
      //Renderizar AgregarProductos
      AgregarProductosForm form = new AgregarProductosForm();
      RenderizarForm(form);

      //Escuchar botón volver a ListarProductos
      form.SolicitarCambioListarProductosForm += NavegacionHandler;
    }

    private void NavegarA(int indice) {

      //Guardar indice actual de navegación
      indiceNavegacion = indice;

      //Formulario a renderizar
      Form formARenderizar;

      switch (indiceNavegacion) {

        //Indice 0: listado de productos
        case 0: {
            var listarArticulosForm = new ListarProductosForm();

            //Escuchar solicitud interna de navegación a Agregar Artículo
            listarArticulosForm.SolicitarCambioAgregarProductosForm += AgregarProductosHandler;

            formARenderizar = listarArticulosForm;
            break;
          }

        //Indice 1: agregar artículo
        case 1: {
            var listarCategoriasForm = new ListarCategoriasForm();
            formARenderizar = listarCategoriasForm;
            break;
          }

        //Indices reservados
        default: {
            formARenderizar = new ListarProductosForm();
            break;
          }
      }

      //Renderizar formulario resultante
      RenderizarForm(formARenderizar);
    }
  }
}
