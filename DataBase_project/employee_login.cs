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
    public partial class employee_login : Form
    {
        public employee_login()
        {
            InitializeComponent();
        }

        private void change_password_button_Click(object sender, EventArgs e)
        {
            e_change_pass f = new e_change_pass();
            f.Show();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (username_textbox.Text != "" && password_textbox.Text != "")
            {
                //3ayzeen ne3mel check en el username w el password relevant le ba3d
                employee_home eh = new employee_home();
                eh.Show();
            }
        }
    }
}
