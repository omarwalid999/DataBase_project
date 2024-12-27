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
            this.edit = new System.Windows.Forms.Button();
            this.show_invoices = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.event_details_GDview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // event_details_GDview
            // 
            this.event_details_GDview.BackgroundColor = System.Drawing.Color.Honeydew;
            this.event_details_GDview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.event_details_GDview.GridColor = System.Drawing.Color.Honeydew;
            this.event_details_GDview.Location = new System.Drawing.Point(157, 4);
            this.event_details_GDview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.event_details_GDview.Name = "event_details_GDview";
            this.event_details_GDview.RowHeadersWidth = 62;
            this.event_details_GDview.RowTemplate.Height = 28;
            this.event_details_GDview.Size = new System.Drawing.Size(688, 459);
            this.event_details_GDview.TabIndex = 0;
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.Honeydew;
            this.edit.Location = new System.Drawing.Point(8, 398);
            this.edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(136, 27);
            this.edit.TabIndex = 2;
            this.edit.Text = "edit";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // show_invoices
            // 
            this.show_invoices.BackColor = System.Drawing.Color.Honeydew;
            this.show_invoices.Location = new System.Drawing.Point(8, 367);
            this.show_invoices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.show_invoices.Name = "show_invoices";
            this.show_invoices.Size = new System.Drawing.Size(136, 27);
            this.show_invoices.TabIndex = 3;
            this.show_invoices.Text = "show  invoices";
            this.show_invoices.UseVisualStyleBackColor = false;
            this.show_invoices.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DataBase_project.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 175);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Honeydew;
            this.button1.Location = new System.Drawing.Point(90, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // employee_event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(852, 468);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.show_invoices);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.event_details_GDview);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "employee_event";
            this.Text = "employee_event";
            this.Load += new System.EventHandler(this.employee_event_Load);
            ((System.ComponentModel.ISupportInitialize)(this.event_details_GDview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView event_details_GDview;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button show_invoices;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}