namespace DataBase_project
{
    partial class e_scheduled_events
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.event_combo = new System.Windows.Forms.ComboBox();
            this.choose_event = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(774, 314);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // event_combo
            // 
            this.event_combo.FormattingEnabled = true;
            this.event_combo.Location = new System.Drawing.Point(49, 366);
            this.event_combo.Name = "event_combo";
            this.event_combo.Size = new System.Drawing.Size(175, 24);
            this.event_combo.TabIndex = 1;
            // 
            // choose_event
            // 
            this.choose_event.Location = new System.Drawing.Point(270, 367);
            this.choose_event.Name = "choose_event";
            this.choose_event.Size = new System.Drawing.Size(122, 23);
            this.choose_event.TabIndex = 2;
            this.choose_event.Text = "Choose Event";
            this.choose_event.UseVisualStyleBackColor = true;
            this.choose_event.Click += new System.EventHandler(this.choose_event_Click);
            // 
            // e_scheduled_events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.choose_event);
            this.Controls.Add(this.event_combo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "e_scheduled_events";
            this.Text = "e_scheduled_events";
            this.Load += new System.EventHandler(this.e_scheduled_events_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox event_combo;
        private System.Windows.Forms.Button choose_event;
    }
}