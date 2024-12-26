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
        public employee_home(int val)
        {
            InitializeComponent();
            id = val; 

        }

        private void ScheduledEventsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The value of the integer is:" + id);
            e_scheduled_events ese = new e_scheduled_events(id);
            ese.Show();
            this.Hide();
        }

        private void TasksListButton_Click(object sender, EventArgs e)
        {
            e_taskslist etl = new e_taskslist(id);
            etl.Show();
            this.Hide();
        }

        private void VendorsButton_Click(object sender, EventArgs e)
        {
            e_vendors ev = new e_vendors();
            ev.Show();
        }

        private void employee_home_Load(object sender, EventArgs e)
        {

        }
    }
}
