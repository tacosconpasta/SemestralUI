namespace SemestralUI.View.Forms.Categorias {
  partial class EditarCategoriasForm {
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
      lblCategoriasTitulo = new Label();
      btnCancelar = new Button();
      btnEditar = new Button();
      checkedCategorias = new CheckedListBox();
      txtNombre = new TextBox();
      lblNombre = new Label();
      SuspendLayout();
      // 
      // lblCategoriasTitulo
      // 
      lblCategoriasTitulo.AutoSize = true;
      lblCategoriasTitulo.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
      lblCategoriasTitulo.Location = new Point(36, 39);
      lblCategoriasTitulo.Name = "lblCategoriasTitulo";
      lblCategoriasTitulo.Size = new Size(268, 46);
      lblCategoriasTitulo.TabIndex = 20;
      lblCategoriasTitulo.Text = "Editar Categoría";
      // 
      // btnCancelar
      // 
      btnCancelar.BackColor = Color.FromArgb(  253,   236,   236);
      btnCancelar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point,  0);
      btnCancelar.ForeColor = SystemColors.ControlDarkDark;
      btnCancelar.Location = new Point(36, 501);
      btnCancelar.Name = "btnCancelar";
      btnCancelar.Size = new Size(288, 77);
      btnCancelar.TabIndex = 24;
      btnCancelar.Text = "Cancelar";
      btnCancelar.UseVisualStyleBackColor = false;
      btnCancelar.Click += btnCancelar_Click;
      // 
      // btnEditar
      // 
      btnEditar.BackColor = Color.FromArgb(  255,   193,   7);
      btnEditar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point,  0);
      btnEditar.ForeColor = SystemColors.ControlText;
      btnEditar.Location = new Point(720, 501);
      btnEditar.Name = "btnEditar";
      btnEditar.Size = new Size(281, 77);
      btnEditar.TabIndex = 25;
      btnEditar.Text = "Editar Categoría";
      btnEditar.UseVisualStyleBackColor = false;
      btnEditar.Click += btnEditar_Click;
      // 
      // checkedCategorias
      // 
      checkedCategorias.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point,  0);
      checkedCategorias.FormattingEnabled = true;
      checkedCategorias.Location = new Point(36, 229);
      checkedCategorias.Name = "checkedCategorias";
      checkedCategorias.Size = new Size(965, 254);
      checkedCategorias.TabIndex = 23;
      // 
      // txtNombre
      // 
      txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
      txtNombre.Location = new Point(36, 173);
      txtNombre.Name = "txtNombre";
      txtNombre.Size = new Size(489, 34);
      txtNombre.TabIndex = 22;
      // 
      // lblNombre
      // 
      lblNombre.AutoSize = true;
      lblNombre.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point,  0);
      lblNombre.Location = new Point(36, 124);
      lblNombre.Name = "lblNombre";
      lblNombre.Size = new Size(101, 31);
      lblNombre.TabIndex = 21;
      lblNombre.Text = "Nombre";
      // 
      // EditarCategoriasForm
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = SystemColors.ControlLightLight;
      ClientSize = new Size(1082, 673);
      Controls.Add(lblCategoriasTitulo);
      Controls.Add(btnCancelar);
      Controls.Add(btnEditar);
      Controls.Add(checkedCategorias);
      Controls.Add(txtNombre);
      Controls.Add(lblNombre);
      Name = "EditarCategoriasForm";
      Text = "EditarCategoriasForm";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label lblCategoriasTitulo;
    private Button btnCancelar;
    private Button btnEditar;
    private CheckedListBox checkedCategorias;
    private TextBox txtNombre;
    private Label lblNombre;
  }
}