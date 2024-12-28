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
            this.Hide();
        }

        private void employee_button_Click(object sender, EventArgs e)
        {
            login employee = new login();
            employee.Show();
            this.Hide();
        }

        private void login_Click(object sender, EventArgs e)
        {
            login f = new login();
            f.Show();
            this.Hide();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            client_signup f = new client_signup();
            f.Show();
            this.Hide();
        }
    }
}
