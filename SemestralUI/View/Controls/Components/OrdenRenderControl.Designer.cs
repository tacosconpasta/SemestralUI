namespace SemestralUI.View.Controls.Components {
  partial class OrdenRenderControl {
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    private void InitializeComponent() {
      layoutOrden = new TableLayoutPanel();
      lblId = new Label();
      lblUsuario = new Label();
      lblTotal = new Label();
      tableLayoutPanel1 = new TableLayoutPanel();
      btnAceptar = new Button();
      btnCancelar = new Button();
      layoutOrden.SuspendLayout();
      tableLayoutPanel1.SuspendLayout();
      SuspendLayout();
      // 
      // layoutOrden
      // 
      layoutOrden.AutoSize = true;
      layoutOrden.ColumnCount = 4;
      layoutOrden.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
      layoutOrden.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
      layoutOrden.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
      layoutOrden.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
      layoutOrden.Controls.Add(lblId, 0, 0);
      layoutOrden.Controls.Add(lblUsuario, 1, 0);
      layoutOrden.Controls.Add(lblTotal, 2, 0);
      layoutOrden.Controls.Add(tableLayoutPanel1, 3, 0);
      layoutOrden.Dock = DockStyle.Fill;
      layoutOrden.Location = new Point(0, 0);
      layoutOrden.Name = "layoutOrden";
      layoutOrden.RowCount = 1;
      layoutOrden.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      layoutOrden.Size = new Size(990, 80);
      layoutOrden.TabIndex = 0;
      // 
      // lblId
      // 
      lblId.Anchor = AnchorStyles.None;
      lblId.AutoSize = true;
      lblId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
      lblId.Location = new Point(59, 26);
      lblId.Name = "lblId";
      lblId.Size = new Size(29, 28);
      lblId.TabIndex = 0;
      lblId.Text = "Id";
      // 
      // lblUsuario
      // 
      lblUsuario.Anchor = AnchorStyles.None;
      lblUsuario.AutoSize = true;
      lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
      lblUsuario.Location = new Point(257, 26);
      lblUsuario.Name = "lblUsuario";
      lblUsuario.Size = new Size(79, 28);
      lblUsuario.TabIndex = 0;
      lblUsuario.Text = "Usuario";
      // 
      // lblTotal
      // 
      lblTotal.Anchor = AnchorStyles.None;
      lblTotal.AutoSize = true;
      lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
      lblTotal.Location = new Point(517, 26);
      lblTotal.Name = "lblTotal";
      lblTotal.Size = new Size(54, 28);
      lblTotal.TabIndex = 0;
      lblTotal.Text = "Total";
      // 
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.AutoSize = true;
      tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      tableLayoutPanel1.ColumnCount = 2;
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      tableLayoutPanel1.Controls.Add(btnAceptar, 0, 0);
      tableLayoutPanel1.Controls.Add(btnCancelar, 1, 0);
      tableLayoutPanel1.Dock = DockStyle.Fill;
      tableLayoutPanel1.Location = new Point(646, 3);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 1;
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      tableLayoutPanel1.Size = new Size(341, 74);
      tableLayoutPanel1.TabIndex = 1;
      // 
      // btnAceptar
      // 
      btnAceptar.Anchor = AnchorStyles.None;
      btnAceptar.AutoSize = true;
      btnAceptar.BackColor = Color.FromArgb(  0,   123,   255);
      btnAceptar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
      btnAceptar.ForeColor = SystemColors.ControlLightLight;
      btnAceptar.Location = new Point(29, 13);
      btnAceptar.Margin = new Padding(0);
      btnAceptar.Name = "btnAceptar";
      btnAceptar.Padding = new Padding(10, 5, 10, 5);
      btnAceptar.Size = new Size(111, 48);
      btnAceptar.TabIndex = 0;
      btnAceptar.Text = "Aceptar";
      btnAceptar.UseVisualStyleBackColor = false;
      btnAceptar.Click += btnAceptar_Click;
      // 
      // btnCancelar
      // 
      btnCancelar.Anchor = AnchorStyles.None;
      btnCancelar.AutoSize = true;
      btnCancelar.BackColor = Color.Red;
      btnCancelar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
      btnCancelar.ForeColor = SystemColors.ControlLightLight;
      btnCancelar.Location = new Point(196, 13);
      btnCancelar.Margin = new Padding(0);
      btnCancelar.Name = "btnCancelar";
      btnCancelar.Padding = new Padding(10, 5, 10, 5);
      btnCancelar.Size = new Size(118, 48);
      btnCancelar.TabIndex = 0;
      btnCancelar.Text = "Cancelar";
      btnCancelar.UseVisualStyleBackColor = false;
      btnCancelar.Click += btnCancelar_Click;
      // 
      // OrdenRenderControl
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(layoutOrden);
      MaximumSize = new Size(990, 80);
      MinimumSize = new Size(990, 80);
      Name = "OrdenRenderControl";
      Size = new Size(990, 80);
      layoutOrden.ResumeLayout(false);
      layoutOrden.PerformLayout();
      tableLayoutPanel1.ResumeLayout(false);
      tableLayoutPanel1.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    public System.Windows.Forms.TableLayoutPanel layoutOrden;
    public System.Windows.Forms.Label lblId;
    public System.Windows.Forms.Label lblUsuario;
    public System.Windows.Forms.Label lblTotal;
    public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    public System.Windows.Forms.Button btnAceptar;
    public System.Windows.Forms.Button btnCancelar;
  }
}
