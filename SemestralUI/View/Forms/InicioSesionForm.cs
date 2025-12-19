using SemestralUI.Models;
using SemestralUI.Models.Events;
using System.Text;
using System.Text.Json;

namespace SemestralUI.Forms {
  public partial class InicioSesionForm : Form {
    //Solicitar cambio de pantalla
    public event EventHandler<UsuarioEventArgs>? SolicitarCambio;


    public InicioSesionForm() {
      InitializeComponent();
      //Convertir caracteres de contraseña a asteríscos
      txtContra.PasswordChar = '*';

    }

    //Verifica si los campos de entrada (correo y contraseña) son válidos
    private bool SonEntradasValidas() {
      //Validar entradas
      //Correo
      if (string.IsNullOrWhiteSpace(txtCorreo.Text)) {
        MessageBox.Show(
            "Por favor ingrese su correo electrónico.",
            "Campo Requerido",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        );
        txtCorreo.Focus();
        return false;
      }

      //Contraseña
      if (string.IsNullOrWhiteSpace(txtContra.Text)) {
        MessageBox.Show(
            "Por favor ingrese su contraseña.",
            "Campo Requerido",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        );
        txtContra.Focus();
        return false;
      }

      return true;
    }

    private async void btnIniciar_Click(object sender, EventArgs e) {
      //Deshabilitar botón mientras se ejecuta la verificación
      btnIniciar.Enabled = false;
      btnIniciar.BackColor = SystemColors.ControlDark;
      btnIniciar.Text = "Iniciando Sesión...";

      //Si las entradas no son válidas
      if (!SonEntradasValidas()) {
        btnIniciar.Enabled = true;
        btnIniciar.BackColor = SystemColors.ActiveCaptionText;
        btnIniciar.Text = "Iniciar Sesión";
        return;
      }

      try {
        //Crear cliente HTTP
        using HttpClient client = new HttpClient();

        //Construir objeto según LoginRequest del API
        var loginRequest = new {
          user = txtCorreo.Text.Trim(),
          contrasena = txtContra.Text.Trim()
        };

        //Serializar datos a JSON
        string jsonEnvio = JsonSerializer.Serialize(loginRequest);
        HttpContent content = new StringContent(jsonEnvio, Encoding.UTF8, "application/json");

        //Enviar solicitud al controller
        HttpResponseMessage response = await client.PostAsync(
            "http://srv595743.hstgr.cloud:5000/api/auth/login",
            content
        );

        //Si la respuesta es exitosa
        if (response.IsSuccessStatusCode) {
          //Leer respuesta (es un string JSON)
          string jsonRespuesta = await response.Content.ReadAsStringAsync();

          //Deserializar string JSON interno
          string jsonUsuario = JsonSerializer.Deserialize<string>(jsonRespuesta)!;

          //Deserializar usuario final
          Usuario usuario = JsonSerializer.Deserialize<Usuario>(jsonUsuario)!;

          //Cambiar pantalla y enviar usuario a Main
          MessageBox.Show(
              "Su inicio de sesión fue exitoso! \nSerá redirigido al menú inicial",
              "Éxito",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information
          );

          SolicitarCambio!.Invoke(sender, new UsuarioEventArgs(usuario));
          return;
        }

        //Credenciales inválidas
        MessageBox.Show(
            "No se encontró ningún usuario con esas credenciales.",
            "Acceso denegado",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        );

      } catch (Exception ex) {
        MessageBox.Show(
            $"Error al iniciar sesión: {ex.Message}",
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        );
      }

      //Restaurar botón
      btnIniciar.Enabled = true;
      btnIniciar.BackColor = SystemColors.ActiveCaptionText;
      btnIniciar.Text = "Iniciar Sesión";
    }

  }
}
