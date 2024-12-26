namespace DataBase_project
{
    partial class Vendors
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
            this.vendorsview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.vendoridtext = new System.Windows.Forms.TextBox();
            this.vendornametext = new System.Windows.Forms.TextBox();
            this.ratingtext = new System.Windows.Forms.TextBox();
            this.vaddresstext = new System.Windows.Forms.TextBox();
            this.phonetext = new System.Windows.Forms.TextBox();
            this.vemailtext = new System.Windows.Forms.TextBox();
            this.servicetext = new System.Windows.Forms.TextBox();
            this.addvendor = new System.Windows.Forms.Button();
            this.deletevendor = new System.Windows.Forms.Button();
            this.updatevendor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsview)).BeginInit();
            this.SuspendLayout();
            // 
            // vendorsview
            // 
            this.vendorsview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendorsview.Location = new System.Drawing.Point(31, 32);
            this.vendorsview.Name = "vendorsview";
            this.vendorsview.RowHeadersWidth = 51;
            this.vendorsview.RowTemplate.Height = 24;
            this.vendorsview.Size = new System.Drawing.Size(302, 311);
            this.vendorsview.TabIndex = 0;
            this.vendorsview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vendorsview_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vendor_ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vendor_Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rating";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(567, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vendor_address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(592, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Service";
            // 
            // vendoridtext
            // 
            this.vendoridtext.Location = new System.Drawing.Point(459, 32);
            this.vendoridtext.Name = "vendoridtext";
            this.vendoridtext.Size = new System.Drawing.Size(100, 22);
            this.vendoridtext.TabIndex = 8;
            // 
            // vendornametext
            // 
            this.vendornametext.Location = new System.Drawing.Point(681, 35);
            this.vendornametext.Name = "vendornametext";
            this.vendornametext.Size = new System.Drawing.Size(100, 22);
            this.vendornametext.TabIndex = 9;
            // 
            // ratingtext
            // 
            this.ratingtext.Location = new System.Drawing.Point(441, 78);
            this.ratingtext.Name = "ratingtext";
            this.ratingtext.Size = new System.Drawing.Size(100, 22);
            this.ratingtext.TabIndex = 10;
            // 
            // vaddresstext
            // 
            this.vaddresstext.Location = new System.Drawing.Point(681, 87);
            this.vaddresstext.Name = "vaddresstext";
            this.vaddresstext.Size = new System.Drawing.Size(100, 22);
            this.vaddresstext.TabIndex = 11;
            // 
            // phonetext
            // 
            this.phonetext.Location = new System.Drawing.Point(465, 133);
            this.phonetext.Name = "phonetext";
            this.phonetext.Size = new System.Drawing.Size(100, 22);
            this.phonetext.TabIndex = 12;
            // 
            // vemailtext
            // 
            this.vemailtext.Location = new System.Drawing.Point(666, 139);
            this.vemailtext.Name = "vemailtext";
            this.vemailtext.Size = new System.Drawing.Size(100, 22);
            this.vemailtext.TabIndex = 13;
            // 
            // servicetext
            // 
            this.servicetext.Location = new System.Drawing.Point(459, 194);
            this.servicetext.Name = "servicetext";
            this.servicetext.Size = new System.Drawing.Size(100, 22);
            this.servicetext.TabIndex = 14;
            // 
            // addvendor
            // 
            this.addvendor.Location = new System.Drawing.Point(386, 266);
            this.addvendor.Name = "addvendor";
            this.addvendor.Size = new System.Drawing.Size(75, 23);
            this.addvendor.TabIndex = 15;
            this.addvendor.Text = "ADD";
            this.addvendor.UseVisualStyleBackColor = true;
            this.addvendor.Click += new System.EventHandler(this.addvendor_Click);
            // 
            // deletevendor
            // 
            this.deletevendor.Location = new System.Drawing.Point(501, 266);
            this.deletevendor.Name = "deletevendor";
            this.deletevendor.Size = new System.Drawing.Size(75, 23);
            this.deletevendor.TabIndex = 16;
            this.deletevendor.Text = "DELETE";
            this.deletevendor.UseVisualStyleBackColor = true;
            this.deletevendor.Click += new System.EventHandler(this.deletevendor_Click);
            // 
            // updatevendor
            // 
            this.updatevendor.Location = new System.Drawing.Point(625, 266);
            this.updatevendor.Name = "updatevendor";
            this.updatevendor.Size = new System.Drawing.Size(75, 23);
            this.updatevendor.TabIndex = 17;
            this.updatevendor.Text = "UPDATE";
            this.updatevendor.UseVisualStyleBackColor = true;
            this.updatevendor.Click += new System.EventHandler(this.updatevendor_Click);
            // 
            // Vendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updatevendor);
            this.Controls.Add(this.deletevendor);
            this.Controls.Add(this.addvendor);
            this.Controls.Add(this.servicetext);
            this.Controls.Add(this.vemailtext);
            this.Controls.Add(this.phonetext);
            this.Controls.Add(this.vaddresstext);
            this.Controls.Add(this.ratingtext);
            this.Controls.Add(this.vendornametext);
            this.Controls.Add(this.vendoridtext);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vendorsview);
            this.Name = "Vendors";
            this.Text = "Vendors";
            this.Load += new System.EventHandler(this.Vendors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendorsview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView vendorsview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox vendoridtext;
        private System.Windows.Forms.TextBox vendornametext;
        private System.Windows.Forms.TextBox ratingtext;
        private System.Windows.Forms.TextBox vaddresstext;
        private System.Windows.Forms.TextBox phonetext;
        private System.Windows.Forms.TextBox vemailtext;
        private System.Windows.Forms.TextBox servicetext;
        private System.Windows.Forms.Button addvendor;
        private System.Windows.Forms.Button deletevendor;
        private System.Windows.Forms.Button updatevendor;
    }
}