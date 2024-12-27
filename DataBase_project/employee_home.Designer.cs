namespace DataBase_project
{
    partial class employee_home
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
            this.ScheduledEventsButton = new System.Windows.Forms.Button();
            this.TasksListButton = new System.Windows.Forms.Button();
            this.VendorsButton = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ScheduledEventsButton
            // 
            this.ScheduledEventsButton.Location = new System.Drawing.Point(159, 79);
            this.ScheduledEventsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ScheduledEventsButton.Name = "ScheduledEventsButton";
            this.ScheduledEventsButton.Size = new System.Drawing.Size(316, 65);
            this.ScheduledEventsButton.TabIndex = 0;
            this.ScheduledEventsButton.Text = "Scheduled Events";
            this.ScheduledEventsButton.UseVisualStyleBackColor = true;
            this.ScheduledEventsButton.Click += new System.EventHandler(this.ScheduledEventsButton_Click);
            // 
            // TasksListButton
            // 
            this.TasksListButton.Location = new System.Drawing.Point(159, 185);
            this.TasksListButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TasksListButton.Name = "TasksListButton";
            this.TasksListButton.Size = new System.Drawing.Size(316, 68);
            this.TasksListButton.TabIndex = 1;
            this.TasksListButton.Text = "Tasks List";
            this.TasksListButton.UseVisualStyleBackColor = true;
            this.TasksListButton.Click += new System.EventHandler(this.TasksListButton_Click);
            // 
            // VendorsButton
            // 
            this.VendorsButton.Location = new System.Drawing.Point(159, 284);
            this.VendorsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VendorsButton.Name = "VendorsButton";
            this.VendorsButton.Size = new System.Drawing.Size(316, 62);
            this.VendorsButton.TabIndex = 2;
            this.VendorsButton.Text = "Vendors";
            this.VendorsButton.UseVisualStyleBackColor = true;
            this.VendorsButton.Click += new System.EventHandler(this.VendorsButton_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(386, 385);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(212, 50);
            this.logout.TabIndex = 3;
            this.logout.Text = "Log out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DataBase_project.Properties.Resources.messages;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // employee_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.VendorsButton);
            this.Controls.Add(this.TasksListButton);
            this.Controls.Add(this.ScheduledEventsButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "employee_home";
            this.Text = "employee_home";
            this.Load += new System.EventHandler(this.employee_home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ScheduledEventsButton;
        private System.Windows.Forms.Button TasksListButton;
        private System.Windows.Forms.Button VendorsButton;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}