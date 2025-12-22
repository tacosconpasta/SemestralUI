namespace SemestralUI.View.Forms.Categorias {
  partial class ListarCategoriasForm {
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
      lblCategoriasTitulo = new Label();
      categoriasListContainer = new FlowLayoutPanel();
      panelTop = new Panel();
      btnAgregarCategorias = new Button();
      mainContainer = new Panel();
      panelTop.SuspendLayout();
      mainContainer.SuspendLayout();
      SuspendLayout();
      // 
      // lblCategoriasTitulo
      // 
      lblCategoriasTitulo.AutoSize = true;
      lblCategoriasTitulo.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
      lblCategoriasTitulo.Location = new Point(0, 0);
      lblCategoriasTitulo.Name = "lblCategoriasTitulo";
      lblCategoriasTitulo.Size = new Size(184, 46);
      lblCategoriasTitulo.TabIndex = 0;
      lblCategoriasTitulo.Text = "Categorías";
      // 
      // categoriasListContainer
      // 
      categoriasListContainer.AutoScroll = true;
      categoriasListContainer.AutoSize = true;
      categoriasListContainer.Dock = DockStyle.Fill;
      categoriasListContainer.FlowDirection = FlowDirection.TopDown;
      categoriasListContainer.Location = new Point(40, 88);
      categoriasListContainer.Margin = new Padding(0);
      categoriasListContainer.Name = "categoriasListContainer";
      categoriasListContainer.Size = new Size(1022, 545);
      categoriasListContainer.TabIndex = 2;
      categoriasListContainer.WrapContents = false;
      // 
      // panelTop
      // 
      panelTop.AutoSize = true;
      panelTop.Controls.Add(btnAgregarCategorias);
      panelTop.Controls.Add(lblCategoriasTitulo);
      panelTop.Dock = DockStyle.Top;
      panelTop.Location = new Point(40, 40);
      panelTop.Margin = new Padding(0, 0, 0, 10);
      panelTop.Name = "panelTop";
      panelTop.Size = new Size(1022, 48);
      panelTop.TabIndex = 1;
      // 
      // btnAgregarCategorias
      // 
      btnAgregarCategorias.AutoSize = true;
      btnAgregarCategorias.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      btnAgregarCategorias.BackColor = Color.FromArgb(  96,   166,   19);
      btnAgregarCategorias.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
      btnAgregarCategorias.ForeColor = SystemColors.ControlLightLight;
      btnAgregarCategorias.Location = new Point(807, 0);
      btnAgregarCategorias.Margin = new Padding(0);
      btnAgregarCategorias.Name = "btnAgregarCategorias";
      btnAgregarCategorias.Padding = new Padding(10, 5, 10, 5);
      btnAgregarCategorias.Size = new Size(215, 48);
      btnAgregarCategorias.TabIndex = 1;
      btnAgregarCategorias.Text = "Agregar Categorías";
      btnAgregarCategorias.UseVisualStyleBackColor = false;
      btnAgregarCategorias.Click += btnAgregarCategorias_Click;
      // 
      // mainContainer
      // 
      mainContainer.AutoSize = true;
      mainContainer.Controls.Add(categoriasListContainer);
      mainContainer.Controls.Add(panelTop);
      mainContainer.Dock = DockStyle.Fill;
      mainContainer.Location = new Point(0, 0);
      mainContainer.Name = "mainContainer";
      mainContainer.Padding = new Padding(40, 40, 20, 40);
      mainContainer.Size = new Size(1082, 673);
      mainContainer.TabIndex = 2;
      // 
      // ListarCategoriasForm
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = SystemColors.ControlLightLight;
      ClientSize = new Size(1082, 673);
      Controls.Add(mainContainer);
      Name = "ListarCategoriasForm";
      Text = "ListarCategoriasForm";
      panelTop.ResumeLayout(false);
      panelTop.PerformLayout();
      mainContainer.ResumeLayout(false);
      mainContainer.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label lblCategoriasTitulo;
    private FlowLayoutPanel categoriasListContainer;
    private Panel panelTop;
    private Button btnAgregarCategorias;
    private Panel mainContainer;
  }
}