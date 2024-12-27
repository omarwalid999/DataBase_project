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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataBase_project
{
    public partial class Goals : Form
    {
        Controller c;
        int g;
        int gid;
        public Goals()
        {
            InitializeComponent();
            c=new Controller();
            DataTable dt = c.goalslist();
            goalsview.DataSource=dt;
            goalsview.Refresh();
            DataTable dt2 = c.department();
            depcombo.DataSource=dt2;
            depcombo.DisplayMember = "dep_name";
             depcombo.ValueMember = "dep_ID";
            
        }

        private void Goals_Load(object sender, EventArgs e)
        {

        }

        private void depcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void setgoal_Click(object sender, EventArgs e)
        {
           
            int dwpid = Convert.ToInt32(depcombo.SelectedValue.ToString());
            if (goaltext.Text == "" || goalidtext.Text == "" || depcombo.SelectedIndex == -1)
            {
                MessageBox.Show("please enter all required fields");
            }
            else if (!int.TryParse(goaltext.Text, out g) || !int.TryParse(goalidtext.Text, out gid))
            {
                MessageBox.Show("enter a valid value");
            }
            else
            {
               g = Convert.ToInt32(goaltext.Text);
               gid = Convert.ToInt32(goalidtext.Text);
                int result;
                result = c.setgoal(gid, Convert.ToInt32(depcombo.SelectedValue), g);
                if (result != 0)
                {
                    MessageBox.Show("Added susscessfully");
                    goalsview.Refresh();
                }
            }

        }

        private void back92_Click(object sender, EventArgs e)
        {
            Manager_home M6= new Manager_home();
            M6.Show();
            this.Hide();

        }

        private void deletegoal_Click(object sender, EventArgs e)
        {
            int dwpid = Convert.ToInt32(depcombo.SelectedValue.ToString());
            if ( goalidtext.Text == "" || depcombo.SelectedIndex == -1)
            {
                MessageBox.Show("please enter all required fields");
            }
            else if (!int.TryParse(goalidtext.Text, out gid))
            {
                MessageBox.Show("enter a valid value");
            }
            else
            {
               // g = Convert.ToInt32(goaltext.Text);
                gid = Convert.ToInt32(goalidtext.Text);
                int result;
                result = c.deletegoal(gid, Convert.ToInt32(depcombo.SelectedValue));
                if (result != 0)
                {
                    MessageBox.Show("deleted susscessfully");
                    goalsview.Refresh();
                }
            }

        }

    }
    }

