namespace DataBase_project
{
    partial class Services
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
            this.servicesview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.serviceidtext = new System.Windows.Forms.TextBox();
            this.vendortext = new System.Windows.Forms.TextBox();
            this.servicenametext = new System.Windows.Forms.TextBox();
            this.invoicetext = new System.Windows.Forms.TextBox();
            this.pricetext = new System.Windows.Forms.TextBox();
            this.addservice = new System.Windows.Forms.Button();
            this.deleteservice = new System.Windows.Forms.Button();
            this.updateservice = new System.Windows.Forms.Button();
            this.back4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.servicesview)).BeginInit();
            this.SuspendLayout();
            // 
            // servicesview
            // 
            this.servicesview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesview.Location = new System.Drawing.Point(51, 36);
            this.servicesview.Name = "servicesview";
            this.servicesview.RowHeadersWidth = 51;
            this.servicesview.RowTemplate.Height = 24;
            this.servicesview.Size = new System.Drawing.Size(302, 352);
            this.servicesview.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Service-ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vendor_ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name of service";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Invoice ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Price";
            // 
            // serviceidtext
            // 
            this.serviceidtext.Location = new System.Drawing.Point(495, 49);
            this.serviceidtext.Name = "serviceidtext";
            this.serviceidtext.Size = new System.Drawing.Size(100, 22);
            this.serviceidtext.TabIndex = 7;
            // 
            // vendortext
            // 
            this.vendortext.Location = new System.Drawing.Point(495, 101);
            this.vendortext.Name = "vendortext";
            this.vendortext.Size = new System.Drawing.Size(100, 22);
            this.vendortext.TabIndex = 8;
            // 
            // servicenametext
            // 
            this.servicenametext.Location = new System.Drawing.Point(500, 165);
            this.servicenametext.Name = "servicenametext";
            this.servicenametext.Size = new System.Drawing.Size(100, 22);
            this.servicenametext.TabIndex = 10;
            // 
            // invoicetext
            // 
            this.invoicetext.Location = new System.Drawing.Point(495, 222);
            this.invoicetext.Name = "invoicetext";
            this.invoicetext.Size = new System.Drawing.Size(100, 22);
            this.invoicetext.TabIndex = 11;
            // 
            // pricetext
            // 
            this.pricetext.Location = new System.Drawing.Point(500, 270);
            this.pricetext.Name = "pricetext";
            this.pricetext.Size = new System.Drawing.Size(100, 22);
            this.pricetext.TabIndex = 12;
            // 
            // addservice
            // 
            this.addservice.Location = new System.Drawing.Point(392, 343);
            this.addservice.Name = "addservice";
            this.addservice.Size = new System.Drawing.Size(75, 23);
            this.addservice.TabIndex = 13;
            this.addservice.Text = "ADD";
            this.addservice.UseVisualStyleBackColor = true;
            this.addservice.Click += new System.EventHandler(this.addservice_Click);
            // 
            // deleteservice
            // 
            this.deleteservice.Location = new System.Drawing.Point(520, 343);
            this.deleteservice.Name = "deleteservice";
            this.deleteservice.Size = new System.Drawing.Size(75, 23);
            this.deleteservice.TabIndex = 14;
            this.deleteservice.Text = "DELETE";
            this.deleteservice.UseVisualStyleBackColor = true;
            this.deleteservice.Click += new System.EventHandler(this.deleteservice_Click);
            // 
            // updateservice
            // 
            this.updateservice.Location = new System.Drawing.Point(661, 343);
            this.updateservice.Name = "updateservice";
            this.updateservice.Size = new System.Drawing.Size(75, 23);
            this.updateservice.TabIndex = 15;
            this.updateservice.Text = "EDIT";
            this.updateservice.UseVisualStyleBackColor = true;
            this.updateservice.Click += new System.EventHandler(this.updateservice_Click);
            // 
            // back4
            // 
            this.back4.Location = new System.Drawing.Point(682, 399);
            this.back4.Name = "back4";
            this.back4.Size = new System.Drawing.Size(75, 23);
            this.back4.TabIndex = 16;
            this.back4.Text = "Back";
            this.back4.UseVisualStyleBackColor = true;
            this.back4.Click += new System.EventHandler(this.back4_Click);
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back4);
            this.Controls.Add(this.updateservice);
            this.Controls.Add(this.deleteservice);
            this.Controls.Add(this.addservice);
            this.Controls.Add(this.pricetext);
            this.Controls.Add(this.invoicetext);
            this.Controls.Add(this.servicenametext);
            this.Controls.Add(this.vendortext);
            this.Controls.Add(this.serviceidtext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.servicesview);
            this.Name = "Services";
            this.Text = "Services";
            this.Load += new System.EventHandler(this.Services_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicesview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView servicesview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox serviceidtext;
        private System.Windows.Forms.TextBox vendortext;
        private System.Windows.Forms.TextBox servicenametext;
        private System.Windows.Forms.TextBox invoicetext;
        private System.Windows.Forms.TextBox pricetext;
        private System.Windows.Forms.Button addservice;
        private System.Windows.Forms.Button deleteservice;
        private System.Windows.Forms.Button updateservice;
        private System.Windows.Forms.Button back4;
    }
}