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
    public partial class c_change_pass : Form
    {
        Controller controllerobj;
        public c_change_pass()
        {
            InitializeComponent();
            controllerobj = new Controller();
        }

        private void change_pass_button_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || oldpass.Text == "" || newpass.Text == "" || newpass_confirm.Text == "")
            {
                MessageBox.Show("please fill all required spaces!");
            }
            else if (!controllerobj.check_login_c(username.Text, oldpass.Text))
            {
                MessageBox.Show("username and old password incorrect!");
            }
            else if (newpass.Text != newpass_confirm.Text)
            {
                MessageBox.Show("new passwords don't match");
            }
            else
            {
                controllerobj.change_pass_c(username.Text, newpass.Text);
                MessageBox.Show("password changed successfuly!");
                this.Close();
                client_login client_Login = new client_login();
                client_Login.Show();
            }
        }
    }
}
