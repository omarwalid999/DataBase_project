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
    public partial class employee_home : Form
    {
        int id;
        Controller controllerobj;
        public employee_home(int val)
        {
            InitializeComponent();
            id = val; 
            controllerobj = new Controller();  

        }

        private void ScheduledEventsButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            event_combo.Visible = true;
            choose_event.Visible = true;
            add_task.Visible = false;
            mark.Visible = false;
            submit.Visible = false;
            DataTable events = controllerobj.sch_events(id);
            dataGridView1.DataSource = events;
            event_combo.DataSource = events;
            event_combo.DisplayMember = "eventname";
            event_combo.ValueMember = "event_ID";
            //e_scheduled_events ese = new e_scheduled_events(id);
            //ese.Show();
            //this.Hide();
        }

        private void TasksListButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            dataGridView1.Visible = true;
            event_combo.Visible = false;
            choose_event.Visible = false;
            label1.Visible = false;
            taskss.Visible = false;
            submit.Visible = false;
            add_task.Visible = true;
            mark.Visible = true;
            DataTable tasks = controllerobj.task(id);
            dataGridView1.DataSource = tasks;
           
        }

        private void VendorsButton_Click(object sender, EventArgs e)
        { 

            dataGridView1.Refresh();
            dataGridView1.Visible = true;
            event_combo.Visible = false;
            choose_event.Visible = false;
            label1.Visible = false;
            taskss.Visible = false;
            submit.Visible = false;
            add_task.Visible = false;
            mark.Visible = false;
            event_combo.Visible = false;
            choose_event.Visible = false;
            add_task.Visible = false;
            mark.Visible = false;
            label1.Visible = false;
            taskss.Visible = false;
            submit.Visible = false;
            Controller controllerObj = new Controller();
            DataTable dt = controllerObj.ShowVendors();
            dataGridView1.DataSource = dt;
            
        }

        private void employee_home_Load(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            employee_login el = new employee_login();
            el.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_task_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            event_combo.Visible = false;
            choose_event.Visible = false;
            add_task.Visible = false;
            mark.Visible = false;
            label1.Visible = true;
            taskss.Visible = true;
            submit.Visible = true;



        }

        private void mark_Click(object sender, EventArgs e)
        {

        }

        private void tasks_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            int count = controllerobj.get_count() + 1;
            MessageBox.Show("num is" + count);
            string stat = "Not Yet";
            int result = controllerobj.insert_task(count, taskss.Text, stat, id);
            if (result == 0)
            {
                MessageBox.Show("Error in insertion");
            }
            else
            {
                MessageBox.Show("New task is inserted successfully!");
            }
        }
    }
}
