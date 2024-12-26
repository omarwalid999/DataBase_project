namespace DataBase_project
{
    partial class client_newevent
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
            this.typesofevents = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.beach = new System.Windows.Forms.PictureBox();
            this.hotelbox1 = new System.Windows.Forms.PictureBox();
            this.beachbox1 = new System.Windows.Forms.PictureBox();
            this.hotelbox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.beach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beachbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelbox3)).BeginInit();
            this.SuspendLayout();
            // 
            // typesofevents
            // 
            this.typesofevents.FormattingEnabled = true;
            this.typesofevents.Location = new System.Drawing.Point(207, 24);
            this.typesofevents.Name = "typesofevents";
            this.typesofevents.Size = new System.Drawing.Size(255, 28);
            this.typesofevents.TabIndex = 0;
            this.typesofevents.SelectedIndexChanged += new System.EventHandler(this.typesofevents_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "choose type of event";
            // 
            // beach
            // 
            this.beach.Location = new System.Drawing.Point(107, 236);
            this.beach.Name = "beach";
            this.beach.Size = new System.Drawing.Size(275, 183);
            this.beach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.beach.TabIndex = 5;
            this.beach.TabStop = false;
            // 
            // hotelbox1
            // 
            this.hotelbox1.Location = new System.Drawing.Point(526, 236);
            this.hotelbox1.Name = "hotelbox1";
            this.hotelbox1.Size = new System.Drawing.Size(278, 179);
            this.hotelbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.hotelbox1.TabIndex = 4;
            this.hotelbox1.TabStop = false;
            // 
            // beachbox1
            // 
            this.beachbox1.Location = new System.Drawing.Point(107, 236);
            this.beachbox1.Name = "beachbox1";
            this.beachbox1.Size = new System.Drawing.Size(275, 183);
            this.beachbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.beachbox1.TabIndex = 5;
            this.beachbox1.TabStop = false;
            // 
            // hotelbox3
            // 
            this.hotelbox3.Location = new System.Drawing.Point(526, 236);
            this.hotelbox3.Name = "hotelbox3";
            this.hotelbox3.Size = new System.Drawing.Size(278, 179);
            this.hotelbox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.hotelbox3.TabIndex = 4;
            this.hotelbox3.TabStop = false;
            // 
            // client_newevent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 508);
            this.Controls.Add(this.beach);
            this.Controls.Add(this.hotelbox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typesofevents);
            this.Name = "client_newevent";
            this.Text = "client_newevent";
            this.Load += new System.EventHandler(this.client_newevent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.beach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beachbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelbox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typesofevents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox hotelbox1;
        private System.Windows.Forms.PictureBox beach;
        private System.Windows.Forms.PictureBox beachbox1;
        private System.Windows.Forms.PictureBox hotelbox3;
    }
}