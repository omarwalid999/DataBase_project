namespace DataBase_project
{
    partial class client_home
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
            this.events = new System.Windows.Forms.Button();
            this.NewEvent = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Button();
            this.notifications_count = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientseventdatagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingnumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venuesDGview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgett)).BeginInit();
            this.SuspendLayout();
            // 
            // events
            // 
            this.events.Location = new System.Drawing.Point(223, 78);
            this.events.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.events.Name = "events";
            this.events.Size = new System.Drawing.Size(312, 72);
            this.events.TabIndex = 0;
            this.events.Text = "My Events";
            this.events.UseVisualStyleBackColor = true;
            this.events.Click += new System.EventHandler(this.events_Click);
            // 
            // NewEvent
            // 
            this.NewEvent.Location = new System.Drawing.Point(223, 180);
            this.NewEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewEvent.Name = "NewEvent";
            this.NewEvent.Size = new System.Drawing.Size(312, 69);
            this.NewEvent.TabIndex = 1;
            this.NewEvent.Text = "New Event";
            this.NewEvent.UseVisualStyleBackColor = true;
            this.NewEvent.Click += new System.EventHandler(this.NewEvent_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(498, 324);
            this.logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(219, 44);
            this.logout.TabIndex = 3;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DataBase_project.Properties.Resources.mail;
            this.pictureBox1.Location = new System.Drawing.Point(14, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 97);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(27, 349);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(184, 45);
            this.back.TabIndex = 5;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Honeydew;
            this.cancel.Location = new System.Drawing.Point(649, 267);
            this.cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(89, 52);
            this.cancel.TabIndex = 36;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.Color.Honeydew;
            this.message.Location = new System.Drawing.Point(196, 256);
            this.message.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(272, 39);
            this.message.TabIndex = 35;
            this.message.Text = "send a message to organizer";
            this.message.UseVisualStyleBackColor = false;
            this.message.Visible = false;
            this.message.Click += new System.EventHandler(this.message_Click);
            // 
            // done
            // 
            this.done.BackColor = System.Drawing.Color.Honeydew;
            this.done.Location = new System.Drawing.Point(649, 104);
            this.done.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(89, 51);
            this.done.TabIndex = 34;
            this.done.Text = "Done";
            this.done.UseVisualStyleBackColor = false;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // eventdateTimePicker
            // 
            this.eventdateTimePicker.Location = new System.Drawing.Point(350, 190);
            this.eventdateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eventdateTimePicker.Name = "eventdateTimePicker";
            this.eventdateTimePicker.Size = new System.Drawing.Size(226, 22);
            this.eventdateTimePicker.TabIndex = 32;
            this.eventdateTimePicker.Visible = false;
            // 
            // otherchanges
            // 
            this.otherchanges.AutoSize = true;
            this.otherchanges.BackColor = System.Drawing.Color.Honeydew;
            this.otherchanges.Location = new System.Drawing.Point(187, 228);
            this.otherchanges.Name = "otherchanges";
            this.otherchanges.Size = new System.Drawing.Size(178, 16);
            this.otherchanges.TabIndex = 31;
            this.otherchanges.Text = "Want to change other things?";
            this.otherchanges.Visible = false;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Honeydew;
            this.date.Location = new System.Drawing.Point(236, 195);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(70, 16);
            this.date.TabIndex = 30;
            this.date.Text = "event date";
            this.date.Visible = false;
            // 
            // no_of_attendees
            // 
            this.no_of_attendees.AutoSize = true;
            this.no_of_attendees.BackColor = System.Drawing.Color.Honeydew;
            this.no_of_attendees.Location = new System.Drawing.Point(232, 145);
            this.no_of_attendees.Name = "no_of_attendees";
            this.no_of_attendees.Size = new System.Drawing.Size(99, 16);
            this.no_of_attendees.TabIndex = 29;
            this.no_of_attendees.Text = "no of attendees";
            this.no_of_attendees.Visible = false;
            // 
            // budget
            // 
            this.budget.AutoSize = true;
            this.budget.BackColor = System.Drawing.Color.Honeydew;
            this.budget.Location = new System.Drawing.Point(232, 117);
            this.budget.Name = "budget";
            this.budget.Size = new System.Drawing.Size(49, 16);
            this.budget.TabIndex = 28;
            this.budget.Text = "budget";
            this.budget.Visible = false;
            // 
            // eventname
            // 
            this.eventname.AutoSize = true;
            this.eventname.BackColor = System.Drawing.Color.Honeydew;
            this.eventname.Location = new System.Drawing.Point(227, 81);
            this.eventname.Name = "eventname";
            this.eventname.Size = new System.Drawing.Size(77, 16);
            this.eventname.TabIndex = 27;
            this.eventname.Text = "event name";
            this.eventname.Visible = false;
            // 
            // no_of_attendees_tb
            // 
            this.no_of_attendees_tb.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.no_of_attendees_tb.Location = new System.Drawing.Point(354, 144);
            this.no_of_attendees_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.no_of_attendees_tb.Name = "no_of_attendees_tb";
            this.no_of_attendees_tb.Size = new System.Drawing.Size(93, 22);
            this.no_of_attendees_tb.TabIndex = 26;
            this.no_of_attendees_tb.Visible = false;
            // 
            // budget_tb
            // 
            this.budget_tb.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.budget_tb.Location = new System.Drawing.Point(350, 112);
            this.budget_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.budget_tb.Name = "budget_tb";
            this.budget_tb.Size = new System.Drawing.Size(97, 22);
            this.budget_tb.TabIndex = 25;
            this.budget_tb.Visible = false;
            // 
            // eventname_tb
            // 
            this.eventname_tb.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.eventname_tb.Location = new System.Drawing.Point(350, 76);
            this.eventname_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eventname_tb.Name = "eventname_tb";
            this.eventname_tb.Size = new System.Drawing.Size(95, 22);
            this.eventname_tb.TabIndex = 24;
            this.eventname_tb.Visible = false;
            // 
            // sendfeedbackbutton
            // 
            this.sendfeedbackbutton.BackColor = System.Drawing.Color.Honeydew;
            this.sendfeedbackbutton.Location = new System.Drawing.Point(649, 205);
            this.sendfeedbackbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sendfeedbackbutton.Name = "sendfeedbackbutton";
            this.sendfeedbackbutton.Size = new System.Drawing.Size(89, 63);
            this.sendfeedbackbutton.TabIndex = 23;
            this.sendfeedbackbutton.Text = "give feedback";
            this.sendfeedbackbutton.UseVisualStyleBackColor = false;
            this.sendfeedbackbutton.Click += new System.EventHandler(this.sendfeedbackbutton_Click);
            // 
            // editeventbutton
            // 
            this.editeventbutton.BackColor = System.Drawing.Color.Honeydew;
            this.editeventbutton.Location = new System.Drawing.Point(649, 155);
            this.editeventbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editeventbutton.Name = "editeventbutton";
            this.editeventbutton.Size = new System.Drawing.Size(89, 53);
            this.editeventbutton.TabIndex = 22;
            this.editeventbutton.Text = "edit event";
            this.editeventbutton.UseVisualStyleBackColor = false;
            this.editeventbutton.Click += new System.EventHandler(this.editeventbutton_Click);
            // 
            // eventscombobox
            // 
            this.eventscombobox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.eventscombobox.FormattingEnabled = true;
            this.eventscombobox.Location = new System.Drawing.Point(31, 378);
            this.eventscombobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eventscombobox.Name = "eventscombobox";
            this.eventscombobox.Size = new System.Drawing.Size(160, 24);
            this.eventscombobox.TabIndex = 21;
            this.eventscombobox.SelectedIndexChanged += new System.EventHandler(this.eventscombobox_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DataBase_project.Properties.Resources.notif1;
            this.pictureBox2.Location = new System.Drawing.Point(716, 20);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // clientseventdatagridview
            // 
            this.clientseventdatagridview.AllowUserToAddRows = false;
            this.clientseventdatagridview.AllowUserToDeleteRows = false;
            this.clientseventdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientseventdatagridview.Location = new System.Drawing.Point(12, 112);
            this.clientseventdatagridview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientseventdatagridview.Name = "clientseventdatagridview";
            this.clientseventdatagridview.ReadOnly = true;
            this.clientseventdatagridview.RowHeadersWidth = 62;
            this.clientseventdatagridview.RowTemplate.Height = 28;
            this.clientseventdatagridview.Size = new System.Drawing.Size(606, 246);
            this.clientseventdatagridview.TabIndex = 38;
            this.clientseventdatagridview.Visible = false;
            this.clientseventdatagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientseventdatagridview_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(479, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "maximum 255 words";
            this.label1.Visible = false;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.Honeydew;
            this.submit.Location = new System.Drawing.Point(196, 314);
            this.submit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(188, 28);
            this.submit.TabIndex = 45;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Visible = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // ratingnumericUpDown1
            // 
            this.ratingnumericUpDown1.Location = new System.Drawing.Point(216, 281);
            this.ratingnumericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ratingnumericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ratingnumericUpDown1.Name = "ratingnumericUpDown1";
            this.ratingnumericUpDown1.Size = new System.Drawing.Size(149, 22);
            this.ratingnumericUpDown1.TabIndex = 44;
            this.ratingnumericUpDown1.Visible = false;
            this.ratingnumericUpDown1.ValueChanged += new System.EventHandler(this.ratingnumericUpDown1_ValueChanged);
            // 
            // rating
            // 
            this.rating.AutoSize = true;
            this.rating.BackColor = System.Drawing.Color.Honeydew;
            this.rating.Location = new System.Drawing.Point(43, 283);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(132, 16);
            this.rating.TabIndex = 43;
            this.rating.Text = "overall rating out of 5:";
            this.rating.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(43, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Select feedback\'s date:";
            this.label2.Visible = false;
            // 
            // dateTimePickerof_feedback
            // 
            this.dateTimePickerof_feedback.Location = new System.Drawing.Point(223, 248);
            this.dateTimePickerof_feedback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerof_feedback.Name = "dateTimePickerof_feedback";
            this.dateTimePickerof_feedback.Size = new System.Drawing.Size(272, 22);
            this.dateTimePickerof_feedback.TabIndex = 41;
            this.dateTimePickerof_feedback.Visible = false;
            // 
            // comment
            // 
            this.comment.AutoSize = true;
            this.comment.BackColor = System.Drawing.Color.Honeydew;
            this.comment.Location = new System.Drawing.Point(12, 125);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(98, 16);
            this.comment.TabIndex = 40;
            this.comment.Text = "enter comment:";
            this.comment.Visible = false;
            // 
            // comment_tb
            // 
            this.comment_tb.BackColor = System.Drawing.Color.Honeydew;
            this.comment_tb.Location = new System.Drawing.Point(15, 155);
            this.comment_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comment_tb.MaxLength = 255;
            this.comment_tb.Multiline = true;
            this.comment_tb.Name = "comment_tb";
            this.comment_tb.Size = new System.Drawing.Size(602, 82);
            this.comment_tb.TabIndex = 39;
            this.comment_tb.Visible = false;
            // 
            // cancell
            // 
            this.cancell.BackColor = System.Drawing.Color.Honeydew;
            this.cancell.Location = new System.Drawing.Point(416, 315);
            this.cancell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancell.Name = "cancell";
            this.cancell.Size = new System.Drawing.Size(182, 27);
            this.cancell.TabIndex = 48;
            this.cancell.Text = "Cancel";
            this.cancell.UseVisualStyleBackColor = false;
            this.cancell.Click += new System.EventHandler(this.cancell_Click);
            // 
            // venuess
            // 
            this.venuess.FormattingEnabled = true;
            this.venuess.Location = new System.Drawing.Point(456, 409);
            this.venuess.Name = "venuess";
            this.venuess.Size = new System.Drawing.Size(165, 24);
            this.venuess.TabIndex = 87;
            this.venuess.SelectedIndexChanged += new System.EventHandler(this.venuess_SelectedIndexChanged);
            // 
            // venuesDGview
            // 
            this.venuesDGview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.venuesDGview.Location = new System.Drawing.Point(442, 91);
            this.venuesDGview.Name = "venuesDGview";
            this.venuesDGview.RowHeadersWidth = 62;
            this.venuesDGview.RowTemplate.Height = 28;
            this.venuesDGview.Size = new System.Drawing.Size(441, 288);
            this.venuesDGview.TabIndex = 86;
            this.venuesDGview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.venuesDGview_CellContentClick);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(7, 120);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(114, 16);
            this.name.TabIndex = 85;
            this.name.Text = "New Event Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 84;
            this.label4.Text = "Event Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 82;
            this.label3.Text = "Number of Attendees";
            // 
            // budget_label
            // 
            this.budget_label.AutoSize = true;
            this.budget_label.Location = new System.Drawing.Point(8, 181);
            this.budget_label.Name = "budget_label";
            this.budget_label.Size = new System.Drawing.Size(81, 16);
            this.budget_label.TabIndex = 81;
            this.budget_label.Text = "Your Budget";
            // 
            // capacity
            // 
            this.capacity.Location = new System.Drawing.Point(145, 232);
            this.capacity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(171, 22);
            this.capacity.TabIndex = 80;
            // 
            // budgett
            // 
            this.budgett.Location = new System.Drawing.Point(145, 181);
            this.budgett.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.budgett.Name = "budgett";
            this.budgett.Size = new System.Drawing.Size(171, 22);
            this.budgett.TabIndex = 79;
            // 
            // event_date_picker
            // 
            this.event_date_picker.Location = new System.Drawing.Point(142, 353);
            this.event_date_picker.Name = "event_date_picker";
            this.event_date_picker.Size = new System.Drawing.Size(240, 22);
            this.event_date_picker.TabIndex = 78;
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(873, 485);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(10, 32);
            this.next.TabIndex = 77;
            this.next.Text = "next";
            this.next.UseVisualStyleBackColor = true;
            // 
            // venues
            // 
            this.venues.Location = new System.Drawing.Point(181, 400);
            this.venues.Name = "venues";
            this.venues.Size = new System.Drawing.Size(120, 66);
            this.venues.TabIndex = 76;
            this.venues.Text = "Show available venues";
            this.venues.UseVisualStyleBackColor = true;
            this.venues.Click += new System.EventHandler(this.venues_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 75;
            this.label5.Text = "Type of event";
            // 
            // typesofevents
            // 
            this.typesofevents.FormattingEnabled = true;
            this.typesofevents.Location = new System.Drawing.Point(142, 288);
            this.typesofevents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typesofevents.Name = "typesofevents";
            this.typesofevents.Size = new System.Drawing.Size(174, 24);
            this.typesofevents.TabIndex = 74;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 22);
            this.textBox1.TabIndex = 89;
            // 
            // back2
            // 
            this.back2.Location = new System.Drawing.Point(338, 478);
            this.back2.Name = "back2";
            this.back2.Size = new System.Drawing.Size(160, 38);
            this.back2.TabIndex = 91;
            this.back2.Text = "back";
            this.back2.UseVisualStyleBackColor = true;
            this.back2.Click += new System.EventHandler(this.back2_Click);
            // 
            // nextt
            // 
            this.nextt.Location = new System.Drawing.Point(760, 478);
            this.nextt.Name = "nextt";
            this.nextt.Size = new System.Drawing.Size(123, 39);
            this.nextt.TabIndex = 90;
            this.nextt.Text = "Next";
            this.nextt.UseVisualStyleBackColor = true;
            this.nextt.Click += new System.EventHandler(this.nextt_Click);
            // 
            // notifications_count
            // 
            this.notifications_count.ForeColor = System.Drawing.Color.Red;
            this.notifications_count.Location = new System.Drawing.Point(755, 70);
            this.notifications_count.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.notifications_count.Name = "notifications_count";
            this.notifications_count.Size = new System.Drawing.Size(31, 26);
            this.notifications_count.TabIndex = 11;
            this.notifications_count.TextChanged += new System.EventHandler(this.notifications_count_TextChanged);
            // 
            // client_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1026, 589);
            this.Controls.Add(this.back2);
            this.Controls.Add(this.nextt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.venuess);
            this.Controls.Add(this.venuesDGview);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.budget_label);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.budgett);
            this.Controls.Add(this.event_date_picker);
            this.Controls.Add(this.next);
            this.Controls.Add(this.venues);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.typesofevents);
            this.Controls.Add(this.cancell);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.ratingnumericUpDown1);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerof_feedback);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.comment_tb);
            this.Controls.Add(this.clientseventdatagridview);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.message);
            this.Controls.Add(this.done);
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
            this.Controls.Add(this.notifications_count);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.NewEvent);
            this.Controls.Add(this.events);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "client_home";
            this.Text = "client_home";
            this.Load += new System.EventHandler(this.client_home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientseventdatagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingnumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venuesDGview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgett)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button events;
        private System.Windows.Forms.Button NewEvent;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox notifications_count;
     
    }
}