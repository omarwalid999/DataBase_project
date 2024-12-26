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
    public partial class e_taskslist : Form
    {
        int val;
        Controller controllerobj;
        public e_taskslist(int id)
        {
            val = id;
            controllerobj = new Controller();
            InitializeComponent();
            DataTable tasks = controllerobj.task(val);
            dataGridView1.DataSource = tasks;

        }

        private void e_taskslist_Load(object sender, EventArgs e)
        {

        }

        private void mark_Click(object sender, EventArgs e)
        {
            status f = new status(val);
            f.Show();
            this.Hide();   
            dataGridView1.Refresh();
        }

        private void add_task_Click(object sender, EventArgs e)
        {
            Add_task f = new Add_task(val);
            f.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
