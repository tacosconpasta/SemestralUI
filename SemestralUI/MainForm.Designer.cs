using System;

namespace Parcial2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      renderPanel = new Panel();
      navbarPanel = new SemestralUI.View.Controls.NavbarControl();
      SuspendLayout();
      // 
      // renderPanel
      // 
      renderPanel.Dock = DockStyle.Fill;
      renderPanel.Location = new Point(0, 70);
      renderPanel.Margin = new Padding(2);
      renderPanel.Name = "renderPanel";
      renderPanel.Size = new Size(1082, 603);
      renderPanel.TabIndex = 0;
      // 
      // navbarPanel
      // 
      navbarPanel.AutoSize = true;
      navbarPanel.BackColor = SystemColors.ControlLightLight;
      navbarPanel.Dock = DockStyle.Top;
      navbarPanel.Location = new Point(0, 0);
      navbarPanel.Margin = new Padding(0);
      navbarPanel.Name = "navbarPanel";
      navbarPanel.SelectedIndex = -1;
      navbarPanel.Size = new Size(1082, 70);
      navbarPanel.TabIndex = 1;
      navbarPanel.Visible = false;
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = SystemColors.ControlLightLight;
      ClientSize = new Size(1082, 673);
      Controls.Add(renderPanel);
      Controls.Add(navbarPanel);
      Margin = new Padding(2);
      Name = "MainForm";
      Text = "SysTransac";
      Load += MainForm_Load;
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Panel renderPanel;
    private SemestralUI.View.Controls.NavbarControl navbarPanel;
  }
}
