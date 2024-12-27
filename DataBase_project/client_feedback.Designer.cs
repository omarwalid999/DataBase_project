namespace DataBase_project
{
    partial class client_feedback
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
            this.comment_tb = new System.Windows.Forms.TextBox();
            this.comment = new System.Windows.Forms.Label();
            this.dateTimePickerof_feedback = new System.Windows.Forms.DateTimePicker();
            this.date = new System.Windows.Forms.Label();
            this.rating = new System.Windows.Forms.Label();
            this.ratingnumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.submit = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ratingnumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // comment_tb
            // 
            this.comment_tb.Location = new System.Drawing.Point(50, 69);
            this.comment_tb.MaxLength = 255;
            this.comment_tb.Multiline = true;
            this.comment_tb.Name = "comment_tb";
            this.comment_tb.Size = new System.Drawing.Size(677, 101);
            this.comment_tb.TabIndex = 0;
            // 
            // comment
            // 
            this.comment.AutoSize = true;
            this.comment.Location = new System.Drawing.Point(47, 35);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(120, 20);
            this.comment.TabIndex = 1;
            this.comment.Text = "enter comment:";
            // 
            // dateTimePickerof_feedback
            // 
            this.dateTimePickerof_feedback.Location = new System.Drawing.Point(51, 227);
            this.dateTimePickerof_feedback.Name = "dateTimePickerof_feedback";
            this.dateTimePickerof_feedback.Size = new System.Drawing.Size(305, 26);
            this.dateTimePickerof_feedback.TabIndex = 2;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(44, 185);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(172, 20);
            this.date.TabIndex = 3;
            this.date.Text = "select feedback\'s date:";
            // 
            // rating
            // 
            this.rating.AutoSize = true;
            this.rating.Location = new System.Drawing.Point(47, 275);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(160, 20);
            this.rating.TabIndex = 4;
            this.rating.Text = "overall rating out of 5:";
            // 
            // ratingnumericUpDown1
            // 
            this.ratingnumericUpDown1.Location = new System.Drawing.Point(130, 298);
            this.ratingnumericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ratingnumericUpDown1.Name = "ratingnumericUpDown1";
            this.ratingnumericUpDown1.Size = new System.Drawing.Size(168, 26);
            this.ratingnumericUpDown1.TabIndex = 5;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(265, 372);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(211, 35);
            this.submit.TabIndex = 6;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(549, 372);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(205, 34);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(574, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "maximum 255 words";
            // 
            // client_feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.ratingnumericUpDown1);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.date);
            this.Controls.Add(this.dateTimePickerof_feedback);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.comment_tb);
            this.Name = "client_feedback";
            this.Text = "client_feedback";
            ((System.ComponentModel.ISupportInitialize)(this.ratingnumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox comment_tb;
        private System.Windows.Forms.Label comment;
        private System.Windows.Forms.DateTimePicker dateTimePickerof_feedback;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label rating;
        private System.Windows.Forms.NumericUpDown ratingnumericUpDown1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label1;
    }
}