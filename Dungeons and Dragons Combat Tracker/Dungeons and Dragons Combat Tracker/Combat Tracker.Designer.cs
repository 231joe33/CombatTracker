﻿namespace Dungeons_and_Dragons_Combat_Tracker
{
    partial class Combat_Tracker
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.initiativeTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // initiativeTimer
            // 
            this.initiativeTimer.Tick += new System.EventHandler(this.initiativeTimer_Tick);
            // 
            // Combat_Tracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 420);
            this.Name = "Combat_Tracker";
            this.Text = "Combat_Tracker";
            this.Load += new System.EventHandler(this.Combat_Tracker_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer initiativeTimer;
    }
}