namespace SemestralUI.View.Forms.Productos {
  partial class AgregarProductosForm {
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
      mainContainer = new Panel();
      btnCancelar = new Button();
      btnAgregar = new Button();
      checkedCategorias = new CheckedListBox();
      chkITBMS = new CheckBox();
      textBox2 = new TextBox();
      lblPrecio = new Label();
      textBox1 = new TextBox();
      lblStock = new Label();
      textBox3 = new TextBox();
      lblCategorias = new Label();
      lblDescripcion = new Label();
      txtNombre = new TextBox();
      lblNombre = new Label();
      panelTop = new Panel();
      lblArticulosTitulo = new Label();
      mainContainer.SuspendLayout();
      panelTop.SuspendLayout();
      SuspendLayout();
      // 
      // mainContainer
      // 
      mainContainer.AutoSize = true;
      mainContainer.Controls.Add(btnCancelar);
      mainContainer.Controls.Add(btnAgregar);
      mainContainer.Controls.Add(checkedCategorias);
      mainContainer.Controls.Add(chkITBMS);
      mainContainer.Controls.Add(textBox2);
      mainContainer.Controls.Add(lblPrecio);
      mainContainer.Controls.Add(textBox1);
      mainContainer.Controls.Add(lblStock);
      mainContainer.Controls.Add(textBox3);
      mainContainer.Controls.Add(lblCategorias);
      mainContainer.Controls.Add(lblDescripcion);
      mainContainer.Controls.Add(txtNombre);
      mainContainer.Controls.Add(lblNombre);
      mainContainer.Controls.Add(panelTop);
      mainContainer.Dock = DockStyle.Fill;
      mainContainer.Location = new Point(0, 0);
      mainContainer.Name = "mainContainer";
      mainContainer.Padding = new Padding(40, 40, 20, 40);
      mainContainer.Size = new Size(1082, 673);
      mainContainer.TabIndex = 2;
      // 
      // btnCancelar
      // 
      btnCancelar.BackColor = Color.FromArgb(  253,   236,   236);
      btnCancelar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point,  0);
      btnCancelar.ForeColor = SystemColors.ControlDarkDark;
      btnCancelar.Location = new Point(43, 527);
      btnCancelar.Name = "btnCancelar";
      btnCancelar.Size = new Size(231, 77);
      btnCancelar.TabIndex = 6;
      btnCancelar.Text = "Cancelar";
      btnCancelar.UseVisualStyleBackColor = false;
      btnCancelar.Click += btnCancelar_Click;
      // 
      // btnAgregar
      // 
      btnAgregar.BackColor = Color.FromArgb(  25,   185,   34);
      btnAgregar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point,  0);
      btnAgregar.ForeColor = SystemColors.ControlLightLight;
      btnAgregar.Location = new Point(280, 527);
      btnAgregar.Name = "btnAgregar";
      btnAgregar.Size = new Size(249, 77);
      btnAgregar.TabIndex = 6;
      btnAgregar.Text = "Agregar Artículo";
      btnAgregar.UseVisualStyleBackColor = false;
      btnAgregar.Click += btnAgregar_Click;
      // 
      // checkedCategorias
      // 
      checkedCategorias.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point,  0);
      checkedCategorias.FormattingEnabled = true;
      checkedCategorias.Location = new Point(629, 336);
      checkedCategorias.Name = "checkedCategorias";
      checkedCategorias.Size = new Size(379, 254);
      checkedCategorias.TabIndex = 5;
      // 
      // chkITBMS
      // 
      chkITBMS.AutoSize = true;
      chkITBMS.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      chkITBMS.Location = new Point(40, 421);
      chkITBMS.Name = "chkITBMS";
      chkITBMS.Size = new Size(150, 32);
      chkITBMS.TabIndex = 4;
      chkITBMS.Text = "Paga ITBMS?";
      chkITBMS.UseVisualStyleBackColor = true;
      // 
      // textBox2
      // 
      textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
      textBox2.Location = new Point(843, 199);
      textBox2.Name = "textBox2";
      textBox2.Size = new Size(165, 34);
      textBox2.TabIndex = 3;
      // 
      // lblPrecio
      // 
      lblPrecio.AutoSize = true;
      lblPrecio.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point,  0);
      lblPrecio.Location = new Point(843, 150);
      lblPrecio.Name = "lblPrecio";
      lblPrecio.Size = new Size(79, 31);
      lblPrecio.TabIndex = 2;
      lblPrecio.Text = "Precio";
      // 
      // textBox1
      // 
      textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
      textBox1.Location = new Point(629, 199);
      textBox1.Name = "textBox1";
      textBox1.Size = new Size(165, 34);
      textBox1.TabIndex = 3;
      // 
      // lblStock
      // 
      lblStock.AutoSize = true;
      lblStock.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point,  0);
      lblStock.Location = new Point(629, 150);
      lblStock.Name = "lblStock";
      lblStock.Size = new Size(71, 31);
      lblStock.TabIndex = 2;
      lblStock.Text = "Stock";
      // 
      // textBox3
      // 
      textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
      textBox3.Location = new Point(40, 336);
      textBox3.Name = "textBox3";
      textBox3.Size = new Size(489, 34);
      textBox3.TabIndex = 3;
      // 
      // lblCategorias
      // 
      lblCategorias.AutoSize = true;
      lblCategorias.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point,  0);
      lblCategorias.Location = new Point(629, 287);
      lblCategorias.Name = "lblCategorias";
      lblCategorias.Size = new Size(125, 31);
      lblCategorias.TabIndex = 2;
      lblCategorias.Text = "Categorías";
      // 
      // lblDescripcion
      // 
      lblDescripcion.AutoSize = true;
      lblDescripcion.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point,  0);
      lblDescripcion.Location = new Point(40, 287);
      lblDescripcion.Name = "lblDescripcion";
      lblDescripcion.Size = new Size(137, 31);
      lblDescripcion.TabIndex = 2;
      lblDescripcion.Text = "Descripción";
      // 
      // txtNombre
      // 
      txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
      txtNombre.Location = new Point(43, 199);
      txtNombre.Name = "txtNombre";
      txtNombre.Size = new Size(489, 34);
      txtNombre.TabIndex = 3;
      // 
      // lblNombre
      // 
      lblNombre.AutoSize = true;
      lblNombre.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point,  0);
      lblNombre.Location = new Point(43, 150);
      lblNombre.Name = "lblNombre";
      lblNombre.Size = new Size(101, 31);
      lblNombre.TabIndex = 2;
      lblNombre.Text = "Nombre";
      // 
      // panelTop
      // 
      panelTop.AutoSize = true;
      panelTop.Controls.Add(lblArticulosTitulo);
      panelTop.Dock = DockStyle.Top;
      panelTop.Location = new Point(40, 40);
      panelTop.Margin = new Padding(0, 0, 0, 10);
      panelTop.Name = "panelTop";
      panelTop.Size = new Size(1022, 46);
      panelTop.TabIndex = 1;
      // 
      // lblArticulosTitulo
      // 
      lblArticulosTitulo.AutoSize = true;
      lblArticulosTitulo.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
      lblArticulosTitulo.Location = new Point(0, 0);
      lblArticulosTitulo.Name = "lblArticulosTitulo";
      lblArticulosTitulo.Size = new Size(277, 46);
      lblArticulosTitulo.TabIndex = 0;
      lblArticulosTitulo.Text = "Agregar Artículo";
      // 
      // AgregarProductosForm
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = SystemColors.ControlLightLight;
      ClientSize = new Size(1082, 673);
      Controls.Add(mainContainer);
      Name = "AgregarProductosForm";
      Text = "AgregarProductosForm";
      mainContainer.ResumeLayout(false);
      mainContainer.PerformLayout();
      panelTop.ResumeLayout(false);
      panelTop.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Panel mainContainer;
    private Panel panelTop;
    private Label lblArticulosTitulo;
    private TextBox txtNombre;
    private Label lblNombre;
    private CheckedListBox checkedCategorias;
    private CheckBox chkITBMS;
    private TextBox textBox2;
    private Label lblPrecio;
    private TextBox textBox1;
    private Label lblStock;
    private TextBox textBox3;
    private Label lblCategorias;
    private Label lblDescripcion;
    private Button btnAgregar;
    private Button btnCancelar;
  }
}