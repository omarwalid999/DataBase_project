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
            this.SuspendLayout();
            // 
            // allevents
            // 
            this.allevents.Location = new System.Drawing.Point(123, 85);
            this.allevents.Name = "allevents";
            this.allevents.Size = new System.Drawing.Size(150, 46);
            this.allevents.TabIndex = 0;
            this.allevents.Text = "All Events";
            this.allevents.UseVisualStyleBackColor = true;
            this.allevents.Click += new System.EventHandler(this.allevents_Click);
            // 
            // allemployees
            // 
            this.allemployees.Location = new System.Drawing.Point(123, 157);
            this.allemployees.Name = "allemployees";
            this.allemployees.Size = new System.Drawing.Size(150, 44);
            this.allemployees.TabIndex = 1;
            this.allemployees.Text = "All Employees";
            this.allemployees.UseVisualStyleBackColor = true;
            this.allemployees.Click += new System.EventHandler(this.allemployees_Click);
            // 
            // goals
            // 
            this.goals.Location = new System.Drawing.Point(138, 237);
            this.goals.Name = "goals";
            this.goals.Size = new System.Drawing.Size(92, 33);
            this.goals.TabIndex = 2;
            this.goals.Text = "Goals";
            this.goals.UseVisualStyleBackColor = true;
            // 
            // vendors
            // 
            this.vendors.Location = new System.Drawing.Point(361, 97);
            this.vendors.Name = "vendors";
            this.vendors.Size = new System.Drawing.Size(87, 34);
            this.vendors.TabIndex = 3;
            this.vendors.Text = "Vendors";
            this.vendors.UseVisualStyleBackColor = true;
            // 
            // services
            // 
            this.services.Location = new System.Drawing.Point(361, 178);
            this.services.Name = "services";
            this.services.Size = new System.Drawing.Size(75, 23);
            this.services.TabIndex = 4;
            this.services.Text = "Services";
            this.services.UseVisualStyleBackColor = true;
            // 
            // eventtypes
            // 
            this.eventtypes.Location = new System.Drawing.Point(346, 247);
            this.eventtypes.Name = "eventtypes";
            this.eventtypes.Size = new System.Drawing.Size(120, 23);
            this.eventtypes.TabIndex = 5;
            this.eventtypes.Text = "Event_Types";
            this.eventtypes.UseVisualStyleBackColor = true;
            // 
            // Manager_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eventtypes);
            this.Controls.Add(this.services);
            this.Controls.Add(this.vendors);
            this.Controls.Add(this.goals);
            this.Controls.Add(this.allemployees);
            this.Controls.Add(this.allevents);
            this.Name = "Manager_home";
            this.Text = "Manager_home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button allevents;
        private System.Windows.Forms.Button allemployees;
        private System.Windows.Forms.Button goals;
        private System.Windows.Forms.Button vendors;
        private System.Windows.Forms.Button services;
        private System.Windows.Forms.Button eventtypes;
    }
}