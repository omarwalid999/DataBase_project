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
            this.components = new System.ComponentModel.Container();
            this.events = new System.Windows.Forms.Button();
            this.NewEvent = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Button();
            this.notifications_count = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // events
            // 
            this.events.Location = new System.Drawing.Point(223, 78);
            this.events.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.events.Name = "events";
            this.events.Size = new System.Drawing.Size(312, 72);
            this.events.TabIndex = 0;
            this.events.Text = "My Events";
            this.events.UseVisualStyleBackColor = true;
            this.events.Click += new System.EventHandler(this.events_Click);
            // 
            // NewEvent
            // 
            this.NewEvent.Location = new System.Drawing.Point(223, 180);
            this.NewEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewEvent.Name = "NewEvent";
            this.NewEvent.Size = new System.Drawing.Size(312, 69);
            this.NewEvent.TabIndex = 1;
            this.NewEvent.Text = "New Event";
            this.NewEvent.UseVisualStyleBackColor = true;
            this.NewEvent.Click += new System.EventHandler(this.NewEvent_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(498, 324);
            this.logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(219, 44);
            this.logout.TabIndex = 3;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DataBase_project.Properties.Resources.mail;
            this.pictureBox1.Location = new System.Drawing.Point(14, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 97);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(27, 349);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(184, 45);
            this.back.TabIndex = 5;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // notifications_count
            // 
            this.notifications_count.ForeColor = System.Drawing.Color.Red;
            this.notifications_count.Location = new System.Drawing.Point(755, 70);
            this.notifications_count.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.notifications_count.Name = "notifications_count";
            this.notifications_count.Size = new System.Drawing.Size(31, 26);
            this.notifications_count.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DataBase_project.Properties.Resources.notif1;
            this.pictureBox2.Location = new System.Drawing.Point(708, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // client_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.notifications_count);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.NewEvent);
            this.Controls.Add(this.events);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "client_home";
            this.Text = "client_home";
            this.Load += new System.EventHandler(this.client_home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button events;
        private System.Windows.Forms.Button NewEvent;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox notifications_count;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}