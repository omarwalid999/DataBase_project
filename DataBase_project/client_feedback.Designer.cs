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
            this.comment_tb.Location = new System.Drawing.Point(44, 55);
            this.comment_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comment_tb.MaxLength = 255;
            this.comment_tb.Multiline = true;
            this.comment_tb.Name = "comment_tb";
            this.comment_tb.Size = new System.Drawing.Size(602, 82);
            this.comment_tb.TabIndex = 0;
            // 
            // comment
            // 
            this.comment.AutoSize = true;
            this.comment.Location = new System.Drawing.Point(42, 28);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(98, 16);
            this.comment.TabIndex = 1;
            this.comment.Text = "enter comment:";
            // 
            // dateTimePickerof_feedback
            // 
            this.dateTimePickerof_feedback.Location = new System.Drawing.Point(45, 182);
            this.dateTimePickerof_feedback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerof_feedback.Name = "dateTimePickerof_feedback";
            this.dateTimePickerof_feedback.Size = new System.Drawing.Size(272, 22);
            this.dateTimePickerof_feedback.TabIndex = 2;
            this.dateTimePickerof_feedback.ValueChanged += new System.EventHandler(this.dateTimePickerof_feedback_ValueChanged);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(39, 148);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(146, 16);
            this.date.TabIndex = 3;
            this.date.Text = "select feedback\'s date:";
            // 
            // rating
            // 
            this.rating.AutoSize = true;
            this.rating.Location = new System.Drawing.Point(42, 220);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(132, 16);
            this.rating.TabIndex = 4;
            this.rating.Text = "overall rating out of 5:";
            // 
            // ratingnumericUpDown1
            // 
            this.ratingnumericUpDown1.Location = new System.Drawing.Point(116, 238);
            this.ratingnumericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ratingnumericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ratingnumericUpDown1.Name = "ratingnumericUpDown1";
            this.ratingnumericUpDown1.Size = new System.Drawing.Size(149, 22);
            this.ratingnumericUpDown1.TabIndex = 5;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(236, 298);
            this.submit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(188, 28);
            this.submit.TabIndex = 6;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(488, 298);
            this.cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(182, 27);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "maximum 255 words";
            // 
            // client_feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.ratingnumericUpDown1);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.date);
            this.Controls.Add(this.dateTimePickerof_feedback);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.comment_tb);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "client_feedback";
            this.Text = "client_feedback";
            this.Load += new System.EventHandler(this.client_feedback_Load);
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