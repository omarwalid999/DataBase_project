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
    public partial class message_client : Form
    {
        int id;
        Controller controllerobj;
        public message_client(int id)
        {
            this.id = id;
            InitializeComponent();
            controllerobj = new Controller();
        }


        private void message_client_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = controllerobj.client_events(id);
            events.DataSource = dt;
            events.DisplayMember = "event_name";
            events.ValueMember = "event_ID";
        }

        private void receiver_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void events_SelectedIndexChanged(object sender, EventArgs e)
        {
            receiver.Text = controllerobj.get_employee_fname(id) + " " + controllerobj.get_employee_lname(id);
            subject.Text = events.Text;
        }

        private void send_button_Click(object sender, EventArgs e)
        {
            if (message_text.Text == "")
            {
                MessageBox.Show("Message empty!");
            }
            else
            {
                DateTime time = DateTime.Now;
                bool flag = true;
                int msg_id = controllerobj.message_count_ec()+1;
                int employee_id = controllerobj.employee_event((int)events.SelectedValue);
                controllerobj.addmessage_ec(msg_id, message_text.Text, time, id, employee_id, flag);
            }
        }
    }
}
