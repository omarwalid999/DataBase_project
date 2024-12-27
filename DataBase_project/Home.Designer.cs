namespace DataBase_project
{
    partial class Home
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
            this.client_button = new System.Windows.Forms.Button();
            this.employee_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // client_button
            // 
            this.client_button.Location = new System.Drawing.Point(215, 194);
            this.client_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.client_button.Name = "client_button";
            this.client_button.Size = new System.Drawing.Size(201, 125);
            this.client_button.TabIndex = 0;
            this.client_button.Text = "Client";
            this.client_button.UseVisualStyleBackColor = true;
            this.client_button.Click += new System.EventHandler(this.client_button_Click);
            // 
            // employee_button
            // 
            this.employee_button.Location = new System.Drawing.Point(476, 194);
            this.employee_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employee_button.Name = "employee_button";
            this.employee_button.Size = new System.Drawing.Size(201, 125);
            this.employee_button.TabIndex = 1;
            this.employee_button.Text = "Employee";
            this.employee_button.UseVisualStyleBackColor = true;
            this.employee_button.Click += new System.EventHandler(this.employee_button_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.employee_button);
            this.Controls.Add(this.client_button);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Home";
            this.Text = "Eventura";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button client_button;
        private System.Windows.Forms.Button employee_button;
    }
}

