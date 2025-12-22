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
      SuspendLayout();
      // 
      // btnIniciar
      // 
      btnIniciar.BackColor = SystemColors.ActiveCaptionText;
      btnIniciar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      btnIniciar.ForeColor = SystemColors.ControlLightLight;
      btnIniciar.Location = new Point(385, 488);
      btnIniciar.Margin = new Padding(2, 2, 2, 2);
      btnIniciar.Name = "btnIniciar";
      btnIniciar.Size = new Size(286, 59);
      btnIniciar.TabIndex = 10;
      btnIniciar.Text = "Iniciar Sesión";
      btnIniciar.UseVisualStyleBackColor = false;
      btnIniciar.Click += btnIniciar_Click;
      // 
      // lblContra
      // 
      lblContra.AutoSize = true;
      lblContra.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
      lblContra.Location = new Point(385, 325);
      lblContra.Margin = new Padding(2, 0, 2, 0);
      lblContra.Name = "lblContra";
      lblContra.Size = new Size(114, 28);
      lblContra.TabIndex = 6;
      lblContra.Text = "Contraseña";
      // 
      // lblUsuario
      // 
      lblUsuario.AutoSize = true;
      lblUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
      lblUsuario.Location = new Point(385, 225);
      lblUsuario.Margin = new Padding(2, 0, 2, 0);
      lblUsuario.Name = "lblUsuario";
      lblUsuario.Size = new Size(191, 28);
      lblUsuario.TabIndex = 7;
      lblUsuario.Text = "Nombre de Usuario";
      // 
      // lblTitulo
      // 
      lblTitulo.AutoSize = true;
      lblTitulo.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
      lblTitulo.Location = new Point(420, 104);
      lblTitulo.Margin = new Padding(2, 0, 2, 0);
      lblTitulo.Name = "lblTitulo";
      lblTitulo.Size = new Size(222, 46);
      lblTitulo.TabIndex = 8;
      lblTitulo.Text = "Inicia Sesión!";
      // 
      // txtContra
      // 
      txtContra.BackColor = SystemColors.Control;
      txtContra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
      txtContra.Location = new Point(385, 362);
      txtContra.Margin = new Padding(2, 2, 2, 2);
      txtContra.MaxLength = 25;
      txtContra.Name = "txtContra";
      txtContra.Size = new Size(286, 34);
      txtContra.TabIndex = 9;
      // 
      // txtCorreo
      // 
      txtCorreo.BackColor = SystemColors.Control;
      txtCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
      txtCorreo.Location = new Point(385, 262);
      txtCorreo.Margin = new Padding(2, 2, 2, 2);
      txtCorreo.MaxLength = 25;
      txtCorreo.Name = "txtCorreo";
      txtCorreo.Size = new Size(286, 34);
      txtCorreo.TabIndex = 5;
      txtCorreo.TextChanged += txtCorreo_TextChanged;
      // 
      // InicioSesionForm
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = SystemColors.ControlLightLight;
      ClientSize = new Size(1082, 673);
      Controls.Add(btnIniciar);
      Controls.Add(lblContra);
      Controls.Add(lblUsuario);
      Controls.Add(lblTitulo);
      Controls.Add(txtContra);
      Controls.Add(txtCorreo);
      Margin = new Padding(2, 2, 2, 2);
      Name = "InicioSesionForm";
      Text = "InicioSesion";
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
  }
}