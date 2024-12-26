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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void client_button_Click(object sender, EventArgs e)
        {
            client_first first = new client_first();
            first.Show();
        }

        private void employee_button_Click(object sender, EventArgs e)
        {
            employee_first employee = new employee_first();
            employee.Show();
            this.Hide();
        }
    }
}
