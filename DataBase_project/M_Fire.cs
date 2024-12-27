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
    public partial class M_Fire : Form
    {
        Controller c;
        public M_Fire()
        {
            InitializeComponent();
            c=new Controller();
            DataTable dt = c.Employeesnames();
            firecombo.DataSource = dt;
            firecombo.DisplayMember = "name";
            

        }

        private void firecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void fire_Click(object sender, EventArgs e)
        {
            string selectedemp = firecombo.SelectedItem.ToString();
            int empid = c.emp_id(selectedemp);
            int result;
            result=c.DeleteEmployee(empid);
            if (result != 0)
            {
                MessageBox.Show("Employee fired ");
            }

        }

        private void back3_Click(object sender, EventArgs e)
        {
            All_Employees E =new All_Employees();
            E.Show();
            this.Hide();

        }
    }
}
