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
    public partial class message_employee : Form
    {
        Controller controllerobj;
        int employee_id;
        public message_employee(int id)
        {
            employee_id = id;
            controllerobj = new Controller();
            InitializeComponent();
        }

        private void message_employee_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = controllerobj.get_managers();
            managers.DataSource = dt;
            DataTable dt1 = new DataTable();
            dt1 =controllerobj.get_employee_clients(employee_id);
            clients.DataSource = dt1;

            DataTable dt3 = new DataTable();
            dt3 = controllerobj.get_employee_clients_username(employee_id);

            username_combobox.DataSource = dt3;
            username_combobox.DisplayMember = "username";

        }

        private void send_button_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            int msg_id;
            int manager_id = controllerobj.get_emp_id_with_username(username_combobox.Text);
            int client_id = controllerobj.get_client_id_with_username(username_combobox.Text);
            if (message_text.Text == "")
            {
                MessageBox.Show("Message is empty!");
            }
            else if(manager_id == -1) 
            {
                msg_id = controllerobj.message_count_ec() + 1;
                controllerobj.addmessage_ec(msg_id, message_text.Text, time, client_id, employee_id, false);
                MessageBox.Show("message sent to client successfuly!");
                employee_home f= new employee_home(employee_id);
                f.Show();
                this.Close();

            }
            else
            {
                msg_id = controllerobj.message_count_em() + 1;
                controllerobj.addmessage_em(msg_id ,message_text.Text, time, manager_id, employee_id, true);
                MessageBox.Show("message sent to manager successfuly!");
                employee_home f = new employee_home(employee_id);
                f.Show();
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            employee_home f = new employee_home(employee_id);
            f.Show();
            this.Close();
        }
    }
}
