namespace SemestralUI.View.Forms {
  partial class MenuInicioForm {
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
      navbarControl1 = new SemestralUI.View.Controls.NavbarControl();
      mainContainer = new Panel();
      articulosListContainer = new FlowLayoutPanel();
      panelTop = new Panel();
      btnAgregarArticulos = new Button();
      lblArticulosTitulo = new Label();
      mainContainer.SuspendLayout();
      panelTop.SuspendLayout();
      SuspendLayout();
      // 
      // navbarControl1
      // 
      navbarControl1.AutoSize = true;
      navbarControl1.BackColor = SystemColors.ControlLightLight;
      navbarControl1.Dock = DockStyle.Top;
      navbarControl1.Location = new Point(0, 0);
      navbarControl1.Margin = new Padding(0);
      navbarControl1.Name = "navbarControl1";
      navbarControl1.SelectedIndex = -1;
      navbarControl1.Size = new Size(1082, 70);
      navbarControl1.TabIndex = 0;
      // 
      // mainContainer
      // 
      mainContainer.AutoSize = true;
      mainContainer.Controls.Add(articulosListContainer);
      mainContainer.Controls.Add(panelTop);
      mainContainer.Dock = DockStyle.Fill;
      mainContainer.Location = new Point(0, 70);
      mainContainer.Name = "mainContainer";
      mainContainer.Padding = new Padding(40, 40, 20, 40);
      mainContainer.Size = new Size(1082, 603);
      mainContainer.TabIndex = 1;
      // 
      // articulosListContainer
      // 
      articulosListContainer.AutoScroll = true;
      articulosListContainer.AutoSize = true;
      articulosListContainer.Dock = DockStyle.Fill;
      articulosListContainer.FlowDirection = FlowDirection.TopDown;
      articulosListContainer.Location = new Point(40, 88);
      articulosListContainer.Margin = new Padding(0);
      articulosListContainer.Name = "articulosListContainer";
      articulosListContainer.Size = new Size(1022, 475);
      articulosListContainer.TabIndex = 2;
      articulosListContainer.WrapContents = false;
      // 
      // panelTop
      // 
      panelTop.AutoSize = true;
      panelTop.Controls.Add(btnAgregarArticulos);
      panelTop.Controls.Add(lblArticulosTitulo);
      panelTop.Dock = DockStyle.Top;
      panelTop.Location = new Point(40, 40);
      panelTop.Margin = new Padding(0, 0, 0, 10);
      panelTop.Name = "panelTop";
      panelTop.Size = new Size(1022, 48);
      panelTop.TabIndex = 1;
      // 
      // btnAgregarArticulos
      // 
      btnAgregarArticulos.AutoSize = true;
      btnAgregarArticulos.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      btnAgregarArticulos.BackColor = Color.FromArgb(  96,   166,   19);
      btnAgregarArticulos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      btnAgregarArticulos.ForeColor = SystemColors.ControlLightLight;
      btnAgregarArticulos.Location = new Point(822, 0);
      btnAgregarArticulos.Margin = new Padding(0);
      btnAgregarArticulos.Name = "btnAgregarArticulos";
      btnAgregarArticulos.Padding = new Padding(10, 5, 10, 5);
      btnAgregarArticulos.Size = new Size(200, 48);
      btnAgregarArticulos.TabIndex = 1;
      btnAgregarArticulos.Text = "Agregar Artículos";
      btnAgregarArticulos.UseVisualStyleBackColor = false;
      // 
      // lblArticulosTitulo
      // 
      lblArticulosTitulo.AutoSize = true;
      lblArticulosTitulo.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
      lblArticulosTitulo.Location = new Point(0, 0);
      lblArticulosTitulo.Name = "lblArticulosTitulo";
      lblArticulosTitulo.Size = new Size(158, 46);
      lblArticulosTitulo.TabIndex = 0;
      lblArticulosTitulo.Text = "Artículos";
      // 
      // MenuInicioForm
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = SystemColors.ControlLightLight;
      ClientSize = new Size(1082, 673);
      Controls.Add(mainContainer);
      Controls.Add(navbarControl1);
      Margin = new Padding(2);
      Name = "MenuInicioForm";
      Text = "MenuInicioSesionForm";
      mainContainer.ResumeLayout(false);
      mainContainer.PerformLayout();
      panelTop.ResumeLayout(false);
      panelTop.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Controls.NavbarControl navbarControl1;
    private Panel mainContainer;
    private Label lblArticulosTitulo;
    private Panel panelTop;
    private Button btnAgregarArticulos;
    private FlowLayoutPanel articulosListContainer;
  }
}