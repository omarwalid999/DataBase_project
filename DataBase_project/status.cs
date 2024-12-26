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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataBase_project
{
    public partial class status : Form
    {
        Controller controllerobj;
        int val;
        public status(int id)
        {
            
            val= id;
            InitializeComponent();
            controllerobj = new Controller();
            DataTable dt = controllerobj.task(id);
            combo_task.DataSource = dt;
            combo_task.DisplayMember = "task";
            combo_task.ValueMember = "task_ID";
        }

        private void status_Load(object sender, EventArgs e)
        {

        }

        private void Done_Click(object sender, EventArgs e)
        {
            controllerobj.Done((int)combo_task.SelectedValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            e_taskslist f = new e_taskslist(val);
            f.Show();
            this.Hide();
        }

        private void not_done_Click(object sender, EventArgs e)
        {
            controllerobj.Not_yet((int)combo_task.SelectedValue);

        }
    }
}
