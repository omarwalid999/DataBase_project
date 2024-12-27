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
        int manager_id;
        public Event_Types(int id)
        {
            InitializeComponent();
            c = new Controller();
            manager_id = id;
            DataTable dt = c.eventtypes();
            eventtypesview.DataSource = dt;

        }

        private void Event_Types_Load(object sender, EventArgs e)
        {

        }

        private void addtype_Click(object sender, EventArgs e)
        {
            int id;
            if (eventtypetext.Text == "" || typeidtext.Text == "")
            {
                MessageBox.Show("Please enter all required fields");
            }
            else if (!int.TryParse(typeidtext.Text, out id))
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


        private void removetype_Click(object sender, EventArgs e)
        {
            int id;
            if ( typeidtext.Text == "")
            {
                MessageBox.Show("Please enter all required fields");
            }
            else if (!int.TryParse(typeidtext.Text, out id))
            {
                MessageBox.Show("Invalid ID number ");
            }

            else
            {
                int result;
               
                result = c.deletetype(id);
                if (result != 0)
                {
                    MessageBox.Show("Type deleted successfully");
                    eventtypesview.Refresh();
                }


            }
        }

        private void back6_Click(object sender, EventArgs e)
        {
            Manager_home M3= new Manager_home(manager_id);
            M3.Show();
            this.Hide();
        }
    }
}
