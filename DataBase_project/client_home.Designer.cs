namespace DataBase_project
{
    partial class client_home
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
            this.events = new System.Windows.Forms.Button();
            this.NewEvent = new System.Windows.Forms.Button();
            this.previousevents = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // events
            // 
            this.events.Location = new System.Drawing.Point(120, 57);
            this.events.Name = "events";
            this.events.Size = new System.Drawing.Size(312, 73);
            this.events.TabIndex = 0;
            this.events.Text = "My Events";
            this.events.UseVisualStyleBackColor = true;
            // 
            // NewEvent
            // 
            this.NewEvent.Location = new System.Drawing.Point(120, 150);
            this.NewEvent.Name = "NewEvent";
            this.NewEvent.Size = new System.Drawing.Size(312, 69);
            this.NewEvent.TabIndex = 1;
            this.NewEvent.Text = "New Event";
            this.NewEvent.UseVisualStyleBackColor = true;
            this.NewEvent.Click += new System.EventHandler(this.NewEvent_Click);
            // 
            // previousevents
            // 
            this.previousevents.Location = new System.Drawing.Point(120, 239);
            this.previousevents.Name = "previousevents";
            this.previousevents.Size = new System.Drawing.Size(311, 72);
            this.previousevents.TabIndex = 2;
            this.previousevents.Text = "Previous Events";
            this.previousevents.UseVisualStyleBackColor = true;
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(480, 337);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(219, 44);
            this.logout.TabIndex = 3;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // client_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.previousevents);
            this.Controls.Add(this.NewEvent);
            this.Controls.Add(this.events);
            this.Name = "client_home";
            this.Text = "client_home";
            this.Load += new System.EventHandler(this.client_home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button events;
        private System.Windows.Forms.Button NewEvent;
        private System.Windows.Forms.Button previousevents;
        private System.Windows.Forms.Button logout;
    }
}