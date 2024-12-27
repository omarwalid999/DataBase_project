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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // allevents
            // 
            this.allevents.Location = new System.Drawing.Point(106, 404);
            this.allevents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.allevents.Name = "allevents";
            this.allevents.Size = new System.Drawing.Size(197, 79);
            this.allevents.TabIndex = 0;
            this.allevents.Text = "All Events";
            this.allevents.UseVisualStyleBackColor = true;
            this.allevents.Click += new System.EventHandler(this.allevents_Click);
            // 
            // allemployees
            // 
            this.allemployees.Location = new System.Drawing.Point(97, 68);
            this.allemployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.allemployees.Name = "allemployees";
            this.allemployees.Size = new System.Drawing.Size(206, 102);
            this.allemployees.TabIndex = 1;
            this.allemployees.Text = "All Employees";
            this.allemployees.UseVisualStyleBackColor = true;
            this.allemployees.Click += new System.EventHandler(this.allemployees_Click);
            // 
            // goals
            // 
            this.goals.Location = new System.Drawing.Point(640, 214);
            this.goals.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goals.Name = "goals";
            this.goals.Size = new System.Drawing.Size(148, 71);
            this.goals.TabIndex = 2;
            this.goals.Text = "Goals";
            this.goals.UseVisualStyleBackColor = true;
            this.goals.Click += new System.EventHandler(this.goals_Click);
            // 
            // vendors
            // 
            this.vendors.Location = new System.Drawing.Point(640, 80);
            this.vendors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vendors.Name = "vendors";
            this.vendors.Size = new System.Drawing.Size(148, 79);
            this.vendors.TabIndex = 3;
            this.vendors.Text = "Vendors";
            this.vendors.UseVisualStyleBackColor = true;
            this.vendors.Click += new System.EventHandler(this.vendors_Click);
            // 
            // services
            // 
            this.services.Location = new System.Drawing.Point(413, 80);
            this.services.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.services.Name = "services";
            this.services.Size = new System.Drawing.Size(180, 79);
            this.services.TabIndex = 4;
            this.services.Text = "Services";
            this.services.UseVisualStyleBackColor = true;
            this.services.Click += new System.EventHandler(this.services_Click);
            // 
            // eventtypes
            // 
            this.eventtypes.Location = new System.Drawing.Point(413, 214);
            this.eventtypes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eventtypes.Name = "eventtypes";
            this.eventtypes.Size = new System.Drawing.Size(180, 71);
            this.eventtypes.TabIndex = 5;
            this.eventtypes.Text = "Event_Types";
            this.eventtypes.UseVisualStyleBackColor = true;
            this.eventtypes.Click += new System.EventHandler(this.eventtypes_Click);
            // 
            // allclients
            // 
            this.allclients.Location = new System.Drawing.Point(106, 229);
            this.allclients.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.allclients.Name = "allclients";
            this.allclients.Size = new System.Drawing.Size(197, 90);
            this.allclients.TabIndex = 6;
            this.allclients.Text = "All Clients";
            this.allclients.UseVisualStyleBackColor = true;
            this.allclients.Click += new System.EventHandler(this.allclients_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DataBase_project.Properties.Resources.messages;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Manager_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.allclients);
            this.Controls.Add(this.eventtypes);
            this.Controls.Add(this.services);
            this.Controls.Add(this.vendors);
            this.Controls.Add(this.goals);
            this.Controls.Add(this.allemployees);
            this.Controls.Add(this.allevents);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Manager_home";
            this.Text = "Manager_home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
    }
}