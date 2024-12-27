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
            Done.Visible = false;
            not_done.Visible = false;
            combo_task.Visible = false;

        }

        private void ScheduledEventsButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            event_combo.Visible = true;
            choose_event.Visible = true;
            add_task.Visible = false;
            mark.Visible = false;
            submit.Visible = false;
            Done.Visible = false;
            not_done.Visible = false;
            combo_task.Visible = false;
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
            Done.Visible = false;
            not_done.Visible = false;
            combo_task.Visible = false;
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
            Done.Visible = false;
            not_done.Visible = false;
            combo_task.Visible = false;
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
            Done.Visible = false;
            not_done.Visible = false;
            combo_task.Visible = false;

        }

        private void mark_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            event_combo.Visible = false;
            choose_event.Visible = false;
            add_task.Visible = true;
            mark.Visible = true;
            label1.Visible = false;
            taskss.Visible = false;
            submit.Visible = false;
            Done.Visible = true;
            not_done.Visible = true;
            combo_task.Visible = true;
            DataTable dt = controllerobj.task(id);
            combo_task.DataSource = dt;
            combo_task.DisplayMember = "task";
            combo_task.ValueMember = "task_ID";
        }

        private void tasks_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (taskss.Text == "")
            {
                MessageBox.Show("Enter something to be inserted");
            }
            else
            {
                int count = controllerobj.get_count() + 1;

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

        private void choose_event_Click(object sender, EventArgs e)
        {
            int id1 = (int)event_combo.SelectedValue;
            employee_event ee = new employee_event(id1, id);
            ee.Show();
            this.Hide();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            controllerobj.Done((int)combo_task.SelectedValue);
            DataTable tasks = controllerobj.task(id);
            dataGridView1.DataSource = tasks;
            dataGridView1.Refresh();
        }

        private void not_done_Click(object sender, EventArgs e)
        {
            controllerobj.Not_yet((int)combo_task.SelectedValue);
            DataTable tasks = controllerobj.task(id);
            dataGridView1.DataSource = tasks;
            dataGridView1.Refresh();
        }

        private void event_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            message_employee f = new message_employee(id);
            f.Show();
            this.Hide();

        }

        private void combo_task_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
