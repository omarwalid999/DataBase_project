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
    public partial class client_first : Form
    {
        public client_first()
        {
            InitializeComponent();
        }

        private void client_first_Load(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            client_login f = new client_login();
            f.Show();
            this.Hide();
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            client_signup f = new client_signup();
            f.Show();
            this.Hide();
        }
    }
}
