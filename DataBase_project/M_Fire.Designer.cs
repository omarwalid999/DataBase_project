﻿namespace DataBase_project
{
    partial class M_Fire
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
            this.label1 = new System.Windows.Forms.Label();
            this.firecombo = new System.Windows.Forms.ComboBox();
            this.fire = new System.Windows.Forms.Button();
            this.back3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Employee";
            // 
            // firecombo
            // 
            this.firecombo.FormattingEnabled = true;
            this.firecombo.Location = new System.Drawing.Point(259, 112);
            this.firecombo.Name = "firecombo";
            this.firecombo.Size = new System.Drawing.Size(121, 24);
            this.firecombo.TabIndex = 1;
            this.firecombo.SelectedIndexChanged += new System.EventHandler(this.firecombo_SelectedIndexChanged);
            // 
            // fire
            // 
            this.fire.Location = new System.Drawing.Point(321, 189);
            this.fire.Name = "fire";
            this.fire.Size = new System.Drawing.Size(75, 23);
            this.fire.TabIndex = 2;
            this.fire.Text = "Fire";
            this.fire.UseVisualStyleBackColor = true;
            this.fire.Click += new System.EventHandler(this.fire_Click);
            // 
            // back3
            // 
            this.back3.Location = new System.Drawing.Point(590, 349);
            this.back3.Name = "back3";
            this.back3.Size = new System.Drawing.Size(75, 23);
            this.back3.TabIndex = 3;
            this.back3.Text = "Back";
            this.back3.UseVisualStyleBackColor = true;
            this.back3.Click += new System.EventHandler(this.back3_Click);
            // 
            // M_Fire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back3);
            this.Controls.Add(this.fire);
            this.Controls.Add(this.firecombo);
            this.Controls.Add(this.label1);
            this.Name = "M_Fire";
            this.Text = "M_Fire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox firecombo;
        private System.Windows.Forms.Button fire;
        private System.Windows.Forms.Button back3;
    }
}