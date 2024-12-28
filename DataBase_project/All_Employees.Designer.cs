namespace DataBase_project
{
    partial class All_Employees
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
            this.allemployeesview = new System.Windows.Forms.DataGridView();
            this.add_e = new System.Windows.Forms.Button();
            this.remove_e = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.allemployeesview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // allemployeesview
            // 
            this.allemployeesview.BackgroundColor = System.Drawing.Color.Honeydew;
            this.allemployeesview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allemployeesview.Location = new System.Drawing.Point(34, 152);
            this.allemployeesview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.allemployeesview.Name = "allemployeesview";
            this.allemployeesview.RowHeadersWidth = 51;
            this.allemployeesview.RowTemplate.Height = 24;
            this.allemployeesview.Size = new System.Drawing.Size(827, 290);
            this.allemployeesview.TabIndex = 0;
            this.allemployeesview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allemployeesview_CellContentClick);
            // 
            // add_e
            // 
            this.add_e.BackColor = System.Drawing.Color.Honeydew;
            this.add_e.Location = new System.Drawing.Point(34, 461);
            this.add_e.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_e.Name = "add_e";
            this.add_e.Size = new System.Drawing.Size(151, 71);
            this.add_e.TabIndex = 1;
            this.add_e.Text = "Add/Edit";
            this.add_e.UseVisualStyleBackColor = false;
            this.add_e.Click += new System.EventHandler(this.add_e_Click);
            // 
            // remove_e
            // 
            this.remove_e.BackColor = System.Drawing.Color.Honeydew;
            this.remove_e.Location = new System.Drawing.Point(717, 461);
            this.remove_e.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.remove_e.Name = "remove_e";
            this.remove_e.Size = new System.Drawing.Size(132, 71);
            this.remove_e.TabIndex = 2;
            this.remove_e.Text = "Remove";
            this.remove_e.UseVisualStyleBackColor = false;
            this.remove_e.Click += new System.EventHandler(this.remove_e_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DataBase_project.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(12, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // All_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.remove_e);
            this.Controls.Add(this.add_e);
            this.Controls.Add(this.allemployeesview);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "All_Employees";
            this.Text = "All_Employees";
            this.Load += new System.EventHandler(this.All_Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allemployeesview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView allemployeesview;
        private System.Windows.Forms.Button add_e;
        private System.Windows.Forms.Button remove_e;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}