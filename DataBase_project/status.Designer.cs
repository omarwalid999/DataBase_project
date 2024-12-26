namespace DataBase_project
{
    partial class status
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
            this.back = new System.Windows.Forms.Button();
            this.Done = new System.Windows.Forms.Button();
            this.not_done = new System.Windows.Forms.Button();
            this.combo_task = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(360, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(124, 25);
            this.back.TabIndex = 0;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.button1_Click);
            // 
            // Done
            // 
            this.Done.BackColor = System.Drawing.Color.Lime;
            this.Done.Location = new System.Drawing.Point(312, 89);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(88, 29);
            this.Done.TabIndex = 1;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = false;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // not_done
            // 
            this.not_done.BackColor = System.Drawing.Color.Red;
            this.not_done.Location = new System.Drawing.Point(312, 124);
            this.not_done.Name = "not_done";
            this.not_done.Size = new System.Drawing.Size(88, 29);
            this.not_done.TabIndex = 2;
            this.not_done.Text = "Not Done";
            this.not_done.UseVisualStyleBackColor = false;
            this.not_done.Click += new System.EventHandler(this.not_done_Click);
            // 
            // combo_task
            // 
            this.combo_task.FormattingEnabled = true;
            this.combo_task.Location = new System.Drawing.Point(49, 102);
            this.combo_task.Name = "combo_task";
            this.combo_task.Size = new System.Drawing.Size(239, 24);
            this.combo_task.TabIndex = 3;
            // 
            // status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 201);
            this.Controls.Add(this.combo_task);
            this.Controls.Add(this.not_done);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.back);
            this.Name = "status";
            this.Text = "status";
            this.Load += new System.EventHandler(this.status_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.Button not_done;
        private System.Windows.Forms.ComboBox combo_task;
    }
}