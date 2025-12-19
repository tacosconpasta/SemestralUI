namespace SemestralUI.Forms {
  partial class InicioSesionForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      btnIniciar = new Button();
      lblContra = new Label();
      lblUsuario = new Label();
      lblTitulo = new Label();
      txtContra = new TextBox();
      txtCorreo = new TextBox();
      picLogo = new PictureBox();
      ((System.ComponentModel.ISupportInitialize) picLogo).BeginInit();
      SuspendLayout();
      // 
      // btnIniciar
      // 
      btnIniciar.BackColor = SystemColors.ActiveCaptionText;
      btnIniciar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      btnIniciar.ForeColor = SystemColors.ControlLightLight;
      btnIniciar.Location = new Point(20, 403);
      btnIniciar.Name = "btnIniciar";
      btnIniciar.Size = new Size(357, 74);
      btnIniciar.TabIndex = 10;
      btnIniciar.Text = "Iniciar Sesión";
      btnIniciar.UseVisualStyleBackColor = false;
      btnIniciar.Click += btnIniciar_Click;
      // 
      // lblContra
      // 
      lblContra.AutoSize = true;
      lblContra.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
      lblContra.Location = new Point(20, 261);
      lblContra.Name = "lblContra";
      lblContra.Size = new Size(138, 32);
      lblContra.TabIndex = 6;
      lblContra.Text = "Contraseña";
      // 
      // lblUsuario
      // 
      lblUsuario.AutoSize = true;
      lblUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
      lblUsuario.Location = new Point(20, 142);
      lblUsuario.Name = "lblUsuario";
      lblUsuario.Size = new Size(214, 32);
      lblUsuario.TabIndex = 7;
      lblUsuario.Text = "Correo Electrónico";
      // 
      // lblTitulo
      // 
      lblTitulo.AutoSize = true;
      lblTitulo.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
      lblTitulo.Location = new Point(64, 41);
      lblTitulo.Name = "lblTitulo";
      lblTitulo.Size = new Size(258, 54);
      lblTitulo.TabIndex = 8;
      lblTitulo.Text = "Inicia Sesión!";
      // 
      // txtContra
      // 
      txtContra.BackColor = SystemColors.Control;
      txtContra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
      txtContra.Location = new Point(20, 307);
      txtContra.MaxLength = 25;
      txtContra.Name = "txtContra";
      txtContra.Size = new Size(357, 39);
      txtContra.TabIndex = 9;
      // 
      // txtCorreo
      // 
      txtCorreo.BackColor = SystemColors.Control;
      txtCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
      txtCorreo.Location = new Point(20, 188);
      txtCorreo.MaxLength = 25;
      txtCorreo.Name = "txtCorreo";
      txtCorreo.Size = new Size(357, 39);
      txtCorreo.TabIndex = 5;
      // 
      // picLogo
      // 
      picLogo.Location = new Point(419, 12);
      picLogo.Name = "picLogo";
      picLogo.Size = new Size(387, 514);
      picLogo.SizeMode = PictureBoxSizeMode.Zoom;
      picLogo.TabIndex = 4;
      picLogo.TabStop = false;
      // 
      // InicioSesionForm
      // 
      AutoScaleDimensions = new SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = SystemColors.ControlLightLight;
      ClientSize = new Size(826, 538);
      Controls.Add(btnIniciar);
      Controls.Add(lblContra);
      Controls.Add(lblUsuario);
      Controls.Add(lblTitulo);
      Controls.Add(txtContra);
      Controls.Add(txtCorreo);
      Controls.Add(picLogo);
      Name = "InicioSesionForm";
      Text = "InicioSesion";
      ((System.ComponentModel.ISupportInitialize) picLogo).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button btnIniciar;
    private Label lblContra;
    private Label lblUsuario;
    private Label lblTitulo;
    private TextBox txtContra;
    private TextBox txtCorreo;
    private PictureBox picLogo;
  }
}