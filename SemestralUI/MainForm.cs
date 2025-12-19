using SemestralUI.Forms;
using SemestralUI.Models;
using SemestralUI.Models.Events;
using SemestralUI.View.Forms;

namespace Parcial2 {
  public partial class MainForm : Form {
    Usuario? usuario;
    //Indica indice de la cuenta seleccionada, actualmente, por usuario
    int indiceCuentaSeleccionada;

    public MainForm() {
      InitializeComponent();
    }

    public void MainForm_Load(object sender, EventArgs e) {
      InicioSesionForm inicioSesionForm = new InicioSesionForm();
      RenderizarForm(inicioSesionForm);

      inicioSesionForm.SolicitarCambio += InicioSesionHandler!;
    }

    //Renderiza formARenderizar en panel
    private void RenderizarForm(Form formARenderizar) {

      //Permite que la Form a renderizar llene el panel
      formARenderizar.Dock = DockStyle.Fill;

      //No renderizar Form como una ventana top-level
      formARenderizar.TopLevel = false;

      //No renderizar bordes de ventana
      formARenderizar.FormBorderStyle = FormBorderStyle.None;

      //Cerrar Form anterior, si existe
      if (renderPanel.Controls.Count > 0) {
        foreach (Form form in renderPanel.Controls) {
          //Cerrar forms
          form.Close();
        }

        //Limpiar referencias de forms instanciados, o otros controles, dentro de renderPanel
        renderPanel.Controls.Clear();
      }

      //Añadir form a renderizar
      renderPanel.Controls.Add(formARenderizar);

      //Mostrar form
      formARenderizar.Show();
    }

    //Renderizar Menu Elegir Cuenta
    private void InicioSesionHandler(object sender, UsuarioEventArgs e) {
      //Obtener objeto de usuario desde evento
      usuario = e.User;

      //MenuInicioForm menuInicioForm = new MenuInicioForm(usuario);
      //renderizarForm(menuInicioForm);
      //menuInicioForm.SolicitarCambio += MenuInicioHandler;
    }
  }
}
