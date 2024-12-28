﻿namespace DataBase_project
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
            this.notif = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifications_count = new System.Windows.Forms.TextBox();
            this.Stats = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.notif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // allevents
            // 
            this.allevents.BackColor = System.Drawing.Color.Honeydew;
            this.allevents.Location = new System.Drawing.Point(98, 198);
            this.allevents.Name = "allevents";
            this.allevents.Size = new System.Drawing.Size(175, 70);
            this.allevents.TabIndex = 0;
            this.allevents.Text = "All Events";
            this.allevents.UseVisualStyleBackColor = false;
            this.allevents.Click += new System.EventHandler(this.allevents_Click);
            // 
            // allemployees
            // 
            this.allemployees.BackColor = System.Drawing.Color.Honeydew;
            this.allemployees.Location = new System.Drawing.Point(98, 106);
            this.allemployees.Name = "allemployees";
            this.allemployees.Size = new System.Drawing.Size(175, 70);
            this.allemployees.TabIndex = 1;
            this.allemployees.Text = "All Employees";
            this.allemployees.UseVisualStyleBackColor = false;
            this.allemployees.Click += new System.EventHandler(this.allemployees_Click);
            // 
            // goals
            // 
            this.goals.BackColor = System.Drawing.Color.Honeydew;
            this.goals.Location = new System.Drawing.Point(96, 293);
            this.goals.Name = "goals";
            this.goals.Size = new System.Drawing.Size(177, 70);
            this.goals.TabIndex = 2;
            this.goals.Text = "Goals";
            this.goals.UseVisualStyleBackColor = false;
            this.goals.Click += new System.EventHandler(this.goals_Click);
            // 
            // vendors
            // 
            this.vendors.BackColor = System.Drawing.Color.Honeydew;
            this.vendors.Location = new System.Drawing.Point(525, 106);
            this.vendors.Name = "vendors";
            this.vendors.Size = new System.Drawing.Size(179, 70);
            this.vendors.TabIndex = 3;
            this.vendors.Text = "Vendors";
            this.vendors.UseVisualStyleBackColor = false;
            this.vendors.Click += new System.EventHandler(this.vendors_Click);
            // 
            // services
            // 
            this.services.BackColor = System.Drawing.Color.Honeydew;
            this.services.Location = new System.Drawing.Point(313, 198);
            this.services.Name = "services";
            this.services.Size = new System.Drawing.Size(179, 70);
            this.services.TabIndex = 4;
            this.services.Text = "Services";
            this.services.UseVisualStyleBackColor = false;
            this.services.Click += new System.EventHandler(this.services_Click);
            // 
            // eventtypes
            // 
            this.eventtypes.BackColor = System.Drawing.Color.Honeydew;
            this.eventtypes.Location = new System.Drawing.Point(525, 198);
            this.eventtypes.Name = "eventtypes";
            this.eventtypes.Size = new System.Drawing.Size(179, 70);
            this.eventtypes.TabIndex = 5;
            this.eventtypes.Text = "Event_Types";
            this.eventtypes.UseVisualStyleBackColor = false;
            this.eventtypes.Click += new System.EventHandler(this.eventtypes_Click);
            // 
            // allclients
            // 
            this.allclients.BackColor = System.Drawing.Color.Honeydew;
            this.allclients.Location = new System.Drawing.Point(313, 106);
            this.allclients.Name = "allclients";
            this.allclients.Size = new System.Drawing.Size(172, 70);
            this.allclients.TabIndex = 6;
            this.allclients.Text = "All Clients";
            this.allclients.UseVisualStyleBackColor = false;
            this.allclients.Click += new System.EventHandler(this.allclients_Click);
            // 
            // notif
            // 
            this.notif.Image = global::DataBase_project.Properties.Resources.notif1;
            this.notif.Location = new System.Drawing.Point(718, 10);
            this.notif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.notif.Name = "notif";
            this.notif.Size = new System.Drawing.Size(70, 58);
            this.notif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.notif.TabIndex = 8;
            this.notif.TabStop = false;
            this.notif.Click += new System.EventHandler(this.pictureBox2_Click);
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
            // Stats
            // 
            this.Stats.BackColor = System.Drawing.Color.Honeydew;
            this.Stats.Location = new System.Drawing.Point(322, 297);
            this.Stats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Stats.Name = "Stats";
            this.Stats.Size = new System.Drawing.Size(169, 66);
            this.Stats.TabIndex = 10;
            this.Stats.Text = "View Statistics";
            this.Stats.UseVisualStyleBackColor = false;
            // 
            // Manager_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Stats);
            this.Controls.Add(this.notifications_count);
            this.Controls.Add(this.notif);
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
            ((System.ComponentModel.ISupportInitialize)(this.notif)).EndInit();
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
        private System.Windows.Forms.PictureBox notif;
        private System.Windows.Forms.TextBox notifications_count;
        private System.Windows.Forms.Button Stats;
    }
}