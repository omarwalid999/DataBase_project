namespace DataBase_project
{
    partial class Statistics
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
            this.AgeGroups = new System.Windows.Forms.DataGridView();
            this.dg2 = new System.Windows.Forms.DataGridView();
            this.maxcap = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.max_cap_tb = new System.Windows.Forms.TextBox();
            this.maxprice_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AgeGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).BeginInit();
            this.SuspendLayout();
            // 
            // AgeGroups
            // 
            this.AgeGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AgeGroups.Location = new System.Drawing.Point(40, 42);
            this.AgeGroups.Name = "AgeGroups";
            this.AgeGroups.RowHeadersWidth = 62;
            this.AgeGroups.RowTemplate.Height = 28;
            this.AgeGroups.Size = new System.Drawing.Size(332, 291);
            this.AgeGroups.TabIndex = 0;
            this.AgeGroups.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AgeGroups_CellContentClick);
            // 
            // dg2
            // 
            this.dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg2.Location = new System.Drawing.Point(413, 42);
            this.dg2.Name = "dg2";
            this.dg2.RowHeadersWidth = 62;
            this.dg2.RowTemplate.Height = 28;
            this.dg2.Size = new System.Drawing.Size(412, 280);
            this.dg2.TabIndex = 1;
            // 
            // maxcap
            // 
            this.maxcap.AutoSize = true;
            this.maxcap.Location = new System.Drawing.Point(61, 367);
            this.maxcap.Name = "maxcap";
            this.maxcap.Size = new System.Drawing.Size(154, 20);
            this.maxcap.TabIndex = 2;
            this.maxcap.Text = "Max Venue Capacity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Maximum venue price";
            // 
            // max_cap_tb
            // 
            this.max_cap_tb.Location = new System.Drawing.Point(249, 367);
            this.max_cap_tb.Name = "max_cap_tb";
            this.max_cap_tb.Size = new System.Drawing.Size(163, 26);
            this.max_cap_tb.TabIndex = 4;
            this.max_cap_tb.TextChanged += new System.EventHandler(this.max_cap_tb_TextChanged);
            // 
            // maxprice_tb
            // 
            this.maxprice_tb.Location = new System.Drawing.Point(249, 401);
            this.maxprice_tb.Name = "maxprice_tb";
            this.maxprice_tb.Size = new System.Drawing.Size(162, 26);
            this.maxprice_tb.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number of emplloyees in each age group";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Venues sorted by capacity";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 510);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maxprice_tb);
            this.Controls.Add(this.max_cap_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxcap);
            this.Controls.Add(this.AgeGroups);
            this.Controls.Add(this.dg2);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AgeGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AgeGroups;
        private System.Windows.Forms.DataGridView dg2;
        private System.Windows.Forms.Label maxcap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox max_cap_tb;
        private System.Windows.Forms.TextBox maxprice_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}