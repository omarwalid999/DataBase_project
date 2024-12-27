namespace DataBase_project
{
    partial class message_employee
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
            this.subject = new System.Windows.Forms.TextBox();
            this.receiver = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.send_button = new System.Windows.Forms.Button();
            this.message_text = new System.Windows.Forms.TextBox();
            this.managers = new System.Windows.Forms.DataGridView();
            this.clients = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.managers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clients)).BeginInit();
            this.SuspendLayout();
            // 
            // subject
            // 
            this.subject.Location = new System.Drawing.Point(97, 120);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(225, 22);
            this.subject.TabIndex = 15;
            // 
            // receiver
            // 
            this.receiver.Location = new System.Drawing.Point(97, 88);
            this.receiver.Name = "receiver";
            this.receiver.Size = new System.Drawing.Size(225, 22);
            this.receiver.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Subject: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "To:";
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(477, 525);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(163, 50);
            this.send_button.TabIndex = 9;
            this.send_button.Text = "Send";
            this.send_button.UseVisualStyleBackColor = true;
            // 
            // message_text
            // 
            this.message_text.Location = new System.Drawing.Point(31, 169);
            this.message_text.Multiline = true;
            this.message_text.Name = "message_text";
            this.message_text.Size = new System.Drawing.Size(609, 320);
            this.message_text.TabIndex = 8;
            // 
            // managers
            // 
            this.managers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.managers.Location = new System.Drawing.Point(725, 45);
            this.managers.Name = "managers";
            this.managers.RowHeadersWidth = 51;
            this.managers.RowTemplate.Height = 24;
            this.managers.Size = new System.Drawing.Size(337, 209);
            this.managers.TabIndex = 16;
            // 
            // clients
            // 
            this.clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clients.Location = new System.Drawing.Point(725, 289);
            this.clients.Name = "clients";
            this.clients.RowHeadersWidth = 51;
            this.clients.RowTemplate.Height = 24;
            this.clients.Size = new System.Drawing.Size(337, 209);
            this.clients.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(876, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Managers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(876, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Clients";
            // 
            // message_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 601);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clients);
            this.Controls.Add(this.managers);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.receiver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.message_text);
            this.Name = "message_employee";
            this.Text = "message_employee";
            this.Load += new System.EventHandler(this.message_employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.managers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.TextBox receiver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.TextBox message_text;
        private System.Windows.Forms.DataGridView managers;
        private System.Windows.Forms.DataGridView clients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}