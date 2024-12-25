namespace DataBase_project
{
    partial class manager_login
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
            this.change_password_button.ForeColor = System.Drawing.Color.Red;
            this.change_password_button.Location = new System.Drawing.Point(357, 241);
            this.change_password_button.Name = "change_password_button";
            this.change_password_button.Size = new System.Drawing.Size(123, 16);
            this.change_password_button.TabIndex = 12;
            this.change_password_button.Text = "Change password?";
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(349, 273);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(144, 46);
            this.login_button.TabIndex = 11;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "username";
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(303, 205);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(212, 22);
            this.password_textbox.TabIndex = 8;
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(303, 155);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(212, 22);
            this.username_textbox.TabIndex = 7;
            // 
            // manager_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.change_password_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_textbox);
            this.Name = "manager_login";
            this.Text = "manager_login";
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