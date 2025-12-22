namespace SemestralUI.View.Forms.Ordenes {
  partial class ListarOrdenesForm {
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
      ordenesListContainer = new FlowLayoutPanel();
      panelTop = new Panel();
      lblOrdenesTitulo = new Label();
      mainContainer = new Panel();
      panelTop.SuspendLayout();
      mainContainer.SuspendLayout();
      SuspendLayout();
      // 
      // ordenesListContainer
      // 
      ordenesListContainer.AutoScroll = true;
      ordenesListContainer.AutoSize = true;
      ordenesListContainer.Dock = DockStyle.Fill;
      ordenesListContainer.FlowDirection = FlowDirection.TopDown;
      ordenesListContainer.Location = new Point(40, 86);
      ordenesListContainer.Margin = new Padding(0);
      ordenesListContainer.Name = "ordenesListContainer";
      ordenesListContainer.Size = new Size(1022, 547);
      ordenesListContainer.TabIndex = 2;
      ordenesListContainer.WrapContents = false;
      // 
      // panelTop
      // 
      panelTop.AutoSize = true;
      panelTop.Controls.Add(lblOrdenesTitulo);
      panelTop.Dock = DockStyle.Top;
      panelTop.Location = new Point(40, 40);
      panelTop.Margin = new Padding(0, 0, 0, 10);
      panelTop.Name = "panelTop";
      panelTop.Size = new Size(1022, 46);
      panelTop.TabIndex = 1;
      // 
      // lblOrdenesTitulo
      // 
      lblOrdenesTitulo.AutoSize = true;
      lblOrdenesTitulo.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
      lblOrdenesTitulo.Location = new Point(0, 0);
      lblOrdenesTitulo.Name = "lblOrdenesTitulo";
      lblOrdenesTitulo.Size = new Size(150, 46);
      lblOrdenesTitulo.TabIndex = 0;
      lblOrdenesTitulo.Text = "Ordenes";
      // 
      // mainContainer
      // 
      mainContainer.AutoSize = true;
      mainContainer.Controls.Add(ordenesListContainer);
      mainContainer.Controls.Add(panelTop);
      mainContainer.Dock = DockStyle.Fill;
      mainContainer.Location = new Point(0, 0);
      mainContainer.Name = "mainContainer";
      mainContainer.Padding = new Padding(40, 40, 20, 40);
      mainContainer.Size = new Size(1082, 673);
      mainContainer.TabIndex = 3;
      // 
      // ListarOrdenes
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = SystemColors.ControlLightLight;
      ClientSize = new Size(1082, 673);
      Controls.Add(mainContainer);
      Name = "ListarOrdenes";
      Text = "ListarOrdenes";
      panelTop.ResumeLayout(false);
      panelTop.PerformLayout();
      mainContainer.ResumeLayout(false);
      mainContainer.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private FlowLayoutPanel ordenesListContainer;
    private Panel panelTop;
    private Label lblOrdenesTitulo;
    private Panel mainContainer;
  }
}