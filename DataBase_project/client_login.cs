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
    public partial class client_login : Form
    {
        Controller cobj = new Controller();
        public client_login()
        {
            InitializeComponent();
        }

        private void change_password_button_Click(object sender, EventArgs e)
        {
            c_change_pass c_Change_Pass = new c_change_pass();
            c_Change_Pass.Show();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            //ye check credentials
            // int s = cobj.CheckUsername(username_textbox.Text, password_textbox.Text);
            if (cobj.check_login_c(username_textbox.Text, password_textbox.Text))
            {
                client_home f = new client_home();
                f.Show();
            }
            else
            {
                MessageBox.Show("please enter username and password correctly!");
            }

            //law sah yerouh lel form eltanya
            //client_home ch = new client_home();
            //ch.Show();
            //law ghalat ye2olo ghalat
        }
    }
}
