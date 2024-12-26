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
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "username";
            comboBox1.ValueMember = "employee_ID";


        }

        private void change_password_button_Click(object sender, EventArgs e)
        {
            e_change_pass f = new e_change_pass();
            f.Show();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBox1.SelectedValue);
            string enteredPassword = password_textbox.Text;

            if (string.IsNullOrEmpty(enteredPassword))
            {
                MessageBox.Show("❌ Please enter both username and password.");
                return;
            }

            if (controllerobj.CheckPass(id, password_textbox.Text) is true)
            {
                employee_home eh = new employee_home(id);
                eh.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
                return ;
            }
        }




        private void username_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void employee_login_Load(object sender, EventArgs e)
        {

        }
    }
}
