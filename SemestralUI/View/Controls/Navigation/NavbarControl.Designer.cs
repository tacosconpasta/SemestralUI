namespace SemestralUI.View.Controls {
  partial class NavbarControl {
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
      tableLayoutPanel1 = new TableLayoutPanel();
      lblCategorias = new Label();
      lblOrdenes = new Label();
      lblTransacciones = new Label();
      lblArtículos = new Label();
      tableLayoutPanel1.SuspendLayout();
      SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.BackColor = SystemColors.ControlText;
      tableLayoutPanel1.ColumnCount = 4;
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
      tableLayoutPanel1.Controls.Add(lblCategorias, 1, 0);
      tableLayoutPanel1.Controls.Add(lblOrdenes, 2, 0);
      tableLayoutPanel1.Controls.Add(lblTransacciones, 3, 0);
      tableLayoutPanel1.Controls.Add(lblArtículos, 0, 0);
      tableLayoutPanel1.Dock = DockStyle.Top;
      tableLayoutPanel1.Location = new Point(0, 0);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 1;
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      tableLayoutPanel1.Size = new Size(1080, 70);
      tableLayoutPanel1.TabIndex = 0;
      // 
      // lblCategorias
      // 
      lblCategorias.Anchor = AnchorStyles.None;
      lblCategorias.AutoSize = true;
      lblCategorias.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      lblCategorias.ForeColor = SystemColors.ControlLightLight;
      lblCategorias.Location = new Point(351, 21);
      lblCategorias.Name = "lblCategorias";
      lblCategorias.Size = new Size(107, 28);
      lblCategorias.TabIndex = 0;
      lblCategorias.Text = "Categorias";
      // 
      // lblOrdenes
      // 
      lblOrdenes.Anchor = AnchorStyles.None;
      lblOrdenes.AutoSize = true;
      lblOrdenes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      lblOrdenes.ForeColor = SystemColors.ControlLightLight;
      lblOrdenes.Location = new Point(630, 21);
      lblOrdenes.Name = "lblOrdenes";
      lblOrdenes.Size = new Size(89, 28);
      lblOrdenes.TabIndex = 0;
      lblOrdenes.Text = "Ordenes";
      // 
      // lblTransacciones
      // 
      lblTransacciones.Anchor = AnchorStyles.None;
      lblTransacciones.AutoSize = true;
      lblTransacciones.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      lblTransacciones.ForeColor = SystemColors.ControlLightLight;
      lblTransacciones.Location = new Point(877, 21);
      lblTransacciones.Name = "lblTransacciones";
      lblTransacciones.Size = new Size(136, 28);
      lblTransacciones.TabIndex = 0;
      lblTransacciones.Text = "Transacciones";
      // 
      // lblArtículos
      // 
      lblArtículos.Anchor = AnchorStyles.None;
      lblArtículos.AutoSize = true;
      lblArtículos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      lblArtículos.ForeColor = SystemColors.ControlLightLight;
      lblArtículos.Location = new Point(89, 21);
      lblArtículos.Name = "lblArtículos";
      lblArtículos.Size = new Size(92, 28);
      lblArtículos.TabIndex = 0;
      lblArtículos.Text = "Artículos";
      // 
      // NavbarControl
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = SystemColors.ControlLightLight;
      Controls.Add(tableLayoutPanel1);
      Name = "NavbarControl";
      Size = new Size(1080, 70);
      tableLayoutPanel1.ResumeLayout(false);
      tableLayoutPanel1.PerformLayout();
      ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private Label lblArtículos;
    private Label lblCategorias;
    private Label lblOrdenes;
    private Label lblTransacciones;
  }
}
