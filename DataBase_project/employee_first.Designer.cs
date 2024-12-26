namespace DataBase_project
{
    partial class employee_first
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
            this.manager_button = new System.Windows.Forms.Button();
            this.employee_button = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manager_button
            // 
            this.manager_button.Location = new System.Drawing.Point(281, 122);
            this.manager_button.Name = "manager_button";
            this.manager_button.Size = new System.Drawing.Size(222, 97);
            this.manager_button.TabIndex = 0;
            this.manager_button.Text = "Manager";
            this.manager_button.UseVisualStyleBackColor = true;
            this.manager_button.Click += new System.EventHandler(this.manager_button_Click);
            // 
            // employee_button
            // 
            this.employee_button.Location = new System.Drawing.Point(281, 237);
            this.employee_button.Name = "employee_button";
            this.employee_button.Size = new System.Drawing.Size(222, 97);
            this.employee_button.TabIndex = 1;
            this.employee_button.Text = "Employee";
            this.employee_button.UseVisualStyleBackColor = true;
            this.employee_button.Click += new System.EventHandler(this.employee_button_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(543, 362);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(172, 32);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // employee_first
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.employee_button);
            this.Controls.Add(this.manager_button);
            this.Name = "employee_first";
            this.Text = "employee_first";
            this.Load += new System.EventHandler(this.employee_first_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manager_button;
        private System.Windows.Forms.Button employee_button;
        private System.Windows.Forms.Button BackButton;
    }
}