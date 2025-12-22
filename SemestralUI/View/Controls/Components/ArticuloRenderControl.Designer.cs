namespace SemestralUI.View.Controls.Components {
  partial class ArticuloRenderControl {
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      layoutArticulo = new TableLayoutPanel();
      lblNombre = new Label();
      lblCategorias = new Label();
      lblPrecio = new Label();
      tableLayoutPanel1 = new TableLayoutPanel();
      btnEditar = new Button();
      btnEliminar = new Button();
      layoutArticulo.SuspendLayout();
      tableLayoutPanel1.SuspendLayout();
      SuspendLayout();
      // 
      // layoutArticulo
      // 
      layoutArticulo.AutoSize = true;
      layoutArticulo.ColumnCount = 4;
      layoutArticulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
      layoutArticulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.5F));
      layoutArticulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
      layoutArticulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.5F));
      layoutArticulo.Controls.Add(lblNombre, 0, 0);
      layoutArticulo.Controls.Add(lblCategorias, 1, 0);
      layoutArticulo.Controls.Add(lblPrecio, 2, 0);
      layoutArticulo.Controls.Add(tableLayoutPanel1, 3, 0);
      layoutArticulo.Dock = DockStyle.Fill;
      layoutArticulo.Location = new Point(0, 0);
      layoutArticulo.Name = "layoutArticulo";
      layoutArticulo.RowCount = 1;
      layoutArticulo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      layoutArticulo.Size = new Size(990, 80);
      layoutArticulo.TabIndex = 0;
      // 
      // lblNombre
      // 
      lblNombre.Anchor = AnchorStyles.None;
      lblNombre.AutoSize = true;
      lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
      lblNombre.Location = new Point(81, 26);
      lblNombre.Name = "lblNombre";
      lblNombre.Size = new Size(85, 28);
      lblNombre.TabIndex = 0;
      lblNombre.Text = "Nombre";
      // 
      // lblCategorias
      // 
      lblCategorias.Anchor = AnchorStyles.None;
      lblCategorias.AutoSize = true;
      lblCategorias.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
      lblCategorias.Location = new Point(355, 26);
      lblCategorias.Name = "lblCategorias";
      lblCategorias.Size = new Size(105, 28);
      lblCategorias.TabIndex = 0;
      lblCategorias.Text = "Categorias";
      // 
      // lblPrecio
      // 
      lblPrecio.Anchor = AnchorStyles.None;
      lblPrecio.AutoSize = true;
      lblPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
      lblPrecio.Location = new Point(587, 26);
      lblPrecio.Name = "lblPrecio";
      lblPrecio.Size = new Size(60, 28);
      lblPrecio.TabIndex = 0;
      lblPrecio.Text = "$0.00";
      // 
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.AutoSize = true;
      tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      tableLayoutPanel1.ColumnCount = 2;
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      tableLayoutPanel1.Controls.Add(btnEditar, 0, 0);
      tableLayoutPanel1.Controls.Add(btnEliminar, 1, 0);
      tableLayoutPanel1.Dock = DockStyle.Fill;
      tableLayoutPanel1.Location = new Point(670, 3);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 1;
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      tableLayoutPanel1.Size = new Size(317, 74);
      tableLayoutPanel1.TabIndex = 1;
      // 
      // btnEditar
      // 
      btnEditar.Anchor = AnchorStyles.None;
      btnEditar.AutoSize = true;
      btnEditar.BackColor = Color.FromArgb(  255,   193,   7);
      btnEditar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      btnEditar.Location = new Point(32, 13);
      btnEditar.Margin = new Padding(0);
      btnEditar.Name = "btnEditar";
      btnEditar.Padding = new Padding(10, 5, 10, 5);
      btnEditar.Size = new Size(94, 48);
      btnEditar.TabIndex = 0;
      btnEditar.Text = "Editar";
      btnEditar.UseVisualStyleBackColor = false;
      // 
      // btnEliminar
      // 
      btnEliminar.Anchor = AnchorStyles.None;
      btnEliminar.AutoSize = true;
      btnEliminar.BackColor = Color.Red;
      btnEliminar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      btnEliminar.ForeColor = SystemColors.ControlLightLight;
      btnEliminar.Location = new Point(180, 13);
      btnEliminar.Margin = new Padding(0);
      btnEliminar.Name = "btnEliminar";
      btnEliminar.Padding = new Padding(10, 5, 10, 5);
      btnEliminar.Size = new Size(114, 48);
      btnEliminar.TabIndex = 0;
      btnEliminar.Text = "Eliminar";
      btnEliminar.UseVisualStyleBackColor = false;
      // 
      // ArticuloRenderControl
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(layoutArticulo);
      MaximumSize = new Size(990, 80);
      MinimumSize = new Size(990, 80);
      Name = "ArticuloRenderControl";
      Size = new Size(990, 80);
      layoutArticulo.ResumeLayout(false);
      layoutArticulo.PerformLayout();
      tableLayoutPanel1.ResumeLayout(false);
      tableLayoutPanel1.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    public TableLayoutPanel layoutArticulo;
    public Label lblNombre;
    public Label lblCategorias;
    public Label lblPrecio;
    public TableLayoutPanel tableLayoutPanel1;
    public Button btnEditar;
    public Button btnEliminar;
  }
}
