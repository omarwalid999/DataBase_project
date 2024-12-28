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
    public partial class employee_notifications : Form
    {
        Controller controllerobj;
        int emp_id;
        public employee_notifications(int id)
        {
            emp_id = id;
            controllerobj = new Controller();
            InitializeComponent();
        }

        private void employee_notifications_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt=controllerobj.employee_notifications(emp_id);
            messages.DataSource = dt;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            employee_home f = new employee_home(emp_id);
            f.Show();
            this.Close();
        }
    }
}
