namespace DataBase_project
{
    partial class c_change_pass
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
            this.change_pass_button = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.oldpass = new System.Windows.Forms.TextBox();
            this.newpass = new System.Windows.Forms.TextBox();
            this.newpass_confirm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // change_pass_button
            // 
            this.change_pass_button.Location = new System.Drawing.Point(307, 338);
            this.change_pass_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.change_pass_button.Name = "change_pass_button";
            this.change_pass_button.Size = new System.Drawing.Size(253, 92);
            this.change_pass_button.TabIndex = 0;
            this.change_pass_button.Text = "Change password";
            this.change_pass_button.UseVisualStyleBackColor = true;
            this.change_pass_button.Click += new System.EventHandler(this.change_pass_button_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(309, 100);
            this.username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(249, 26);
            this.username.TabIndex = 1;
            // 
            // oldpass
            // 
            this.oldpass.Location = new System.Drawing.Point(310, 160);
            this.oldpass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.oldpass.Name = "oldpass";
            this.oldpass.Size = new System.Drawing.Size(249, 26);
            this.oldpass.TabIndex = 2;
            // 
            // newpass
            // 
            this.newpass.Location = new System.Drawing.Point(307, 220);
            this.newpass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newpass.Name = "newpass";
            this.newpass.Size = new System.Drawing.Size(249, 26);
            this.newpass.TabIndex = 3;
            // 
            // newpass_confirm
            // 
            this.newpass_confirm.Location = new System.Drawing.Point(310, 280);
            this.newpass_confirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newpass_confirm.Name = "newpass_confirm";
            this.newpass_confirm.Size = new System.Drawing.Size(249, 26);
            this.newpass_confirm.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Old password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "New password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Confirm pass";
            // 
            // c_change_pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newpass_confirm);
            this.Controls.Add(this.newpass);
            this.Controls.Add(this.oldpass);
            this.Controls.Add(this.username);
            this.Controls.Add(this.change_pass_button);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "c_change_pass";
            this.Text = "c_change_pass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button change_pass_button;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox oldpass;
        private System.Windows.Forms.TextBox newpass;
        private System.Windows.Forms.TextBox newpass_confirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}