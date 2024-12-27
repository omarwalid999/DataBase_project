using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_project
{
    public partial class client_feedback : Form
    {
        int id3;
        Controller cobj;
        int feedbackid = 50;
        public client_feedback(int id)
        {
            id3 = id;
            InitializeComponent();
            cobj = new Controller();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            client_event v = new client_event(id3);
            v.Show();
            this.Hide();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string date = dateTimePickerof_feedback.Value.ToString("yyyy-MM-dd");
            feedbackid++;
            if (comment.Text != " " && comment.Text != "")
            {
                int s = cobj.InsertFeedback(feedbackid, id3, comment_tb.ToString(), date, Convert.ToInt32(ratingnumericUpDown1.Value));
                if (s != 0)
                {
                    MessageBox.Show("Feedback registered successfully");
                }
                else
                {
                    MessageBox.Show("Feedback failed.");
                }
            }
            else
            {
                MessageBox.Show("you can't submit an empty feedback.");
            }
              
            //function to send feedback
        }
    }
}
