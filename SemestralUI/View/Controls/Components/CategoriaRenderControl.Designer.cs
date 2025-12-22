namespace SemestralUI.View.Controls.Components {
  partial class CategoriaRenderControl {
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Designer generated code

    private void InitializeComponent() {
      layoutCategoria = new TableLayoutPanel();
      lblNombre = new Label();
      lblPadre = new Label();
      tableLayoutPanel1 = new TableLayoutPanel();
      btnEditar = new Button();
      btnEliminar = new Button();
      layoutCategoria.SuspendLayout();
      tableLayoutPanel1.SuspendLayout();
      SuspendLayout();
      // 
      // layoutCategoria
      // 
      layoutCategoria.AutoSize = true;
      layoutCategoria.ColumnCount = 3;
      layoutCategoria.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
      layoutCategoria.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
      layoutCategoria.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
      layoutCategoria.Controls.Add(lblNombre, 0, 0);
      layoutCategoria.Controls.Add(lblPadre, 1, 0);
      layoutCategoria.Controls.Add(tableLayoutPanel1, 2, 0);
      layoutCategoria.Dock = DockStyle.Fill;
      layoutCategoria.Location = new System.Drawing.Point(0, 0);
      layoutCategoria.Name = "layoutCategoria";
      layoutCategoria.RowCount = 1;
      layoutCategoria.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      layoutCategoria.Size = new System.Drawing.Size(990, 80);
      layoutCategoria.TabIndex = 0;
      // 
      // lblNombre
      // 
      lblNombre.Anchor = AnchorStyles.None;
      lblNombre.AutoSize = true;
      lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      lblNombre.Location = new System.Drawing.Point(81, 26);
      lblNombre.Name = "lblNombre";
      lblNombre.Size = new System.Drawing.Size(85, 28);
      lblNombre.TabIndex = 0;
      lblNombre.Text = "Nombre";
      // 
      // lblPadre
      // 
      lblPadre.Anchor = AnchorStyles.None;
      lblPadre.AutoSize = true;
      lblPadre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      lblPadre.Location = new System.Drawing.Point(400, 26);
      lblPadre.Name = "lblPadre";
      lblPadre.Size = new System.Drawing.Size(50, 28);
      lblPadre.TabIndex = 0;
      lblPadre.Text = "Padre";
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
      tableLayoutPanel1.Location = new System.Drawing.Point(670, 3);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 1;
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      tableLayoutPanel1.Size = new System.Drawing.Size(317, 74);
      tableLayoutPanel1.TabIndex = 1;
      // 
      // btnEditar
      // 
      btnEditar.Anchor = AnchorStyles.None;
      btnEditar.AutoSize = true;
      btnEditar.BackColor = System.Drawing.Color.FromArgb(255, 193, 7);
      btnEditar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      btnEditar.Location = new System.Drawing.Point(32, 13);
      btnEditar.Margin = new Padding(0);
      btnEditar.Name = "btnEditar";
      btnEditar.Padding = new Padding(10, 5, 10, 5);
      btnEditar.Size = new System.Drawing.Size(94, 48);
      btnEditar.TabIndex = 0;
      btnEditar.Text = "Editar";
      btnEditar.UseVisualStyleBackColor = false;
      // 
      // btnEliminar
      // 
      btnEliminar.Anchor = AnchorStyles.None;
      btnEliminar.AutoSize = true;
      btnEliminar.BackColor = System.Drawing.Color.Red;
      btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
      btnEliminar.Location = new System.Drawing.Point(180, 13);
      btnEliminar.Margin = new Padding(0);
      btnEliminar.Name = "btnEliminar";
      btnEliminar.Padding = new Padding(10, 5, 10, 5);
      btnEliminar.Size = new System.Drawing.Size(114, 48);
      btnEliminar.TabIndex = 0;
      btnEliminar.Text = "Eliminar";
      btnEliminar.UseVisualStyleBackColor = false;
      // 
      // CategoriaRenderControl
      // 
      AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(layoutCategoria);
      MaximumSize = new System.Drawing.Size(990, 80);
      MinimumSize = new System.Drawing.Size(990, 80);
      Name = "CategoriaRenderControl";
      Size = new System.Drawing.Size(990, 80);
      layoutCategoria.ResumeLayout(false);
      layoutCategoria.PerformLayout();
      tableLayoutPanel1.ResumeLayout(false);
      tableLayoutPanel1.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    public TableLayoutPanel layoutCategoria;
    public Label lblNombre;
    public Label lblPadre;
    public TableLayoutPanel tableLayoutPanel1;
    public Button btnEditar;
    public Button btnEliminar;
  }
}
