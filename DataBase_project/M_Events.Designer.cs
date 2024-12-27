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
            this.back7 = new System.Windows.Forms.Button();
            this.addevent = new System.Windows.Forms.Button();
            this.deletevent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.alleventsview)).BeginInit();
            this.SuspendLayout();
            // 
            // alleventsview
            // 
            this.alleventsview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alleventsview.Location = new System.Drawing.Point(148, 50);
            this.alleventsview.Name = "alleventsview";
            this.alleventsview.RowHeadersWidth = 51;
            this.alleventsview.RowTemplate.Height = 24;
            this.alleventsview.Size = new System.Drawing.Size(471, 202);
            this.alleventsview.TabIndex = 0;
            this.alleventsview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.alleventsview_CellContentClick);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(387, 318);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 1;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // eventscombo
            // 
            this.eventscombo.FormattingEnabled = true;
            this.eventscombo.Location = new System.Drawing.Point(229, 315);
            this.eventscombo.Name = "eventscombo";
            this.eventscombo.Size = new System.Drawing.Size(121, 24);
            this.eventscombo.TabIndex = 2;
            this.eventscombo.SelectedIndexChanged += new System.EventHandler(this.eventscombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose Event";
            // 
            // back7
            // 
            this.back7.Location = new System.Drawing.Point(648, 359);
            this.back7.Name = "back7";
            this.back7.Size = new System.Drawing.Size(75, 23);
            this.back7.TabIndex = 4;
            this.back7.Text = "Back";
            this.back7.UseVisualStyleBackColor = true;
            this.back7.Click += new System.EventHandler(this.back7_Click);
            // 
            // addevent
            // 
            this.addevent.Location = new System.Drawing.Point(138, 384);
            this.addevent.Name = "addevent";
            this.addevent.Size = new System.Drawing.Size(75, 23);
            this.addevent.TabIndex = 5;
            this.addevent.Text = "ADD";
            this.addevent.UseVisualStyleBackColor = true;
            this.addevent.Click += new System.EventHandler(this.addevent_Click);
            // 
            // deletevent
            // 
            this.deletevent.Location = new System.Drawing.Point(486, 318);
            this.deletevent.Name = "deletevent";
            this.deletevent.Size = new System.Drawing.Size(116, 23);
            this.deletevent.TabIndex = 6;
            this.deletevent.Text = "DELETE";
            this.deletevent.UseVisualStyleBackColor = true;
            this.deletevent.Click += new System.EventHandler(this.deletevent_Click);
            // 
            // M_Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deletevent);
            this.Controls.Add(this.addevent);
            this.Controls.Add(this.back7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventscombo);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.alleventsview);
            this.Name = "M_Events";
            this.Text = "M_Events";
            this.Load += new System.EventHandler(this.M_Events_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alleventsview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView alleventsview;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.ComboBox eventscombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back7;
        private System.Windows.Forms.Button addevent;
        private System.Windows.Forms.Button deletevent;
    }
}