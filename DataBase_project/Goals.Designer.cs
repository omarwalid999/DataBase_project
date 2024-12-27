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
            // Goals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goalsview);
            this.Name = "Goals";
            this.Text = "Goals";
            this.Load += new System.EventHandler(this.Goals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goalsview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView goalsview;
    }
}