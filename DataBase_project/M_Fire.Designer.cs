namespace DataBase_project
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Employee";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // firecombo
            // 
            this.firecombo.BackColor = System.Drawing.Color.Honeydew;
            this.firecombo.FormattingEnabled = true;
            this.firecombo.Location = new System.Drawing.Point(342, 145);
            this.firecombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firecombo.Name = "firecombo";
            this.firecombo.Size = new System.Drawing.Size(136, 28);
            this.firecombo.TabIndex = 1;
            this.firecombo.SelectedIndexChanged += new System.EventHandler(this.firecombo_SelectedIndexChanged);
            // 
            // fire
            // 
            this.fire.BackColor = System.Drawing.Color.Honeydew;
            this.fire.Location = new System.Drawing.Point(536, 136);
            this.fire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fire.Name = "fire";
            this.fire.Size = new System.Drawing.Size(111, 45);
            this.fire.TabIndex = 2;
            this.fire.Text = "Fire";
            this.fire.UseVisualStyleBackColor = false;
            this.fire.Click += new System.EventHandler(this.fire_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DataBase_project.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(12, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // M_Fire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.fire);
            this.Controls.Add(this.firecombo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "M_Fire";
            this.Text = "M_Fire";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox firecombo;
        private System.Windows.Forms.Button fire;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}