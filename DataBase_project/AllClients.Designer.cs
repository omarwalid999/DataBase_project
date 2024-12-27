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
            this.editclient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clientcombo = new System.Windows.Forms.ComboBox();
            this.addclient = new System.Windows.Forms.Button();
            this.deleteclient = new System.Windows.Forms.Button();
            this.back11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.allclientsview)).BeginInit();
            this.SuspendLayout();
            // 
            // allclientsview
            // 
            this.allclientsview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allclientsview.Location = new System.Drawing.Point(127, 39);
            this.allclientsview.Name = "allclientsview";
            this.allclientsview.RowHeadersWidth = 51;
            this.allclientsview.RowTemplate.Height = 24;
            this.allclientsview.Size = new System.Drawing.Size(456, 206);
            this.allclientsview.TabIndex = 0;
            // 
            // editclient
            // 
            this.editclient.Location = new System.Drawing.Point(448, 313);
            this.editclient.Name = "editclient";
            this.editclient.Size = new System.Drawing.Size(75, 23);
            this.editclient.TabIndex = 1;
            this.editclient.Text = "Edit";
            this.editclient.UseVisualStyleBackColor = true;
            this.editclient.Click += new System.EventHandler(this.editclient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Client";
            // 
            // clientcombo
            // 
            this.clientcombo.FormattingEnabled = true;
            this.clientcombo.Location = new System.Drawing.Point(252, 312);
            this.clientcombo.Name = "clientcombo";
            this.clientcombo.Size = new System.Drawing.Size(121, 24);
            this.clientcombo.TabIndex = 3;
            this.clientcombo.SelectedIndexChanged += new System.EventHandler(this.clientcombo_SelectedIndexChanged);
            // 
            // addclient
            // 
            this.addclient.Location = new System.Drawing.Point(111, 369);
            this.addclient.Name = "addclient";
            this.addclient.Size = new System.Drawing.Size(75, 23);
            this.addclient.TabIndex = 4;
            this.addclient.Text = "button1";
            this.addclient.UseVisualStyleBackColor = true;
            // 
            // deleteclient
            // 
            this.deleteclient.Location = new System.Drawing.Point(565, 313);
            this.deleteclient.Name = "deleteclient";
            this.deleteclient.Size = new System.Drawing.Size(75, 23);
            this.deleteclient.TabIndex = 5;
            this.deleteclient.Text = "DELETE";
            this.deleteclient.UseVisualStyleBackColor = true;
            // 
            // back11
            // 
            this.back11.Location = new System.Drawing.Point(659, 386);
            this.back11.Name = "back11";
            this.back11.Size = new System.Drawing.Size(75, 23);
            this.back11.TabIndex = 6;
            this.back11.Text = "Back";
            this.back11.UseVisualStyleBackColor = true;
            // 
            // AllClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back11);
            this.Controls.Add(this.deleteclient);
            this.Controls.Add(this.addclient);
            this.Controls.Add(this.clientcombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editclient);
            this.Controls.Add(this.allclientsview);
            this.Name = "AllClients";
            this.Text = "AllClients";
            this.Load += new System.EventHandler(this.AllClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allclientsview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView allclientsview;
        private System.Windows.Forms.Button editclient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox clientcombo;
        private System.Windows.Forms.Button addclient;
        private System.Windows.Forms.Button deleteclient;
        private System.Windows.Forms.Button back11;
    }
}