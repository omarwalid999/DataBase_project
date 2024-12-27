namespace DataBase_project
{
    partial class Event_Types
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
            this.eventtypesview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addtype = new System.Windows.Forms.Button();
            this.removetype = new System.Windows.Forms.Button();
            this.eventtypetext = new System.Windows.Forms.TextBox();
            this.typeidtext = new System.Windows.Forms.TextBox();
            this.back6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventtypesview)).BeginInit();
            this.SuspendLayout();
            // 
            // eventtypesview
            // 
            this.eventtypesview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventtypesview.Location = new System.Drawing.Point(59, 48);
            this.eventtypesview.Name = "eventtypesview";
            this.eventtypesview.RowHeadersWidth = 51;
            this.eventtypesview.RowTemplate.Height = 24;
            this.eventtypesview.Size = new System.Drawing.Size(301, 306);
            this.eventtypesview.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Event Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type ID";
            // 
            // addtype
            // 
            this.addtype.Location = new System.Drawing.Point(442, 250);
            this.addtype.Name = "addtype";
            this.addtype.Size = new System.Drawing.Size(75, 23);
            this.addtype.TabIndex = 3;
            this.addtype.Text = "ADD";
            this.addtype.UseVisualStyleBackColor = true;
            this.addtype.Click += new System.EventHandler(this.addtype_Click);
            // 
            // removetype
            // 
            this.removetype.Location = new System.Drawing.Point(592, 250);
            this.removetype.Name = "removetype";
            this.removetype.Size = new System.Drawing.Size(75, 23);
            this.removetype.TabIndex = 4;
            this.removetype.Text = "REMOVE";
            this.removetype.UseVisualStyleBackColor = true;
            this.removetype.Click += new System.EventHandler(this.removetype_Click);
            // 
            // eventtypetext
            // 
            this.eventtypetext.Location = new System.Drawing.Point(533, 68);
            this.eventtypetext.Name = "eventtypetext";
            this.eventtypetext.Size = new System.Drawing.Size(100, 22);
            this.eventtypetext.TabIndex = 5;
            // 
            // typeidtext
            // 
            this.typeidtext.Location = new System.Drawing.Point(547, 141);
            this.typeidtext.Name = "typeidtext";
            this.typeidtext.Size = new System.Drawing.Size(100, 22);
            this.typeidtext.TabIndex = 6;
            // 
            // back6
            // 
            this.back6.Location = new System.Drawing.Point(638, 347);
            this.back6.Name = "back6";
            this.back6.Size = new System.Drawing.Size(75, 23);
            this.back6.TabIndex = 7;
            this.back6.Text = "Back";
            this.back6.UseVisualStyleBackColor = true;
            this.back6.Click += new System.EventHandler(this.back6_Click);
            // 
            // Event_Types
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back6);
            this.Controls.Add(this.typeidtext);
            this.Controls.Add(this.eventtypetext);
            this.Controls.Add(this.removetype);
            this.Controls.Add(this.addtype);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventtypesview);
            this.Name = "Event_Types";
            this.Text = "Event_Types";
            this.Load += new System.EventHandler(this.Event_Types_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventtypesview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView eventtypesview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addtype;
        private System.Windows.Forms.Button removetype;
        private System.Windows.Forms.TextBox eventtypetext;
        private System.Windows.Forms.TextBox typeidtext;
        private System.Windows.Forms.Button back6;
    }
}