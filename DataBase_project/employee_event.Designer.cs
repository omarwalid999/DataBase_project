namespace DataBase_project
{
    partial class employee_event
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
            this.event_details_GDview = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Events = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.event_details_GDview)).BeginInit();
            this.SuspendLayout();
            // 
            // event_details_GDview
            // 
            this.event_details_GDview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.event_details_GDview.Location = new System.Drawing.Point(22, 43);
            this.event_details_GDview.Name = "event_details_GDview";
            this.event_details_GDview.RowHeadersWidth = 62;
            this.event_details_GDview.RowTemplate.Height = 28;
            this.event_details_GDview.Size = new System.Drawing.Size(380, 167);
            this.event_details_GDview.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "edit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(350, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "show  invoices";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Events
            // 
            this.Events.AutoSize = true;
            this.Events.Location = new System.Drawing.Point(25, 16);
            this.Events.Name = "Events";
            this.Events.Size = new System.Drawing.Size(103, 20);
            this.Events.TabIndex = 4;
            this.Events.Text = "Event Details";
            // 
            // employee_event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Events);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.event_details_GDview);
            this.Name = "employee_event";
            this.Text = "employee_event";
            this.Load += new System.EventHandler(this.employee_event_Load);
            ((System.ComponentModel.ISupportInitialize)(this.event_details_GDview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView event_details_GDview;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Events;
    }
}