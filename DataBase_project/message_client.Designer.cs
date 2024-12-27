namespace DataBase_project
{
    partial class message_client
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
            this.message_text = new System.Windows.Forms.TextBox();
            this.send_button = new System.Windows.Forms.Button();
            this.events = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.receiver = new System.Windows.Forms.TextBox();
            this.subject = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // message_text
            // 
            this.message_text.Location = new System.Drawing.Point(90, 138);
            this.message_text.Multiline = true;
            this.message_text.Name = "message_text";
            this.message_text.Size = new System.Drawing.Size(609, 320);
            this.message_text.TabIndex = 0;
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(731, 408);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(163, 50);
            this.send_button.TabIndex = 1;
            this.send_button.Text = "Send";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // events
            // 
            this.events.FormattingEnabled = true;
            this.events.Location = new System.Drawing.Point(744, 39);
            this.events.Name = "events";
            this.events.Size = new System.Drawing.Size(150, 24);
            this.events.TabIndex = 2;
            this.events.SelectedIndexChanged += new System.EventHandler(this.events_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(697, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Event";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Subject: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // receiver
            // 
            this.receiver.Location = new System.Drawing.Point(142, 57);
            this.receiver.Name = "receiver";
            this.receiver.Size = new System.Drawing.Size(225, 22);
            this.receiver.TabIndex = 6;
            this.receiver.TextChanged += new System.EventHandler(this.receiver_TextChanged);
            // 
            // subject
            // 
            this.subject.Location = new System.Drawing.Point(142, 89);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(225, 22);
            this.subject.TabIndex = 7;
            // 
            // message_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 505);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.receiver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.events);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.message_text);
            this.Name = "message_client";
            this.Text = "message_client";
            this.Load += new System.EventHandler(this.message_client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox message_text;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.ComboBox events;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox receiver;
        private System.Windows.Forms.TextBox subject;
    }
}