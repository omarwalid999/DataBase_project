using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//test push
namespace DataBase_project
{
    public partial class manager_login : Form
    {
        public manager_login()
        {
            InitializeComponent();
        }

        private void change_password_button_Click(object sender, EventArgs e)
        {
            m_change_pass f = new m_change_pass();
            f.Show();
        }

        private void login_button_Click(object sender, EventArgs e)
        { 
            Manager_home manager_Home = new Manager_home();
            manager_Home.Show();
            this.Hide();

        }
    }
    }
