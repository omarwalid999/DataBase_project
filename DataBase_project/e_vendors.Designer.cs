﻿namespace DataBase_project
{
    partial class e_vendors
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
            this.vendorsdataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vendorsdataGridView
            // 
            this.vendorsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendorsdataGridView.Location = new System.Drawing.Point(45, 74);
            this.vendorsdataGridView.Name = "vendorsdataGridView";
            this.vendorsdataGridView.RowHeadersWidth = 62;
            this.vendorsdataGridView.RowTemplate.Height = 28;
            this.vendorsdataGridView.Size = new System.Drawing.Size(603, 286);
            this.vendorsdataGridView.TabIndex = 0;
            this.vendorsdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vendorsdataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lis of all vendors:";
            // 
            // e_vendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vendorsdataGridView);
            this.Name = "e_vendors";
            this.Text = "e_vendors";
            ((System.ComponentModel.ISupportInitialize)(this.vendorsdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView vendorsdataGridView;
        private System.Windows.Forms.Label label1;
    }
}