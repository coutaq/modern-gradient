﻿using System.Drawing;
using System.Windows.Forms;

namespace Coutaq
{
    partial class ModernGradient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
       
        /// <summary>
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {

            this.SuspendLayout();
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ModernGradient1";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.ModernGradient_Load);
            this.Resize += new System.EventHandler(this.ModernGradient_Resize);
            this.ResumeLayout(false);

        }
       

        #endregion
    }
}
