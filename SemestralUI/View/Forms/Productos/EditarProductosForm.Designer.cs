namespace SemestralUI.View.Forms.Productos {
  partial class EditarProductosForm {
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
      lblArticulosTitulo = new Label();
      btnCancelar = new Button();
      btnEditar = new Button();
      checkedCategorias = new CheckedListBox();
      chkITBMS = new CheckBox();
      textBox2 = new TextBox();
      lblPrecio = new Label();
      textBox1 = new TextBox();
      lblStock = new Label();
      textBox3 = new TextBox();
      lblDescripcion = new Label();
      txtNombre = new TextBox();
      lblNombre = new Label();
      panelTop = new Panel();
      panelTop.SuspendLayout();
      SuspendLayout();
      // 
      // lblArticulosTitulo
      // 
      lblArticulosTitulo.AutoSize = true;
      lblArticulosTitulo.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
      lblArticulosTitulo.Location = new Point(0, 0);
      lblArticulosTitulo.Name = "lblArticulosTitulo";
      lblArticulosTitulo.Size = new Size(242, 46);
      lblArticulosTitulo.TabIndex = 0;
      lblArticulosTitulo.Text = "Editar Artículo";
      // 
      // btnCancelar
      // 
      btnCancelar.BackColor = Color.FromArgb(  253,   236,   236);
      btnCancelar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point,  0);
      btnCancelar.ForeColor = SystemColors.ControlDarkDark;
      btnCancelar.Location = new Point(43, 561);
      btnCancelar.Name = "btnCancelar";
      btnCancelar.Size = new Size(231, 77);
      btnCancelar.TabIndex = 18;
      btnCancelar.Text = "Cancelar";
      btnCancelar.UseVisualStyleBackColor = false;
      // 
      // btnEditar
      // 
      btnEditar.BackColor = Color.FromArgb(  255,   193,   7);
      btnEditar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point,  0);
      btnEditar.ForeColor = SystemColors.ControlText;
      btnEditar.Location = new Point(280, 561);
      btnEditar.Name = "btnEditar";
      btnEditar.Size = new Size(249, 77);
      btnEditar.TabIndex = 19;
      btnEditar.Text = "Editar Artículo";
      btnEditar.UseVisualStyleBackColor = false;
      btnEditar.Click += btnEditar_Click;
      // 
      // checkedCategorias
      // 
      checkedCategorias.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point,  0);
      checkedCategorias.FormattingEnabled = true;
      checkedCategorias.Location = new Point(629, 370);
      checkedCategorias.Name = "checkedCategorias";
      checkedCategorias.Size = new Size(379, 254);
      checkedCategorias.TabIndex = 17;
      // 
      // chkITBMS
      // 
      chkITBMS.AutoSize = true;
      chkITBMS.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      chkITBMS.Location = new Point(40, 455);
      chkITBMS.Name = "chkITBMS";
      chkITBMS.Size = new Size(150, 32);
      chkITBMS.TabIndex = 16;
      chkITBMS.Text = "Paga ITBMS?";
      chkITBMS.UseVisualStyleBackColor = true;
      // 
      // textBox2
      // 
      textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
      textBox2.Location = new Point(843, 233);
      textBox2.Name = "textBox2";
      textBox2.Size = new Size(165, 34);
      textBox2.TabIndex = 12;
      // 
      // lblPrecio
      // 
      lblPrecio.AutoSize = true;
      lblPrecio.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point,  0);
      lblPrecio.Location = new Point(843, 184);
      lblPrecio.Name = "lblPrecio";
      lblPrecio.Size = new Size(79, 31);
      lblPrecio.TabIndex = 8;
      lblPrecio.Text = "Precio";
      // 
      // textBox1
      // 
      textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
      textBox1.Location = new Point(629, 233);
      textBox1.Name = "textBox1";
      textBox1.Size = new Size(165, 34);
      textBox1.TabIndex = 13;
      // 
      // lblStock
      // 
      lblStock.AutoSize = true;
      lblStock.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point,  0);
      lblStock.Location = new Point(629, 184);
      lblStock.Name = "lblStock";
      lblStock.Size = new Size(71, 31);
      lblStock.TabIndex = 9;
      lblStock.Text = "Stock";
      // 
      // textBox3
      // 
      textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
      textBox3.Location = new Point(40, 370);
      textBox3.Name = "textBox3";
      textBox3.Size = new Size(489, 34);
      textBox3.TabIndex = 14;
      // 
      // lblDescripcion
      // 
      lblDescripcion.AutoSize = true;
      lblDescripcion.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point,  0);
      lblDescripcion.Location = new Point(40, 321);
      lblDescripcion.Name = "lblDescripcion";
      lblDescripcion.Size = new Size(137, 31);
      lblDescripcion.TabIndex = 10;
      lblDescripcion.Text = "Descripción";
      // 
      // txtNombre
      // 
      txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
      txtNombre.Location = new Point(43, 233);
      txtNombre.Name = "txtNombre";
      txtNombre.Size = new Size(489, 34);
      txtNombre.TabIndex = 15;
      // 
      // lblNombre
      // 
      lblNombre.AutoSize = true;
      lblNombre.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point,  0);
      lblNombre.Location = new Point(43, 184);
      lblNombre.Name = "lblNombre";
      lblNombre.Size = new Size(101, 31);
      lblNombre.TabIndex = 11;
      lblNombre.Text = "Nombre";
      // 
      // panelTop
      // 
      panelTop.AutoSize = true;
      panelTop.Controls.Add(lblArticulosTitulo);
      panelTop.Location = new Point(40, 69);
      panelTop.Margin = new Padding(0, 0, 0, 10);
      panelTop.Name = "panelTop";
      panelTop.Size = new Size(968, 46);
      panelTop.TabIndex = 7;
      // 
      // EditarProductosForm
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = SystemColors.ControlLightLight;
      ClientSize = new Size(1082, 673);
      Controls.Add(btnCancelar);
      Controls.Add(btnEditar);
      Controls.Add(checkedCategorias);
      Controls.Add(chkITBMS);
      Controls.Add(textBox2);
      Controls.Add(lblPrecio);
      Controls.Add(textBox1);
      Controls.Add(lblStock);
      Controls.Add(textBox3);
      Controls.Add(lblDescripcion);
      Controls.Add(txtNombre);
      Controls.Add(lblNombre);
      Controls.Add(panelTop);
      Name = "EditarProductosForm";
      Text = "EditarProductosForm";
      panelTop.ResumeLayout(false);
      panelTop.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label lblArticulosTitulo;
    private Button btnCancelar;
    private Button btnEditar;
    private CheckedListBox checkedCategorias;
    private CheckBox chkITBMS;
    private TextBox textBox2;
    private Label lblPrecio;
    private TextBox textBox1;
    private Label lblStock;
    private TextBox textBox3;
    private Label lblDescripcion;
    private TextBox txtNombre;
    private Label lblNombre;
    private Panel panelTop;
  }
}