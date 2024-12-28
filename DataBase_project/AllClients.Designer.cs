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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.addnewclient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.allclientsview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // allclientsview
            // 
            this.allclientsview.BackgroundColor = System.Drawing.Color.Honeydew;
            this.allclientsview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allclientsview.Location = new System.Drawing.Point(24, 136);
            this.allclientsview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.allclientsview.Name = "allclientsview";
            this.allclientsview.RowHeadersWidth = 51;
            this.allclientsview.RowTemplate.Height = 24;
            this.allclientsview.Size = new System.Drawing.Size(864, 335);
            this.allclientsview.TabIndex = 0;
            this.allclientsview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allclientsview_CellContentClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DataBase_project.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(12, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // addnewclient
            // 
            this.addnewclient.BackColor = System.Drawing.Color.Honeydew;
            this.addnewclient.Location = new System.Drawing.Point(333, 495);
            this.addnewclient.Name = "addnewclient";
            this.addnewclient.Size = new System.Drawing.Size(272, 55);
            this.addnewclient.TabIndex = 43;
            this.addnewclient.Text = "Want to add a new client?";
            this.addnewclient.UseVisualStyleBackColor = false;
            this.addnewclient.Click += new System.EventHandler(this.addnewclient_Click);
            // 
            // AllClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.addnewclient);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.allclientsview);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AllClients";
            this.Load += new System.EventHandler(this.AllClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allclientsview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView allclientsview;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button addnewclient;
    }
}