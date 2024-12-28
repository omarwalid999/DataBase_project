namespace DataBase_project
{
    partial class message_manager
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
            this.username_combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.employees = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.send_button = new System.Windows.Forms.Button();
            this.message_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.employees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // username_combobox
            // 
            this.username_combobox.BackColor = System.Drawing.Color.Honeydew;
            this.username_combobox.FormattingEnabled = true;
            this.username_combobox.Location = new System.Drawing.Point(190, 115);
            this.username_combobox.Name = "username_combobox";
            this.username_combobox.Size = new System.Drawing.Size(286, 24);
            this.username_combobox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(836, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Employees";
            // 
            // employees
            // 
            this.employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employees.Location = new System.Drawing.Point(663, 154);
            this.employees.Name = "employees";
            this.employees.RowHeadersWidth = 51;
            this.employees.RowTemplate.Height = 24;
            this.employees.Size = new System.Drawing.Size(397, 320);
            this.employees.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-113, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "To:";
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(470, 510);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(163, 50);
            this.send_button.TabIndex = 22;
            this.send_button.Text = "Send";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // message_text
            // 
            this.message_text.BackColor = System.Drawing.Color.Honeydew;
            this.message_text.Location = new System.Drawing.Point(24, 154);
            this.message_text.Multiline = true;
            this.message_text.Name = "message_text";
            this.message_text.Size = new System.Drawing.Size(609, 320);
            this.message_text.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "TO:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DataBase_project.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // message_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 611);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.username_combobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employees);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.message_text);
            this.Name = "message_manager";
            this.Text = "message_manager";
            this.Load += new System.EventHandler(this.message_manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox username_combobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView employees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.TextBox message_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}