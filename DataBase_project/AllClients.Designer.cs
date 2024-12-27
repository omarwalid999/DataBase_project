namespace DataBase_project
{
    partial class AllClients
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
            this.allclientsview = new System.Windows.Forms.DataGridView();
            this.back12 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.allclientsview)).BeginInit();
            this.SuspendLayout();
            // 
            // allclientsview
            // 
            this.allclientsview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allclientsview.Location = new System.Drawing.Point(61, 39);
            this.allclientsview.Name = "allclientsview";
            this.allclientsview.RowHeadersWidth = 51;
            this.allclientsview.RowTemplate.Height = 24;
            this.allclientsview.Size = new System.Drawing.Size(629, 313);
            this.allclientsview.TabIndex = 0;
            this.allclientsview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allclientsview_CellContentClick);
            // 
            // back12
            // 
            this.back12.Location = new System.Drawing.Point(653, 379);
            this.back12.Name = "back12";
            this.back12.Size = new System.Drawing.Size(75, 23);
            this.back12.TabIndex = 1;
            this.back12.Text = "Back";
            this.back12.UseVisualStyleBackColor = true;
            this.back12.Click += new System.EventHandler(this.back12_Click);
            // 
            // AllClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back12);
            this.Controls.Add(this.allclientsview);
            this.Name = "AllClients";
            this.Text = "AllClients";
            this.Load += new System.EventHandler(this.AllClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allclientsview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView allclientsview;
        private System.Windows.Forms.Button back12;
    }
}