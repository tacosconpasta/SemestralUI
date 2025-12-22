namespace SemestralUI.View.Forms.Facturas {
  partial class ListarFacturasForm {
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
      lblFacturasTitulo = new Label();
      facturasListContainer = new FlowLayoutPanel();
      panelTop = new Panel();
      mainContainer = new Panel();
      panelTop.SuspendLayout();
      mainContainer.SuspendLayout();
      SuspendLayout();
      // 
      // lblFacturasTitulo
      // 
      lblFacturasTitulo.AutoSize = true;
      lblFacturasTitulo.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
      lblFacturasTitulo.Location = new Point(0, 0);
      lblFacturasTitulo.Name = "lblFacturasTitulo";
      lblFacturasTitulo.Size = new Size(148, 46);
      lblFacturasTitulo.TabIndex = 0;
      lblFacturasTitulo.Text = "Facturas";
      // 
      // facturasListContainer
      // 
      facturasListContainer.AutoScroll = true;
      facturasListContainer.AutoSize = true;
      facturasListContainer.Dock = DockStyle.Fill;
      facturasListContainer.FlowDirection = FlowDirection.TopDown;
      facturasListContainer.Location = new Point(40, 86);
      facturasListContainer.Margin = new Padding(0);
      facturasListContainer.Name = "facturasListContainer";
      facturasListContainer.Size = new Size(1022, 547);
      facturasListContainer.TabIndex = 2;
      facturasListContainer.WrapContents = false;
      // 
      // panelTop
      // 
      panelTop.AutoSize = true;
      panelTop.Controls.Add(lblFacturasTitulo);
      panelTop.Dock = DockStyle.Top;
      panelTop.Location = new Point(40, 40);
      panelTop.Margin = new Padding(0, 0, 0, 10);
      panelTop.Name = "panelTop";
      panelTop.Size = new Size(1022, 46);
      panelTop.TabIndex = 1;
      // 
      // mainContainer
      // 
      mainContainer.AutoSize = true;
      mainContainer.Controls.Add(facturasListContainer);
      mainContainer.Controls.Add(panelTop);
      mainContainer.Dock = DockStyle.Fill;
      mainContainer.Location = new Point(0, 0);
      mainContainer.Name = "mainContainer";
      mainContainer.Padding = new Padding(40, 40, 20, 40);
      mainContainer.Size = new Size(1082, 673);
      mainContainer.TabIndex = 4;
      // 
      // ListarFacturasForm
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = SystemColors.ControlLightLight;
      ClientSize = new Size(1082, 673);
      Controls.Add(mainContainer);
      Name = "ListarFacturasForm";
      Text = "Facturas";
      panelTop.ResumeLayout(false);
      panelTop.PerformLayout();
      mainContainer.ResumeLayout(false);
      mainContainer.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label lblFacturasTitulo;
    private FlowLayoutPanel facturasListContainer;
    private Panel panelTop;
    private Panel mainContainer;
  }
}