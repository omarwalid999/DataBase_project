namespace DataBase_project
{
    partial class employee_login
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
            this.change_password_button = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // change_password_button
            // 
            this.change_password_button.AutoSize = true;
            this.change_password_button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.change_password_button.ForeColor = System.Drawing.Color.Red;
            this.change_password_button.Location = new System.Drawing.Point(342, 246);
            this.change_password_button.Name = "change_password_button";
            this.change_password_button.Size = new System.Drawing.Size(125, 18);
            this.change_password_button.TabIndex = 12;
            this.change_password_button.Text = "Change password?";
            this.change_password_button.Click += new System.EventHandler(this.change_password_button_Click);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(342, 280);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(144, 46);
            this.login_button.TabIndex = 11;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "username";
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(296, 212);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(212, 22);
            this.password_textbox.TabIndex = 8;
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(296, 165);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(212, 22);
            this.username_textbox.TabIndex = 13;
            // 
            // employee_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.change_password_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_textbox);
            this.Name = "employee_login";
            this.Text = "employee_login";
            this.Load += new System.EventHandler(this.employee_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label change_password_button;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox username_textbox;
    }
}