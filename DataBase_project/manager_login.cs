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
//test push
namespace DataBase_project
{
    public partial class manager_login : Form
    {
        Controller controllerobj;
        public manager_login()
        {
            InitializeComponent();
            controllerobj = new Controller();
        }

        private void change_password_button_Click(object sender, EventArgs e)
        {
            m_change_pass f = new m_change_pass();
            f.Show();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            int id = controllerobj.emp_id(username_textbox.Text);

            if (username_textbox.Text == "" || password_textbox.Text == "")
            {
                MessageBox.Show("❌ Please enter both username and password.");
                return;
            }
            else if (controllerobj.get_dep_id(username_textbox.Text)!= 6)
            {
                int deps = controllerobj.get_dep_id(username_textbox.Text);
                MessageBox.Show(deps.ToString(),"the dep id is =");
                MessageBox.Show("this username doesn't belong to a manager!");
            }
            else if (!controllerobj.check_login_e(username_textbox.Text, password_textbox.Text))
            {
                MessageBox.Show("please enter username and password correctly!");
            }
            else
            {
                MessageBox.Show("Logged in successfuly!");
                Manager_home manager_Home = new Manager_home();
                manager_Home.Show();
                this.Hide();
            }
            

        }
    }
    }
