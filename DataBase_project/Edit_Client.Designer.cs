namespace DataBase_project
{
    partial class Edit_Client
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
            this.clientinfoview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.clientinfoview)).BeginInit();
            this.SuspendLayout();
            // 
            // clientinfoview
            // 
            this.clientinfoview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientinfoview.Location = new System.Drawing.Point(125, 29);
            this.clientinfoview.Name = "clientinfoview";
            this.clientinfoview.RowHeadersWidth = 51;
            this.clientinfoview.RowTemplate.Height = 24;
            this.clientinfoview.Size = new System.Drawing.Size(488, 167);
            this.clientinfoview.TabIndex = 0;
            this.clientinfoview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientinfoview_CellContentClick);
            // 
            // Edit_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clientinfoview);
            this.Name = "Edit_Client";
            this.Text = "Edit_Client";
            this.Load += new System.EventHandler(this.Edit_Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientinfoview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView clientinfoview;
    }
}