namespace DataBase_project
{
    partial class employee_home
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
            this.ScheduledEventsButton = new System.Windows.Forms.Button();
            this.TasksListButton = new System.Windows.Forms.Button();
            this.VendorsButton = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.choose_event = new System.Windows.Forms.Button();
            this.event_combo = new System.Windows.Forms.ComboBox();
            this.mark = new System.Windows.Forms.Button();
            this.add_task = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.taskss = new System.Windows.Forms.TextBox();
            this.combo_task = new System.Windows.Forms.ComboBox();
            this.not_done = new System.Windows.Forms.Button();
            this.Done = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ScheduledEventsButton
            // 
            this.ScheduledEventsButton.Location = new System.Drawing.Point(141, 2);
            this.ScheduledEventsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ScheduledEventsButton.Name = "ScheduledEventsButton";
            this.ScheduledEventsButton.Size = new System.Drawing.Size(136, 51);
            this.ScheduledEventsButton.TabIndex = 0;
            this.ScheduledEventsButton.Text = "Scheduled Events";
            this.ScheduledEventsButton.UseVisualStyleBackColor = true;
            this.ScheduledEventsButton.Click += new System.EventHandler(this.ScheduledEventsButton_Click);
            // 
            // TasksListButton
            // 
            this.TasksListButton.Location = new System.Drawing.Point(275, 1);
            this.TasksListButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TasksListButton.Name = "TasksListButton";
            this.TasksListButton.Size = new System.Drawing.Size(137, 52);
            this.TasksListButton.TabIndex = 1;
            this.TasksListButton.Text = "Tasks List";
            this.TasksListButton.UseVisualStyleBackColor = true;
            this.TasksListButton.Click += new System.EventHandler(this.TasksListButton_Click);
            // 
            // VendorsButton
            // 
            this.VendorsButton.Location = new System.Drawing.Point(411, 2);
            this.VendorsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VendorsButton.Name = "VendorsButton";
            this.VendorsButton.Size = new System.Drawing.Size(134, 50);
            this.VendorsButton.TabIndex = 2;
            this.VendorsButton.Text = "Vendors";
            this.VendorsButton.UseVisualStyleBackColor = true;
            this.VendorsButton.Click += new System.EventHandler(this.VendorsButton_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.Location = new System.Drawing.Point(551, 12);
            this.logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(119, 30);
            this.logout.TabIndex = 3;
            this.logout.Text = "Log out";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DataBase_project.Properties.Resources.mail;
            this.pictureBox1.Location = new System.Drawing.Point(11, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(141, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(528, 231);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // choose_event
            // 
            this.choose_event.Location = new System.Drawing.Point(362, 295);
            this.choose_event.Name = "choose_event";
            this.choose_event.Size = new System.Drawing.Size(122, 23);
            this.choose_event.TabIndex = 8;
            this.choose_event.Text = "Choose Event";
            this.choose_event.UseVisualStyleBackColor = true;
            this.choose_event.Visible = false;
            this.choose_event.Click += new System.EventHandler(this.choose_event_Click);
            // 
            // event_combo
            // 
            this.event_combo.FormattingEnabled = true;
            this.event_combo.Location = new System.Drawing.Point(141, 294);
            this.event_combo.Name = "event_combo";
            this.event_combo.Size = new System.Drawing.Size(175, 24);
            this.event_combo.TabIndex = 7;
            this.event_combo.Visible = false;
            this.event_combo.SelectedIndexChanged += new System.EventHandler(this.event_combo_SelectedIndexChanged);
            // 
            // mark
            // 
            this.mark.Location = new System.Drawing.Point(12, 200);
            this.mark.Name = "mark";
            this.mark.Size = new System.Drawing.Size(108, 44);
            this.mark.TabIndex = 10;
            this.mark.Text = "Change status";
            this.mark.UseVisualStyleBackColor = true;
            this.mark.Visible = false;
            this.mark.Click += new System.EventHandler(this.mark_Click);
            // 
            // add_task
            // 
            this.add_task.Location = new System.Drawing.Point(12, 122);
            this.add_task.Name = "add_task";
            this.add_task.Size = new System.Drawing.Size(108, 46);
            this.add_task.TabIndex = 9;
            this.add_task.Text = "Add task";
            this.add_task.UseVisualStyleBackColor = true;
            this.add_task.Visible = false;
            this.add_task.Click += new System.EventHandler(this.add_task_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(101, 291);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(159, 50);
            this.submit.TabIndex = 13;
            this.submit.Text = "Submit Task";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Visible = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter task";
            this.label1.Visible = false;
            // 
            // taskss
            // 
            this.taskss.Location = new System.Drawing.Point(194, 119);
            this.taskss.Multiline = true;
            this.taskss.Name = "taskss";
            this.taskss.Size = new System.Drawing.Size(507, 107);
            this.taskss.TabIndex = 11;
            this.taskss.Visible = false;
            this.taskss.TextChanged += new System.EventHandler(this.tasks_TextChanged);
            // 
            // combo_task
            // 
            this.combo_task.FormattingEnabled = true;
            this.combo_task.Location = new System.Drawing.Point(11, 305);
            this.combo_task.Name = "combo_task";
            this.combo_task.Size = new System.Drawing.Size(239, 24);
            this.combo_task.TabIndex = 16;
            this.combo_task.SelectedIndexChanged += new System.EventHandler(this.combo_task_SelectedIndexChanged);
            // 
            // not_done
            // 
            this.not_done.BackColor = System.Drawing.Color.Red;
            this.not_done.Location = new System.Drawing.Point(274, 327);
            this.not_done.Name = "not_done";
            this.not_done.Size = new System.Drawing.Size(88, 29);
            this.not_done.TabIndex = 15;
            this.not_done.Text = "Not Done";
            this.not_done.UseVisualStyleBackColor = false;
            this.not_done.Click += new System.EventHandler(this.not_done_Click);
            // 
            // Done
            // 
            this.Done.BackColor = System.Drawing.Color.Lime;
            this.Done.Location = new System.Drawing.Point(274, 292);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(88, 29);
            this.Done.TabIndex = 14;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = false;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // employee_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 360);
            this.Controls.Add(this.combo_task);
            this.Controls.Add(this.not_done);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taskss);
            this.Controls.Add(this.mark);
            this.Controls.Add(this.add_task);
            this.Controls.Add(this.choose_event);
            this.Controls.Add(this.event_combo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.VendorsButton);
            this.Controls.Add(this.TasksListButton);
            this.Controls.Add(this.ScheduledEventsButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "employee_home";
            this.Text = "employee_home";
            this.Load += new System.EventHandler(this.employee_home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ScheduledEventsButton;
        private System.Windows.Forms.Button TasksListButton;
        private System.Windows.Forms.Button VendorsButton;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button choose_event;
        private System.Windows.Forms.ComboBox event_combo;
        private System.Windows.Forms.Button mark;
        private System.Windows.Forms.Button add_task;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox taskss;
        private System.Windows.Forms.ComboBox combo_task;
        private System.Windows.Forms.Button not_done;
        private System.Windows.Forms.Button Done;
    }
}