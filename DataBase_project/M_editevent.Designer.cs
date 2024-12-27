namespace DataBase_project
{
    partial class M_editevent
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
            this.eventinfoview = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.budgettext = new System.Windows.Forms.TextBox();
            this.capacitytext = new System.Windows.Forms.TextBox();
            this.eventnametext = new System.Windows.Forms.TextBox();
            this.updatevent = new System.Windows.Forms.Button();
            this.evtypecombo = new System.Windows.Forms.ComboBox();
            this.empcombo = new System.Windows.Forms.ComboBox();
            this.venuecombo = new System.Windows.Forms.ComboBox();
            this.back8 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.client_combobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventinfoview)).BeginInit();
            this.SuspendLayout();
            // 
            // eventinfoview
            // 
            this.eventinfoview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventinfoview.Location = new System.Drawing.Point(12, 52);
            this.eventinfoview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eventinfoview.Name = "eventinfoview";
            this.eventinfoview.RowHeadersWidth = 51;
            this.eventinfoview.RowTemplate.Height = 24;
            this.eventinfoview.Size = new System.Drawing.Size(398, 414);
            this.eventinfoview.TabIndex = 0;
            this.eventinfoview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventinfoview_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(672, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Budget";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Event_Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(655, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Event_Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Employee";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(678, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Venue";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Client";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(416, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "No of attendees";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(677, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Event Name";
            // 
            // budgettext
            // 
            this.budgettext.Location = new System.Drawing.Point(756, 132);
            this.budgettext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.budgettext.Name = "budgettext";
            this.budgettext.Size = new System.Drawing.Size(112, 26);
            this.budgettext.TabIndex = 11;
            // 
            // capacitytext
            // 
            this.capacitytext.Location = new System.Drawing.Point(538, 197);
            this.capacitytext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.capacitytext.Name = "capacitytext";
            this.capacitytext.Size = new System.Drawing.Size(112, 26);
            this.capacitytext.TabIndex = 13;
            // 
            // eventnametext
            // 
            this.eventnametext.Location = new System.Drawing.Point(774, 270);
            this.eventnametext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eventnametext.Name = "eventnametext";
            this.eventnametext.Size = new System.Drawing.Size(112, 26);
            this.eventnametext.TabIndex = 16;
            // 
            // updatevent
            // 
            this.updatevent.Location = new System.Drawing.Point(694, 438);
            this.updatevent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updatevent.Name = "updatevent";
            this.updatevent.Size = new System.Drawing.Size(84, 29);
            this.updatevent.TabIndex = 21;
            this.updatevent.Text = "UPDATE";
            this.updatevent.UseVisualStyleBackColor = true;
            this.updatevent.Click += new System.EventHandler(this.updatevent_Click);
            // 
            // evtypecombo
            // 
            this.evtypecombo.FormattingEnabled = true;
            this.evtypecombo.Location = new System.Drawing.Point(513, 62);
            this.evtypecombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.evtypecombo.Name = "evtypecombo";
            this.evtypecombo.Size = new System.Drawing.Size(136, 28);
            this.evtypecombo.TabIndex = 22;
            this.evtypecombo.SelectedIndexChanged += new System.EventHandler(this.evtypecombo_SelectedIndexChanged);
            // 
            // empcombo
            // 
            this.empcombo.FormattingEnabled = true;
            this.empcombo.Location = new System.Drawing.Point(501, 125);
            this.empcombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.empcombo.Name = "empcombo";
            this.empcombo.Size = new System.Drawing.Size(136, 28);
            this.empcombo.TabIndex = 23;
            // 
            // venuecombo
            // 
            this.venuecombo.FormattingEnabled = true;
            this.venuecombo.Location = new System.Drawing.Point(737, 195);
            this.venuecombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.venuecombo.Name = "venuecombo";
            this.venuecombo.Size = new System.Drawing.Size(136, 28);
            this.venuecombo.TabIndex = 24;
            // 
            // back8
            // 
            this.back8.Location = new System.Drawing.Point(789, 502);
            this.back8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.back8.Name = "back8";
            this.back8.Size = new System.Drawing.Size(84, 29);
            this.back8.TabIndex = 25;
            this.back8.Text = "Back";
            this.back8.UseVisualStyleBackColor = true;
            this.back8.Click += new System.EventHandler(this.back8_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(662, 76);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 26);
            this.dateTimePicker1.TabIndex = 27;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // client_combobox
            // 
            this.client_combobox.FormattingEnabled = true;
            this.client_combobox.Location = new System.Drawing.Point(522, 254);
            this.client_combobox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.client_combobox.Name = "client_combobox";
            this.client_combobox.Size = new System.Drawing.Size(136, 28);
            this.client_combobox.TabIndex = 41;
            // 
            // M_editevent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.client_combobox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.back8);
            this.Controls.Add(this.venuecombo);
            this.Controls.Add(this.empcombo);
            this.Controls.Add(this.evtypecombo);
            this.Controls.Add(this.updatevent);
            this.Controls.Add(this.eventnametext);
            this.Controls.Add(this.capacitytext);
            this.Controls.Add(this.budgettext);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eventinfoview);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "M_editevent";
            this.Text = "M_editevent";
            this.Load += new System.EventHandler(this.M_editevent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventinfoview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView eventinfoview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox budgettext;
        private System.Windows.Forms.TextBox capacitytext;
        private System.Windows.Forms.TextBox eventnametext;
        private System.Windows.Forms.Button updatevent;
        private System.Windows.Forms.ComboBox evtypecombo;
        private System.Windows.Forms.ComboBox empcombo;
        private System.Windows.Forms.ComboBox venuecombo;
        private System.Windows.Forms.Button back8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox client_combobox;
    }
}