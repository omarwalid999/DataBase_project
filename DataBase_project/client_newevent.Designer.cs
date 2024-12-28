namespace DataBase_project
{
    partial class client_newevent
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
            this.typesofevents = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.venues = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.eventname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.budget_label = new System.Windows.Forms.Label();
            this.capacity = new System.Windows.Forms.NumericUpDown();
            this.budget = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.event_date_picker = new System.Windows.Forms.DateTimePicker();
            this.garden = new System.Windows.Forms.RadioButton();
            this.beachbox1 = new System.Windows.Forms.PictureBox();
            this.hotelbox3 = new System.Windows.Forms.PictureBox();
            this.venuesDGview = new System.Windows.Forms.DataGridView();
            this.venuess = new System.Windows.Forms.ComboBox();
            this.back2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.capacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beachbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelbox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venuesDGview)).BeginInit();
            this.SuspendLayout();
            // 
            // typesofevents
            // 
            this.typesofevents.FormattingEnabled = true;
            this.typesofevents.Location = new System.Drawing.Point(252, 231);
            this.typesofevents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typesofevents.Name = "typesofevents";
            this.typesofevents.Size = new System.Drawing.Size(227, 24);
            this.typesofevents.TabIndex = 0;
            this.typesofevents.SelectedIndexChanged += new System.EventHandler(this.typesofevents_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type of event";
            // 
            // venues
            // 
            this.venues.Location = new System.Drawing.Point(339, 356);
            this.venues.Name = "venues";
            this.venues.Size = new System.Drawing.Size(182, 35);
            this.venues.TabIndex = 5;
            this.venues.Text = "show available venues";
            this.venues.UseVisualStyleBackColor = true;
            this.venues.Click += new System.EventHandler(this.themes_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(36, 517);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(137, 39);
            this.back.TabIndex = 21;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(1004, 421);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(123, 39);
            this.next.TabIndex = 28;
            this.next.Text = "next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(50, 63);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(84, 16);
            this.name.TabIndex = 61;
            this.name.Text = "Event Name:";
            // 
            // eventname
            // 
            this.eventname.Location = new System.Drawing.Point(0, 0);
            this.eventname.Name = "eventname";
            this.eventname.Size = new System.Drawing.Size(100, 22);
            this.eventname.TabIndex = 74;
            this.eventname.TextChanged += new System.EventHandler(this.eventname_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 59;
            this.label4.Text = "Event Date:";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(50, 22);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(166, 16);
            this.title.TabIndex = 58;
            this.title.Text = "Please Enter Event Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 57;
            this.label3.Text = "Number of Attendees";
            // 
            // budget_label
            // 
            this.budget_label.AutoSize = true;
            this.budget_label.Location = new System.Drawing.Point(51, 124);
            this.budget_label.Name = "budget_label";
            this.budget_label.Size = new System.Drawing.Size(81, 16);
            this.budget_label.TabIndex = 56;
            this.budget_label.Text = "Your Budget";
            // 
            // capacity
            // 
            this.capacity.Location = new System.Drawing.Point(255, 175);
            this.capacity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(237, 22);
            this.capacity.TabIndex = 55;
            this.capacity.ValueChanged += new System.EventHandler(this.capacity_ValueChanged);
            // 
            // budget
            // 
            this.budget.Location = new System.Drawing.Point(255, 124);
            this.budget.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.budget.Name = "budget";
            this.budget.Size = new System.Drawing.Size(240, 22);
            this.budget.TabIndex = 54;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1625, 982);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 59);
            this.button1.TabIndex = 53;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1231, 982);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 56);
            this.button2.TabIndex = 52;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // event_date_picker
            // 
            this.event_date_picker.Location = new System.Drawing.Point(252, 296);
            this.event_date_picker.Name = "event_date_picker";
            this.event_date_picker.Size = new System.Drawing.Size(269, 22);
            this.event_date_picker.TabIndex = 51;
            // 
            // garden
            // 
            this.garden.AutoSize = true;
            this.garden.Location = new System.Drawing.Point(1355, 643);
            this.garden.Name = "garden";
            this.garden.Size = new System.Drawing.Size(17, 16);
            this.garden.TabIndex = 70;
            this.garden.TabStop = true;
            this.garden.UseVisualStyleBackColor = true;
            // 
            // beachbox1
            // 
            this.beachbox1.Location = new System.Drawing.Point(107, 236);
            this.beachbox1.Name = "beachbox1";
            this.beachbox1.Size = new System.Drawing.Size(275, 183);
            this.beachbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.beachbox1.TabIndex = 5;
            this.beachbox1.TabStop = false;
            // 
            // hotelbox3
            // 
            this.hotelbox3.Location = new System.Drawing.Point(526, 236);
            this.hotelbox3.Name = "hotelbox3";
            this.hotelbox3.Size = new System.Drawing.Size(278, 179);
            this.hotelbox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.hotelbox3.TabIndex = 4;
            this.hotelbox3.TabStop = false;
            // 
            // venuesDGview
            // 
            this.venuesDGview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.venuesDGview.Location = new System.Drawing.Point(552, 27);
            this.venuesDGview.Name = "venuesDGview";
            this.venuesDGview.RowHeadersWidth = 62;
            this.venuesDGview.RowTemplate.Height = 28;
            this.venuesDGview.Size = new System.Drawing.Size(575, 295);
            this.venuesDGview.TabIndex = 71;
            // 
            // venuess
            // 
            this.venuess.FormattingEnabled = true;
            this.venuess.Location = new System.Drawing.Point(566, 352);
            this.venuess.Name = "venuess";
            this.venuess.Size = new System.Drawing.Size(299, 24);
            this.venuess.TabIndex = 72;
            // 
            // back2
            // 
            this.back2.Location = new System.Drawing.Point(582, 421);
            this.back2.Name = "back2";
            this.back2.Size = new System.Drawing.Size(160, 38);
            this.back2.TabIndex = 73;
            this.back2.Text = "back";
            this.back2.UseVisualStyleBackColor = true;
            this.back2.Click += new System.EventHandler(this.back2_Click);
            // 
            // client_newevent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.back2);
            this.Controls.Add(this.venuess);
            this.Controls.Add(this.venuesDGview);
            this.Controls.Add(this.garden);
            this.Controls.Add(this.name);
            this.Controls.Add(this.eventname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.budget_label);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.budget);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.event_date_picker);
            this.Controls.Add(this.next);
            this.Controls.Add(this.back);
            this.Controls.Add(this.venues);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typesofevents);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "client_newevent";
            this.Text = "client_newevent";
            this.Load += new System.EventHandler(this.client_newevent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.capacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beachbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelbox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venuesDGview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typesofevents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox beachbox1;
        private System.Windows.Forms.PictureBox hotelbox3;
        private System.Windows.Forms.Button venues;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox eventname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label budget_label;
        private System.Windows.Forms.NumericUpDown capacity;
        private System.Windows.Forms.NumericUpDown budget;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker event_date_picker;
        private System.Windows.Forms.RadioButton garden;
        private System.Windows.Forms.DataGridView venuesDGview;
        private System.Windows.Forms.ComboBox venuess;
        private System.Windows.Forms.Button back2;
    }
}