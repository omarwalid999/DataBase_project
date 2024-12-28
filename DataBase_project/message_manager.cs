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
    public partial class message_manager : Form
    {
        Controller controllerobj;
        int manager_id;
        public message_manager( int id)
        {
            InitializeComponent();
            controllerobj = new Controller();
            manager_id= id;
        }

        private void message_manager_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt=controllerobj.get_employees_for_messages();
            employees.DataSource = dt;
            username_combobox.DataSource = dt;
            username_combobox.DisplayMember ="username" ;
        }

        private void send_button_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            int msg_id;
            int employee_id=controllerobj.get_emp_id_with_username(username_combobox.Text);
            if (message_text.Text == "")
            {
                MessageBox.Show("Message is empty!");
            }
            else
            {
                msg_id = controllerobj.message_count_em() + 1;
                controllerobj.addmessage_em(msg_id, message_text.Text, time, manager_id, employee_id, false);
                MessageBox.Show("message sent to employee successfuly!");
                Manager_home f = new Manager_home(manager_id);
                f.Show();
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Manager_home f = new Manager_home(manager_id);
            f.Show();
            this.Close();
        }
    }
}
