namespace DataBase_project
{
    partial class Goals
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
            this.goalsview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.goaltext = new System.Windows.Forms.TextBox();
            this.goalidtext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.depcombo = new System.Windows.Forms.ComboBox();
            this.setgoal = new System.Windows.Forms.Button();
            this.back92 = new System.Windows.Forms.Button();
            this.deletegoal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.goalsview)).BeginInit();
            this.SuspendLayout();
            // 
            // goalsview
            // 
            this.goalsview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goalsview.Location = new System.Drawing.Point(51, 44);
            this.goalsview.Name = "goalsview";
            this.goalsview.RowHeadersWidth = 51;
            this.goalsview.RowTemplate.Height = 24;
            this.goalsview.Size = new System.Drawing.Size(284, 322);
            this.goalsview.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Goal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Goal ID";
            // 
            // goaltext
            // 
            this.goaltext.Location = new System.Drawing.Point(517, 80);
            this.goaltext.Name = "goaltext";
            this.goaltext.Size = new System.Drawing.Size(100, 22);
            this.goaltext.TabIndex = 3;
            // 
            // goalidtext
            // 
            this.goalidtext.Location = new System.Drawing.Point(517, 135);
            this.goalidtext.Name = "goalidtext";
            this.goalidtext.Size = new System.Drawing.Size(100, 22);
            this.goalidtext.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Department";
            // 
            // depcombo
            // 
            this.depcombo.FormattingEnabled = true;
            this.depcombo.Location = new System.Drawing.Point(532, 194);
            this.depcombo.Name = "depcombo";
            this.depcombo.Size = new System.Drawing.Size(121, 24);
            this.depcombo.TabIndex = 6;
            this.depcombo.SelectedIndexChanged += new System.EventHandler(this.depcombo_SelectedIndexChanged);
            // 
            // setgoal
            // 
            this.setgoal.Location = new System.Drawing.Point(607, 307);
            this.setgoal.Name = "setgoal";
            this.setgoal.Size = new System.Drawing.Size(75, 23);
            this.setgoal.TabIndex = 7;
            this.setgoal.Text = "SET";
            this.setgoal.UseVisualStyleBackColor = true;
            this.setgoal.Click += new System.EventHandler(this.setgoal_Click);
            // 
            // back92
            // 
            this.back92.Location = new System.Drawing.Point(680, 367);
            this.back92.Name = "back92";
            this.back92.Size = new System.Drawing.Size(75, 23);
            this.back92.TabIndex = 8;
            this.back92.Text = "Back";
            this.back92.UseVisualStyleBackColor = true;
            this.back92.Click += new System.EventHandler(this.back92_Click);
            // 
            // deletegoal
            // 
            this.deletegoal.Location = new System.Drawing.Point(713, 307);
            this.deletegoal.Name = "deletegoal";
            this.deletegoal.Size = new System.Drawing.Size(75, 23);
            this.deletegoal.TabIndex = 9;
            this.deletegoal.Text = "DELETE";
            this.deletegoal.UseVisualStyleBackColor = true;
            this.deletegoal.Click += new System.EventHandler(this.deletegoal_Click);
            // 
            // Goals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deletegoal);
            this.Controls.Add(this.back92);
            this.Controls.Add(this.setgoal);
            this.Controls.Add(this.depcombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.goalidtext);
            this.Controls.Add(this.goaltext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goalsview);
            this.Name = "Goals";
            this.Text = "Goals";
            this.Load += new System.EventHandler(this.Goals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goalsview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView goalsview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox goaltext;
        private System.Windows.Forms.TextBox goalidtext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox depcombo;
        private System.Windows.Forms.Button setgoal;
        private System.Windows.Forms.Button back92;
        private System.Windows.Forms.Button deletegoal;
    }
}