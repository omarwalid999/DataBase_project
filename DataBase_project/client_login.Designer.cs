﻿namespace DataBase_project
{
    partial class client_login
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
            this.components = new System.ComponentModel.Container();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.change_password_button = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(331, 205);
            this.username_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(238, 26);
            this.username_textbox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(331, 268);
            this.password_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(238, 26);
            this.password_textbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "password";
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(382, 352);
            this.login_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(162, 58);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // change_password_button
            // 
            this.change_password_button.AutoSize = true;
            this.change_password_button.ForeColor = System.Drawing.Color.Red;
            this.change_password_button.Location = new System.Drawing.Point(392, 312);
            this.change_password_button.Name = "change_password_button";
            this.change_password_button.Size = new System.Drawing.Size(146, 20);
            this.change_password_button.TabIndex = 6;
            this.change_password_button.Text = "Change password?";
            this.change_password_button.Click += new System.EventHandler(this.change_password_button_Click);
            // 
            // client_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.change_password_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_textbox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "client_login";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label change_password_button;
    }
}