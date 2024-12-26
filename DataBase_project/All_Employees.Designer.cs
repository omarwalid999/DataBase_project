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
            ((System.ComponentModel.ISupportInitialize)(this.allemployeesview)).BeginInit();
            this.SuspendLayout();
            // 
            // allemployeesview
            // 
            this.allemployeesview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allemployeesview.Location = new System.Drawing.Point(136, 58);
            this.allemployeesview.Name = "allemployeesview";
            this.allemployeesview.RowHeadersWidth = 51;
            this.allemployeesview.RowTemplate.Height = 24;
            this.allemployeesview.Size = new System.Drawing.Size(417, 182);
            this.allemployeesview.TabIndex = 0;
            // 
            // add_e
            // 
            this.add_e.Location = new System.Drawing.Point(136, 301);
            this.add_e.Name = "add_e";
            this.add_e.Size = new System.Drawing.Size(75, 23);
            this.add_e.TabIndex = 1;
            this.add_e.Text = "Add";
            this.add_e.UseVisualStyleBackColor = true;
            this.add_e.Click += new System.EventHandler(this.add_e_Click);
            // 
            // remove_e
            // 
            this.remove_e.Location = new System.Drawing.Point(386, 301);
            this.remove_e.Name = "remove_e";
            this.remove_e.Size = new System.Drawing.Size(75, 23);
            this.remove_e.TabIndex = 2;
            this.remove_e.Text = "Remove";
            this.remove_e.UseVisualStyleBackColor = true;
            this.remove_e.Click += new System.EventHandler(this.remove_e_Click);
            // 
            // All_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.remove_e);
            this.Controls.Add(this.add_e);
            this.Controls.Add(this.allemployeesview);
            this.Name = "All_Employees";
            this.Text = "All_Employees";
            this.Load += new System.EventHandler(this.All_Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allemployeesview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView allemployeesview;
        private System.Windows.Forms.Button add_e;
        private System.Windows.Forms.Button remove_e;
    }
}