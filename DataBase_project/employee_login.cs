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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DataBase_project
{
   
    public partial class employee_login : Form
    {
        Controller controllerobj;
        public employee_login()
        {
         
            controllerobj = new Controller();
            InitializeComponent();
   
            DataTable dt = controllerobj.get_employees(); 
     

        }

        private void change_password_button_Click(object sender, EventArgs e)
        {
            e_change_pass f = new e_change_pass();
            f.Show();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
           

            if (username_textbox.Text=="" || password_textbox.Text=="")
            {
                MessageBox.Show("❌ Please enter both username and password.");
                return;
            }

            if (controllerobj.check_login_e(username_textbox.Text, password_textbox.Text)) {
                int id = controllerobj.emp_id(username_textbox.Text);
                MessageBox.Show("Logged in successfuly!");
                employee_home login = new employee_home(id);
                login.Show();

            }
            else
            {
                MessageBox.Show("please enter username and password correctly!");
            }
        }




        private void username_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void employee_login_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
