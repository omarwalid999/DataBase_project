namespace DataBase_project
{
    partial class AddEvent
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
            this.label1 = new System.Windows.Forms.Label();
            this.eventidtext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.datetext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.evtypecombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.budgettext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.insertevent = new System.Windows.Forms.Button();
            this.empcombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.venuecombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.capacitytext = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.eventnametext = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.clienttext = new System.Windows.Forms.TextBox();
            this.cidtext = new System.Windows.Forms.TextBox();
            this.back9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Event_ID";
            // 
            // eventidtext
            // 
            this.eventidtext.Location = new System.Drawing.Point(123, 42);
            this.eventidtext.Name = "eventidtext";
            this.eventidtext.Size = new System.Drawing.Size(100, 22);
            this.eventidtext.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Event_Date";
            // 
            // datetext
            // 
            this.datetext.Location = new System.Drawing.Point(140, 96);
            this.datetext.Name = "datetext";
            this.datetext.Size = new System.Drawing.Size(100, 22);
            this.datetext.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Event_Type";
            // 
            // evtypecombo
            // 
            this.evtypecombo.FormattingEnabled = true;
            this.evtypecombo.Location = new System.Drawing.Point(123, 153);
            this.evtypecombo.Name = "evtypecombo";
            this.evtypecombo.Size = new System.Drawing.Size(121, 24);
            this.evtypecombo.TabIndex = 23;
            this.evtypecombo.SelectedIndexChanged += new System.EventHandler(this.evtypecombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Budget";
            // 
            // budgettext
            // 
            this.budgettext.Location = new System.Drawing.Point(123, 215);
            this.budgettext.Name = "budgettext";
            this.budgettext.Size = new System.Drawing.Size(100, 22);
            this.budgettext.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Employee";
            // 
            // insertevent
            // 
            this.insertevent.Location = new System.Drawing.Point(586, 334);
            this.insertevent.Name = "insertevent";
            this.insertevent.Size = new System.Drawing.Size(75, 23);
            this.insertevent.TabIndex = 27;
            this.insertevent.Text = "ADD";
            this.insertevent.UseVisualStyleBackColor = true;
            this.insertevent.Click += new System.EventHandler(this.button1_Click);
            // 
            // empcombo
            // 
            this.empcombo.FormattingEnabled = true;
            this.empcombo.Location = new System.Drawing.Point(421, 57);
            this.empcombo.Name = "empcombo";
            this.empcombo.Size = new System.Drawing.Size(121, 24);
            this.empcombo.TabIndex = 28;
            this.empcombo.SelectedIndexChanged += new System.EventHandler(this.empcombo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Venue";
            // 
            // venuecombo
            // 
            this.venuecombo.FormattingEnabled = true;
            this.venuecombo.Location = new System.Drawing.Point(123, 277);
            this.venuecombo.Name = "venuecombo";
            this.venuecombo.Size = new System.Drawing.Size(121, 24);
            this.venuecombo.TabIndex = 30;
            this.venuecombo.SelectedIndexChanged += new System.EventHandler(this.venuecombo_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "No of attendees";
            // 
            // capacitytext
            // 
            this.capacitytext.Location = new System.Drawing.Point(442, 118);
            this.capacitytext.Name = "capacitytext";
            this.capacitytext.Size = new System.Drawing.Size(100, 22);
            this.capacitytext.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(330, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Event Name";
            // 
            // eventnametext
            // 
            this.eventnametext.Location = new System.Drawing.Point(442, 174);
            this.eventnametext.Name = "eventnametext";
            this.eventnametext.Size = new System.Drawing.Size(100, 22);
            this.eventnametext.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(371, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Client";
            // 
            // clienttext
            // 
            this.clienttext.Location = new System.Drawing.Point(442, 232);
            this.clienttext.Name = "clienttext";
            this.clienttext.Size = new System.Drawing.Size(100, 22);
            this.clienttext.TabIndex = 36;
            // 
            // cidtext
            // 
            this.cidtext.Location = new System.Drawing.Point(586, 232);
            this.cidtext.Name = "cidtext";
            this.cidtext.Size = new System.Drawing.Size(100, 22);
            this.cidtext.TabIndex = 37;
            // 
            // back9
            // 
            this.back9.Location = new System.Drawing.Point(660, 390);
            this.back9.Name = "back9";
            this.back9.Size = new System.Drawing.Size(75, 23);
            this.back9.TabIndex = 38;
            this.back9.Text = "Back";
            this.back9.UseVisualStyleBackColor = true;
            this.back9.Click += new System.EventHandler(this.back9_Click);
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back9);
            this.Controls.Add(this.cidtext);
            this.Controls.Add(this.clienttext);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.eventnametext);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.capacitytext);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.venuecombo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.empcombo);
            this.Controls.Add(this.insertevent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.budgettext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.evtypecombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datetext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eventidtext);
            this.Controls.Add(this.label1);
            this.Name = "AddEvent";
            this.Text = "AddEvent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eventidtext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox datetext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox evtypecombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox budgettext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button insertevent;
        private System.Windows.Forms.ComboBox empcombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox venuecombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox capacitytext;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox eventnametext;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox clienttext;
        private System.Windows.Forms.TextBox cidtext;
        private System.Windows.Forms.Button back9;
    }
}