namespace DataBase_project
{
    partial class M_Events
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
            this.alleventsview = new System.Windows.Forms.DataGridView();
            this.edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.alleventsview)).BeginInit();
            this.SuspendLayout();
            // 
            // alleventsview
            // 
            this.alleventsview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alleventsview.Location = new System.Drawing.Point(148, 50);
            this.alleventsview.Name = "alleventsview";
            this.alleventsview.RowHeadersWidth = 51;
            this.alleventsview.RowTemplate.Height = 24;
            this.alleventsview.Size = new System.Drawing.Size(471, 202);
            this.alleventsview.TabIndex = 0;
            this.alleventsview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.alleventsview_CellContentClick);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(148, 340);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 1;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // M_Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.alleventsview);
            this.Name = "M_Events";
            this.Text = "M_Events";
            this.Load += new System.EventHandler(this.M_Events_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alleventsview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView alleventsview;
        private System.Windows.Forms.Button edit;
    }
}