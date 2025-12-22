namespace SemestralUI.View.Controls.Components {
  partial class FacturaRenderControl {
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    private void InitializeComponent() {
      layoutFactura = new System.Windows.Forms.TableLayoutPanel();
      lblId = new System.Windows.Forms.Label();
      lblUsuario = new System.Windows.Forms.Label();
      lblFecha = new System.Windows.Forms.Label();
      lblSubtotal = new System.Windows.Forms.Label();
      lblItbms = new System.Windows.Forms.Label();
      lblTotal = new System.Windows.Forms.Label();

      layoutFactura.SuspendLayout();
      SuspendLayout();

      // layoutFactura
      layoutFactura.AutoSize = true;
      layoutFactura.ColumnCount = 6;
      layoutFactura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F)); // Id
      layoutFactura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F)); // Usuario
      layoutFactura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F)); // Fecha
      layoutFactura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F)); // Subtotal
      layoutFactura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F)); // ITBMS
      layoutFactura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F)); // Total

      layoutFactura.Controls.Add(lblId, 0, 0);
      layoutFactura.Controls.Add(lblUsuario, 1, 0);
      layoutFactura.Controls.Add(lblFecha, 2, 0);
      layoutFactura.Controls.Add(lblSubtotal, 3, 0);
      layoutFactura.Controls.Add(lblItbms, 4, 0);
      layoutFactura.Controls.Add(lblTotal, 5, 0);
      layoutFactura.Dock = System.Windows.Forms.DockStyle.Fill;
      layoutFactura.Location = new System.Drawing.Point(0, 0);
      layoutFactura.Name = "layoutFactura";
      layoutFactura.RowCount = 1;
      layoutFactura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      layoutFactura.Size = new System.Drawing.Size(990, 80);
      layoutFactura.TabIndex = 0;

      // lblId
      lblId.Anchor = System.Windows.Forms.AnchorStyles.None;
      lblId.AutoSize = true;
      lblId.Font = new System.Drawing.Font("Segoe UI", 12F);
      lblId.Text = "Id";

      // lblUsuario
      lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
      lblUsuario.AutoSize = true;
      lblUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
      lblUsuario.Text = "Usuario";

      // lblFecha
      lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
      lblFecha.AutoSize = true;
      lblFecha.Font = new System.Drawing.Font("Segoe UI", 12F);
      lblFecha.Text = "Fecha";

      // lblSubtotal
      lblSubtotal.Anchor = System.Windows.Forms.AnchorStyles.None;
      lblSubtotal.AutoSize = true;
      lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 12F);
      lblSubtotal.Text = "Subtotal";

      // lblItbms
      lblItbms.Anchor = System.Windows.Forms.AnchorStyles.None;
      lblItbms.AutoSize = true;
      lblItbms.Font = new System.Drawing.Font("Segoe UI", 12F);
      lblItbms.Text = "ITBMS";

      // lblTotal
      lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
      lblTotal.AutoSize = true;
      lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F);
      lblTotal.Text = "Total";

      // FacturaRenderControl
      AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      Controls.Add(layoutFactura);
      MaximumSize = new System.Drawing.Size(990, 80);
      MinimumSize = new System.Drawing.Size(990, 80);
      Name = "FacturaRenderControl";
      Size = new System.Drawing.Size(990, 80);

      layoutFactura.ResumeLayout(false);
      layoutFactura.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    public System.Windows.Forms.TableLayoutPanel layoutFactura;
    public System.Windows.Forms.Label lblId;
    public System.Windows.Forms.Label lblUsuario;
    public System.Windows.Forms.Label lblFecha;
    public System.Windows.Forms.Label lblSubtotal;
    public System.Windows.Forms.Label lblItbms;
    public System.Windows.Forms.Label lblTotal;
  }
}
