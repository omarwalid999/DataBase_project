namespace DataBase_project
{
    partial class Manager_home
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
            this.allevents = new System.Windows.Forms.Button();
            this.allemployees = new System.Windows.Forms.Button();
            this.goals = new System.Windows.Forms.Button();
            this.vendors = new System.Windows.Forms.Button();
            this.services = new System.Windows.Forms.Button();
            this.eventtypes = new System.Windows.Forms.Button();
            this.allclients = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifications_count = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // allevents
            // 
            this.allevents.Location = new System.Drawing.Point(94, 323);
            this.allevents.Name = "allevents";
            this.allevents.Size = new System.Drawing.Size(175, 63);
            this.allevents.TabIndex = 0;
            this.allevents.Text = "All Events";
            this.allevents.UseVisualStyleBackColor = true;
            this.allevents.Click += new System.EventHandler(this.allevents_Click);
            // 
            // allemployees
            // 
            this.allemployees.Location = new System.Drawing.Point(86, 54);
            this.allemployees.Name = "allemployees";
            this.allemployees.Size = new System.Drawing.Size(183, 82);
            this.allemployees.TabIndex = 1;
            this.allemployees.Text = "All Employees";
            this.allemployees.UseVisualStyleBackColor = true;
            this.allemployees.Click += new System.EventHandler(this.allemployees_Click);
            // 
            // goals
            // 
            this.goals.Location = new System.Drawing.Point(569, 171);
            this.goals.Name = "goals";
            this.goals.Size = new System.Drawing.Size(132, 57);
            this.goals.TabIndex = 2;
            this.goals.Text = "Goals";
            this.goals.UseVisualStyleBackColor = true;
            this.goals.Click += new System.EventHandler(this.goals_Click);
            // 
            // vendors
            // 
            this.vendors.Location = new System.Drawing.Point(569, 64);
            this.vendors.Name = "vendors";
            this.vendors.Size = new System.Drawing.Size(132, 63);
            this.vendors.TabIndex = 3;
            this.vendors.Text = "Vendors";
            this.vendors.UseVisualStyleBackColor = true;
            this.vendors.Click += new System.EventHandler(this.vendors_Click);
            // 
            // services
            // 
            this.services.Location = new System.Drawing.Point(367, 64);
            this.services.Name = "services";
            this.services.Size = new System.Drawing.Size(160, 63);
            this.services.TabIndex = 4;
            this.services.Text = "Services";
            this.services.UseVisualStyleBackColor = true;
            this.services.Click += new System.EventHandler(this.services_Click);
            // 
            // eventtypes
            // 
            this.eventtypes.Location = new System.Drawing.Point(367, 171);
            this.eventtypes.Name = "eventtypes";
            this.eventtypes.Size = new System.Drawing.Size(160, 57);
            this.eventtypes.TabIndex = 5;
            this.eventtypes.Text = "Event_Types";
            this.eventtypes.UseVisualStyleBackColor = true;
            this.eventtypes.Click += new System.EventHandler(this.eventtypes_Click);
            // 
            // allclients
            // 
            this.allclients.Location = new System.Drawing.Point(94, 183);
            this.allclients.Name = "allclients";
            this.allclients.Size = new System.Drawing.Size(175, 72);
            this.allclients.TabIndex = 6;
            this.allclients.Text = "All Clients";
            this.allclients.UseVisualStyleBackColor = true;
            this.allclients.Click += new System.EventHandler(this.allclients_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DataBase_project.Properties.Resources.notif1;
            this.pictureBox2.Location = new System.Drawing.Point(718, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DataBase_project.Properties.Resources.mail;
            this.pictureBox1.Location = new System.Drawing.Point(11, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // notifications_count
            // 
            this.notifications_count.ForeColor = System.Drawing.Color.Red;
            this.notifications_count.Location = new System.Drawing.Point(760, 54);
            this.notifications_count.Name = "notifications_count";
            this.notifications_count.Size = new System.Drawing.Size(28, 22);
            this.notifications_count.TabIndex = 9;
            // 
            // Manager_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.notifications_count);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.allclients);
            this.Controls.Add(this.eventtypes);
            this.Controls.Add(this.services);
            this.Controls.Add(this.vendors);
            this.Controls.Add(this.goals);
            this.Controls.Add(this.allemployees);
            this.Controls.Add(this.allevents);
            this.Name = "Manager_home";
            this.Text = "Manager_home";
            this.Load += new System.EventHandler(this.Manager_home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button allevents;
        private System.Windows.Forms.Button allemployees;
        private System.Windows.Forms.Button goals;
        private System.Windows.Forms.Button vendors;
        private System.Windows.Forms.Button services;
        private System.Windows.Forms.Button eventtypes;
        private System.Windows.Forms.Button allclients;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox notifications_count;
    }
}