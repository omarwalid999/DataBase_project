namespace DataBase_project
{
    partial class Add_task
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
            this.tasks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tasks
            // 
            this.tasks.Location = new System.Drawing.Point(140, 31);
            this.tasks.Multiline = true;
            this.tasks.Name = "tasks";
            this.tasks.Size = new System.Drawing.Size(507, 107);
            this.tasks.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter task";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(59, 206);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(159, 50);
            this.submit.TabIndex = 2;
            this.submit.Text = "Submit Task";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Add_task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 389);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tasks);
            this.Name = "Add_task";
            this.Text = "Add_task";
            this.Load += new System.EventHandler(this.Add_task_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tasks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submit;
    }
}