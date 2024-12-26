namespace DataBase_project
{
    partial class client_signup
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Fnametb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lnametb = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.Label();
            this.emailtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phonetb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.usernametb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passkeytb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.signupbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmpasskey = new System.Windows.Forms.TextBox();
            this.perror_message = new System.Windows.Forms.Label();
            this.error_message = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Fnametb
            // 
            this.Fnametb.Location = new System.Drawing.Point(160, 86);
            this.Fnametb.Name = "Fnametb";
            this.Fnametb.Size = new System.Drawing.Size(100, 26);
            this.Fnametb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // Lnametb
            // 
            this.Lnametb.Location = new System.Drawing.Point(160, 149);
            this.Lnametb.Name = "Lnametb";
            this.Lnametb.Size = new System.Drawing.Size(100, 26);
            this.Lnametb.TabIndex = 5;
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.Location = new System.Drawing.Point(34, 149);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(86, 20);
            this.Lname.TabIndex = 4;
            this.Lname.Text = "Last Name";
            // 
            // emailtb
            // 
            this.emailtb.Location = new System.Drawing.Point(510, 80);
            this.emailtb.Name = "emailtb";
            this.emailtb.Size = new System.Drawing.Size(100, 26);
            this.emailtb.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "email";
            // 
            // phonetb
            // 
            this.phonetb.Location = new System.Drawing.Point(510, 156);
            this.phonetb.Name = "phonetb";
            this.phonetb.Size = new System.Drawing.Size(100, 26);
            this.phonetb.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "phone";
            // 
            // usernametb
            // 
            this.usernametb.Location = new System.Drawing.Point(160, 220);
            this.usernametb.Name = "usernametb";
            this.usernametb.Size = new System.Drawing.Size(100, 26);
            this.usernametb.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "username";
            // 
            // passkeytb
            // 
            this.passkeytb.Location = new System.Drawing.Point(160, 290);
            this.passkeytb.Name = "passkeytb";
            this.passkeytb.Size = new System.Drawing.Size(100, 26);
            this.passkeytb.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "passkey";
            // 
            // signupbutton
            // 
            this.signupbutton.Location = new System.Drawing.Point(228, 422);
            this.signupbutton.Name = "signupbutton";
            this.signupbutton.Size = new System.Drawing.Size(157, 42);
            this.signupbutton.TabIndex = 14;
            this.signupbutton.Text = "sign up";
            this.signupbutton.UseVisualStyleBackColor = true;
            this.signupbutton.Click += new System.EventHandler(this.signupbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "confirm passkey";
            // 
            // confirmpasskey
            // 
            this.confirmpasskey.Location = new System.Drawing.Point(178, 350);
            this.confirmpasskey.Name = "confirmpasskey";
            this.confirmpasskey.Size = new System.Drawing.Size(113, 26);
            this.confirmpasskey.TabIndex = 16;
            // 
            // perror_message
            // 
            this.perror_message.AutoSize = true;
            this.perror_message.ForeColor = System.Drawing.Color.Red;
            this.perror_message.Location = new System.Drawing.Point(118, 388);
            this.perror_message.Name = "perror_message";
            this.perror_message.Size = new System.Drawing.Size(215, 20);
            this.perror_message.TabIndex = 17;
            this.perror_message.Text = "Error! passwords don\'t match";
            this.perror_message.Visible = false;
            // 
            // error_message
            // 
            this.error_message.AutoSize = true;
            this.error_message.ForeColor = System.Drawing.Color.Red;
            this.error_message.Location = new System.Drawing.Point(111, 388);
            this.error_message.Name = "error_message";
            this.error_message.Size = new System.Drawing.Size(222, 20);
            this.error_message.TabIndex = 18;
            this.error_message.Text = "Error! you have to fill in all data";
            this.error_message.Visible = false;
            // 
            // client_signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.error_message);
            this.Controls.Add(this.perror_message);
            this.Controls.Add(this.confirmpasskey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.signupbutton);
            this.Controls.Add(this.passkeytb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.usernametb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phonetb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emailtb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lnametb);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Fnametb);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "client_signup";
            this.Text = "client_signup";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox passkeytb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox usernametb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phonetb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Lnametb;
        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.TextBox Fnametb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signupbutton;
        private System.Windows.Forms.TextBox confirmpasskey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label perror_message;
        private System.Windows.Forms.Label error_message;
    }
}