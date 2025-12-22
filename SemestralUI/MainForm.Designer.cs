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
      SuspendLayout();
      // 
      // renderPanel
      // 
      renderPanel.Dock = DockStyle.Fill;
      renderPanel.Location = new Point(0, 0);
      renderPanel.Margin = new Padding(2, 2, 2, 2);
      renderPanel.Name = "renderPanel";
      renderPanel.Size = new Size(1082, 673);
      renderPanel.TabIndex = 0;
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = SystemColors.ControlLightLight;
      ClientSize = new Size(1082, 673);
      Controls.Add(renderPanel);
      Margin = new Padding(2, 2, 2, 2);
      Name = "MainForm";
      Text = "SysTransac";
      Load += MainForm_Load;
      ResumeLayout(false);
    }

    #endregion

    private Panel renderPanel;
  }
}
