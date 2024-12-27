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
            this.eventname_tb = new System.Windows.Forms.TextBox();
            this.budget_tb = new System.Windows.Forms.TextBox();
            this.no_of_attendees_tb = new System.Windows.Forms.TextBox();
            this.eventname = new System.Windows.Forms.Label();
            this.budget = new System.Windows.Forms.Label();
            this.no_of_attendees = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.otherchanges = new System.Windows.Forms.Label();
            this.eventdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.back = new System.Windows.Forms.Button();
            this.done = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientseventdatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // clientseventdatagridview
            // 
            this.clientseventdatagridview.AllowUserToAddRows = false;
            this.clientseventdatagridview.AllowUserToDeleteRows = false;
            this.clientseventdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientseventdatagridview.Location = new System.Drawing.Point(20, 39);
            this.clientseventdatagridview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientseventdatagridview.Name = "clientseventdatagridview";
            this.clientseventdatagridview.ReadOnly = true;
            this.clientseventdatagridview.RowHeadersWidth = 62;
            this.clientseventdatagridview.RowTemplate.Height = 28;
            this.clientseventdatagridview.Size = new System.Drawing.Size(687, 239);
            this.clientseventdatagridview.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Events:";
            // 
            // eventscombobox
            // 
            this.eventscombobox.FormattingEnabled = true;
            this.eventscombobox.Location = new System.Drawing.Point(44, 300);
            this.eventscombobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eventscombobox.Name = "eventscombobox";
            this.eventscombobox.Size = new System.Drawing.Size(216, 24);
            this.eventscombobox.TabIndex = 2;
            // 
            // editeventbutton
            // 
            this.editeventbutton.Location = new System.Drawing.Point(316, 296);
            this.editeventbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editeventbutton.Name = "editeventbutton";
            this.editeventbutton.Size = new System.Drawing.Size(177, 29);
            this.editeventbutton.TabIndex = 3;
            this.editeventbutton.Text = "edit event";
            this.editeventbutton.UseVisualStyleBackColor = true;
            this.editeventbutton.Click += new System.EventHandler(this.editeventbutton_Click);
            // 
            // sendfeedbackbutton
            // 
            this.sendfeedbackbutton.Location = new System.Drawing.Point(522, 298);
            this.sendfeedbackbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sendfeedbackbutton.Name = "sendfeedbackbutton";
            this.sendfeedbackbutton.Size = new System.Drawing.Size(168, 26);
            this.sendfeedbackbutton.TabIndex = 4;
            this.sendfeedbackbutton.Text = "give feedback";
            this.sendfeedbackbutton.UseVisualStyleBackColor = true;
            this.sendfeedbackbutton.Click += new System.EventHandler(this.sendfeedbackbutton_Click);
            // 
            // eventname_tb
            // 
            this.eventname_tb.Location = new System.Drawing.Point(157, 46);
            this.eventname_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eventname_tb.Name = "eventname_tb";
            this.eventname_tb.Size = new System.Drawing.Size(151, 22);
            this.eventname_tb.TabIndex = 5;
            // 
            // budget_tb
            // 
            this.budget_tb.Location = new System.Drawing.Point(155, 85);
            this.budget_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.budget_tb.Name = "budget_tb";
            this.budget_tb.Size = new System.Drawing.Size(153, 22);
            this.budget_tb.TabIndex = 6;
            // 
            // no_of_attendees_tb
            // 
            this.no_of_attendees_tb.Location = new System.Drawing.Point(159, 130);
            this.no_of_attendees_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.no_of_attendees_tb.Name = "no_of_attendees_tb";
            this.no_of_attendees_tb.Size = new System.Drawing.Size(149, 22);
            this.no_of_attendees_tb.TabIndex = 7;
            // 
            // eventname
            // 
            this.eventname.AutoSize = true;
            this.eventname.Location = new System.Drawing.Point(41, 51);
            this.eventname.Name = "eventname";
            this.eventname.Size = new System.Drawing.Size(77, 16);
            this.eventname.TabIndex = 9;
            this.eventname.Text = "event name";
            // 
            // budget
            // 
            this.budget.AutoSize = true;
            this.budget.Location = new System.Drawing.Point(44, 90);
            this.budget.Name = "budget";
            this.budget.Size = new System.Drawing.Size(49, 16);
            this.budget.TabIndex = 10;
            this.budget.Text = "budget";
            // 
            // no_of_attendees
            // 
            this.no_of_attendees.AutoSize = true;
            this.no_of_attendees.Location = new System.Drawing.Point(44, 131);
            this.no_of_attendees.Name = "no_of_attendees";
            this.no_of_attendees.Size = new System.Drawing.Size(99, 16);
            this.no_of_attendees.TabIndex = 11;
            this.no_of_attendees.Text = "no of attendees";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(48, 181);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(70, 16);
            this.date.TabIndex = 12;
            this.date.Text = "event date";
            // 
            // otherchanges
            // 
            this.otherchanges.AutoSize = true;
            this.otherchanges.Location = new System.Drawing.Point(48, 214);
            this.otherchanges.Name = "otherchanges";
            this.otherchanges.Size = new System.Drawing.Size(174, 16);
            this.otherchanges.TabIndex = 13;
            this.otherchanges.Text = "want to change other things?";
            // 
            // eventdateTimePicker
            // 
            this.eventdateTimePicker.Location = new System.Drawing.Point(155, 176);
            this.eventdateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eventdateTimePicker.Name = "eventdateTimePicker";
            this.eventdateTimePicker.Size = new System.Drawing.Size(197, 22);
            this.eventdateTimePicker.TabIndex = 14;
            this.eventdateTimePicker.ValueChanged += new System.EventHandler(this.eventdateTimePicker_ValueChanged);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(474, 338);
            this.back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(150, 54);
            this.back.TabIndex = 15;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // done
            // 
            this.done.Location = new System.Drawing.Point(425, 170);
            this.done.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(132, 27);
            this.done.TabIndex = 16;
            this.done.Text = "done";
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(44, 239);
            this.message.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(328, 29);
            this.message.TabIndex = 17;
            this.message.Text = "send a message to organizer";
            this.message.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(571, 169);
            this.cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(119, 28);
            this.cancel.TabIndex = 18;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // client_event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 402);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.message);
            this.Controls.Add(this.done);
            this.Controls.Add(this.back);
            this.Controls.Add(this.eventdateTimePicker);
            this.Controls.Add(this.otherchanges);
            this.Controls.Add(this.date);
            this.Controls.Add(this.no_of_attendees);
            this.Controls.Add(this.budget);
            this.Controls.Add(this.eventname);
            this.Controls.Add(this.no_of_attendees_tb);
            this.Controls.Add(this.budget_tb);
            this.Controls.Add(this.eventname_tb);
            this.Controls.Add(this.sendfeedbackbutton);
            this.Controls.Add(this.editeventbutton);
            this.Controls.Add(this.eventscombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientseventdatagridview);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.TextBox eventname_tb;
        private System.Windows.Forms.TextBox budget_tb;
        private System.Windows.Forms.TextBox no_of_attendees_tb;
        private System.Windows.Forms.Label eventname;
        private System.Windows.Forms.Label budget;
        private System.Windows.Forms.Label no_of_attendees;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label otherchanges;
        private System.Windows.Forms.DateTimePicker eventdateTimePicker;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Button message;
        private System.Windows.Forms.Button cancel;
    }
}