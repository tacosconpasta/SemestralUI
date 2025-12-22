namespace SemestralUI.View.Forms.Categorias {
  partial class AgregarCategoriasForm {
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
      btnAgregar = new Button();
      checkedCategorias = new CheckedListBox();
      txtNombre = new TextBox();
      lblNombre = new Label();
      panelTop = new Panel();
      panelTop.SuspendLayout();
      SuspendLayout();
      // 
      // lblCategoriasTitulo
      // 
      lblCategoriasTitulo.AutoSize = true;
      lblCategoriasTitulo.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
      lblCategoriasTitulo.Location = new Point(0, 0);
      lblCategoriasTitulo.Name = "lblCategoriasTitulo";
      lblCategoriasTitulo.Size = new Size(303, 46);
      lblCategoriasTitulo.TabIndex = 0;
      lblCategoriasTitulo.Text = "Agregar Categoría";
      // 
      // btnCancelar
      // 
      btnCancelar.BackColor = Color.FromArgb(  253,   236,   236);
      btnCancelar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point,  0);
      btnCancelar.ForeColor = SystemColors.ControlDarkDark;
      btnCancelar.Location = new Point(46, 517);
      btnCancelar.Name = "btnCancelar";
      btnCancelar.Size = new Size(288, 77);
      btnCancelar.TabIndex = 18;
      btnCancelar.Text = "Cancelar";
      btnCancelar.UseVisualStyleBackColor = false;
      // 
      // btnAgregar
      // 
      btnAgregar.BackColor = Color.FromArgb(  25,   185,   34);
      btnAgregar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point,  0);
      btnAgregar.ForeColor = SystemColors.ControlLightLight;
      btnAgregar.Location = new Point(730, 517);
      btnAgregar.Name = "btnAgregar";
      btnAgregar.Size = new Size(281, 77);
      btnAgregar.TabIndex = 19;
      btnAgregar.Text = "Agregar Categoria";
      btnAgregar.UseVisualStyleBackColor = false;
      // 
      // checkedCategorias
      // 
      checkedCategorias.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point,  0);
      checkedCategorias.FormattingEnabled = true;
      checkedCategorias.Location = new Point(46, 244);
      checkedCategorias.Name = "checkedCategorias";
      checkedCategorias.Size = new Size(965, 254);
      checkedCategorias.TabIndex = 17;
      // 
      // txtNombre
      // 
      txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
      txtNombre.Location = new Point(46, 189);
      txtNombre.Name = "txtNombre";
      txtNombre.Size = new Size(489, 34);
      txtNombre.TabIndex = 15;
      // 
      // lblNombre
      // 
      lblNombre.AutoSize = true;
      lblNombre.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point,  0);
      lblNombre.Location = new Point(46, 140);
      lblNombre.Name = "lblNombre";
      lblNombre.Size = new Size(101, 31);
      lblNombre.TabIndex = 11;
      lblNombre.Text = "Nombre";
      // 
      // panelTop
      // 
      panelTop.AutoSize = true;
      panelTop.Controls.Add(lblCategoriasTitulo);
      panelTop.Location = new Point(46, 53);
      panelTop.Margin = new Padding(0, 0, 0, 10);
      panelTop.Name = "panelTop";
      panelTop.Size = new Size(965, 46);
      panelTop.TabIndex = 7;
      // 
      // AgregarCategoriasForm
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = SystemColors.ControlLightLight;
      ClientSize = new Size(1082, 673);
      Controls.Add(btnCancelar);
      Controls.Add(btnAgregar);
      Controls.Add(checkedCategorias);
      Controls.Add(txtNombre);
      Controls.Add(lblNombre);
      Controls.Add(panelTop);
      Name = "AgregarCategoriasForm";
      Text = "AgregarCategoriasForm";
      panelTop.ResumeLayout(false);
      panelTop.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label lblCategoriasTitulo;
    private Button btnCancelar;
    private Button btnAgregar;
    private CheckedListBox checkedCategorias;
    private TextBox txtNombre;
    private Label lblNombre;
    private Panel panelTop;
  }
}