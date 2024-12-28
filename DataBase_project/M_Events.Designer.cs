namespace DataBase_project
{
    partial class M_Events
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
            this.alleventsview = new System.Windows.Forms.DataGridView();
            this.edit = new System.Windows.Forms.Button();
            this.eventscombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addevent = new System.Windows.Forms.Button();
            this.deletevent = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.alleventsview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // alleventsview
            // 
            this.alleventsview.BackgroundColor = System.Drawing.Color.Honeydew;
            this.alleventsview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alleventsview.Location = new System.Drawing.Point(141, 55);
            this.alleventsview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.alleventsview.Name = "alleventsview";
            this.alleventsview.RowHeadersWidth = 51;
            this.alleventsview.RowTemplate.Height = 24;
            this.alleventsview.Size = new System.Drawing.Size(736, 309);
            this.alleventsview.TabIndex = 0;
            this.alleventsview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.alleventsview_CellContentClick);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.Honeydew;
            this.edit.Location = new System.Drawing.Point(363, 474);
            this.edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(211, 28);
            this.edit.TabIndex = 1;
            this.edit.Text = "Edit event details";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // eventscombo
            // 
            this.eventscombo.BackColor = System.Drawing.Color.Honeydew;
            this.eventscombo.FormattingEnabled = true;
            this.eventscombo.Location = new System.Drawing.Point(152, 475);
            this.eventscombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eventscombo.Name = "eventscombo";
            this.eventscombo.Size = new System.Drawing.Size(189, 28);
            this.eventscombo.TabIndex = 2;
            this.eventscombo.SelectedIndexChanged += new System.EventHandler(this.eventscombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose Event";
            // 
            // addevent
            // 
            this.addevent.BackColor = System.Drawing.Color.Honeydew;
            this.addevent.Location = new System.Drawing.Point(730, 384);
            this.addevent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addevent.Name = "addevent";
            this.addevent.Size = new System.Drawing.Size(147, 54);
            this.addevent.TabIndex = 5;
            this.addevent.Text = "Add new event";
            this.addevent.UseVisualStyleBackColor = false;
            this.addevent.Click += new System.EventHandler(this.addevent_Click);
            // 
            // deletevent
            // 
            this.deletevent.BackColor = System.Drawing.Color.Honeydew;
            this.deletevent.Location = new System.Drawing.Point(610, 475);
            this.deletevent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deletevent.Name = "deletevent";
            this.deletevent.Size = new System.Drawing.Size(211, 28);
            this.deletevent.TabIndex = 6;
            this.deletevent.Text = "Delete event";
            this.deletevent.UseVisualStyleBackColor = false;
            this.deletevent.Click += new System.EventHandler(this.deletevent_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DataBase_project.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(12, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // M_Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.deletevent);
            this.Controls.Add(this.addevent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventscombo);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.alleventsview);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "M_Events";
            this.Text = "M_Events";
            this.Load += new System.EventHandler(this.M_Events_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alleventsview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView alleventsview;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.ComboBox eventscombo;
        private System.Windows.Forms.Button addevent;
        private System.Windows.Forms.Button deletevent;
        private System.Windows.Forms.PictureBox pictureBox2;
        protected internal System.Windows.Forms.Label label1;
    }
}