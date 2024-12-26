namespace DataBase_project
{
    partial class client_events
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
            this.eventdataGridView = new System.Windows.Forms.DataGridView();
            this.eventcomboBox = new System.Windows.Forms.ComboBox();
            this.editevent = new System.Windows.Forms.Button();
            this.showinvoices = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // eventdataGridView
            // 
            this.eventdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventdataGridView.Location = new System.Drawing.Point(47, 50);
            this.eventdataGridView.Name = "eventdataGridView";
            this.eventdataGridView.RowHeadersWidth = 62;
            this.eventdataGridView.RowTemplate.Height = 28;
            this.eventdataGridView.Size = new System.Drawing.Size(488, 184);
            this.eventdataGridView.TabIndex = 0;
            // 
            // eventcomboBox
            // 
            this.eventcomboBox.FormattingEnabled = true;
            this.eventcomboBox.Location = new System.Drawing.Point(58, 315);
            this.eventcomboBox.Name = "eventcomboBox";
            this.eventcomboBox.Size = new System.Drawing.Size(209, 28);
            this.eventcomboBox.TabIndex = 1;
            // 
            // editevent
            // 
            this.editevent.Location = new System.Drawing.Point(301, 315);
            this.editevent.Name = "editevent";
            this.editevent.Size = new System.Drawing.Size(160, 27);
            this.editevent.TabIndex = 2;
            this.editevent.Text = "edit event";
            this.editevent.UseVisualStyleBackColor = true;
            // 
            // showinvoices
            // 
            this.showinvoices.Location = new System.Drawing.Point(500, 316);
            this.showinvoices.Name = "showinvoices";
            this.showinvoices.Size = new System.Drawing.Size(233, 25);
            this.showinvoices.TabIndex = 3;
            this.showinvoices.Text = "Show Invoice";
            this.showinvoices.UseVisualStyleBackColor = true;
            // 
            // client_events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showinvoices);
            this.Controls.Add(this.editevent);
            this.Controls.Add(this.eventcomboBox);
            this.Controls.Add(this.eventdataGridView);
            this.Name = "client_events";
            this.Text = "client_events";
            this.Load += new System.EventHandler(this.client_events_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView eventdataGridView;
        private System.Windows.Forms.ComboBox eventcomboBox;
        private System.Windows.Forms.Button editevent;
        private System.Windows.Forms.Button showinvoices;
    }
}