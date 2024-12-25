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
        public employee_home()
        {
            InitializeComponent();
        }

        private void ScheduledEventsButton_Click(object sender, EventArgs e)
        {
            e_scheduled_events ese = new e_scheduled_events();
            ese.Show();
        }

        private void TasksListButton_Click(object sender, EventArgs e)
        {
            e_taskslist etl = new e_taskslist();
            etl.Show();
        }

        private void VendorsButton_Click(object sender, EventArgs e)
        {
            e_vendors ev = new e_vendors();
            ev.Show();
        }
    }
}
