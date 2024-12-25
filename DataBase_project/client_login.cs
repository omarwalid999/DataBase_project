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
            //law sah yerouh lel form eltanya
            //law ghalat ye2olo ghalat
        }
    }
}
