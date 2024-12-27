namespace DataBase_project
{
    partial class e_vendors
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
            this.back = new System.Windows.Forms.Button();
            this.vendorsdataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(542, 310);
            this.back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(151, 34);
            this.back.TabIndex = 2;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // vendorsdataGridView
            // 
            this.vendorsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendorsdataGridView.Location = new System.Drawing.Point(40, 59);
            this.vendorsdataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vendorsdataGridView.Name = "vendorsdataGridView";
            this.vendorsdataGridView.RowHeadersWidth = 62;
            this.vendorsdataGridView.RowTemplate.Height = 28;
            this.vendorsdataGridView.Size = new System.Drawing.Size(536, 229);
            this.vendorsdataGridView.TabIndex = 0;
            this.vendorsdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vendorsdataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lis of all vendors:";
            // 
            // e_vendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vendorsdataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "e_vendors";
            this.Text = "e_vendors";
            this.Load += new System.EventHandler(this.e_vendors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendorsdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView vendorsdataGridView;
        private System.Windows.Forms.Label label1;
    }
}