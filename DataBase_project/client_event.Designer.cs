namespace DataBase_project
{
    partial class client_event
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
            this.clientseventdatagridview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.eventscombobox = new System.Windows.Forms.ComboBox();
            this.editeventbutton = new System.Windows.Forms.Button();
            this.sendfeedbackbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientseventdatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // clientseventdatagridview
            // 
            this.clientseventdatagridview.AllowUserToAddRows = false;
            this.clientseventdatagridview.AllowUserToDeleteRows = false;
            this.clientseventdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientseventdatagridview.Location = new System.Drawing.Point(23, 49);
            this.clientseventdatagridview.Name = "clientseventdatagridview";
            this.clientseventdatagridview.ReadOnly = true;
            this.clientseventdatagridview.RowHeadersWidth = 62;
            this.clientseventdatagridview.RowTemplate.Height = 28;
            this.clientseventdatagridview.Size = new System.Drawing.Size(765, 277);
            this.clientseventdatagridview.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Events:";
            // 
            // eventscombobox
            // 
            this.eventscombobox.FormattingEnabled = true;
            this.eventscombobox.Location = new System.Drawing.Point(50, 375);
            this.eventscombobox.Name = "eventscombobox";
            this.eventscombobox.Size = new System.Drawing.Size(242, 28);
            this.eventscombobox.TabIndex = 2;
            // 
            // editeventbutton
            // 
            this.editeventbutton.Location = new System.Drawing.Point(355, 370);
            this.editeventbutton.Name = "editeventbutton";
            this.editeventbutton.Size = new System.Drawing.Size(199, 36);
            this.editeventbutton.TabIndex = 3;
            this.editeventbutton.Text = "edit event";
            this.editeventbutton.UseVisualStyleBackColor = true;
            // 
            // sendfeedbackbutton
            // 
            this.sendfeedbackbutton.Location = new System.Drawing.Point(587, 372);
            this.sendfeedbackbutton.Name = "sendfeedbackbutton";
            this.sendfeedbackbutton.Size = new System.Drawing.Size(189, 33);
            this.sendfeedbackbutton.TabIndex = 4;
            this.sendfeedbackbutton.Text = "give feedback";
            this.sendfeedbackbutton.UseVisualStyleBackColor = true;
            // 
            // client_event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendfeedbackbutton);
            this.Controls.Add(this.editeventbutton);
            this.Controls.Add(this.eventscombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientseventdatagridview);
            this.Name = "client_event";
            this.Text = "client_event";
            this.Load += new System.EventHandler(this.client_event_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientseventdatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView clientseventdatagridview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox eventscombobox;
        private System.Windows.Forms.Button editeventbutton;
        private System.Windows.Forms.Button sendfeedbackbutton;
    }
}