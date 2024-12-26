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
            firecombo.DisplayMember = "fname + ' ' + lname";
            firecombo.ValueMember = "employee_ID";

        }

        private void firecombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fire_Click(object sender, EventArgs e)
        {
            int employeeid = (int)firecombo.SelectedValue;
            int result;
            result=c.DeleteEmployee(employeeid);
            if (result != 0)
            {
                MessageBox.Show("Employee fired ");
            }

        }
    }
}
