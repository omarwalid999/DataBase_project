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
    public partial class Event_Types : Form
    {
        Controller c;
        public Event_Types()
        {
            InitializeComponent();
            c = new Controller();
            DataTable dt = c.eventtypes();
            eventtypesview.DataSource = dt;

        }

        private void Event_Types_Load(object sender, EventArgs e)
        {

        }

        private void addtype_Click(object sender, EventArgs e)
        {
            if (eventtypetext.Text == "" || typeidtext.Text == "")
            {
                MessageBox.Show("Please enter all required fields");
            }
            else
            {
                int id;
                if (!int.TryParse(typeidtext.Text, out id))
                {
                    MessageBox.Show("Invalid ID number ");

                }
                else
                {
                    int result;
                    result = c.addtype(id, eventtypetext.Text);
                    if (result != 0)
                    {
                        MessageBox.Show("Type added successfully");
                        eventtypesview.Refresh();
                    }
                }
            }
        }

        private void removetype_Click(object sender, EventArgs e)
        {
            if (eventtypetext.Text == "" || typeidtext.Text == "")
            {
                MessageBox.Show("Please enter all required fields");
            }
            else
            {
                int id;
                if (!int.TryParse(typeidtext.Text, out id))
                {
                    MessageBox.Show("Invalid ID number ");

                }
                else
                {
                    int result;
                    result = c.deletetype(id, eventtypetext.Text);
                    if (result != 0)
                    {
                        MessageBox.Show("Type deleted successfully");
                        eventtypesview.Refresh();
                    }


                }

            }
        }

        private void back6_Click(object sender, EventArgs e)
        {
            Manager_home M3= new Manager_home();
            M3.Show();
            this.Hide();
        }
    }
}
