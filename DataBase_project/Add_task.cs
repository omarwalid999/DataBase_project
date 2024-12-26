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
    public partial class Add_task : Form
    {
        int val;
        Controller controllerobj;
        public Add_task(int id)
        {
            val = id;
            InitializeComponent();
            controllerobj = new Controller();

        }

        private void Add_task_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            int count=controllerobj.get_count();
            string stat = "Not Yet";
            int result=controllerobj.insert_task(count, tasks.Text, stat, val);
            if (result == 0)
            {
                MessageBox.Show("Error in insertion");
            }
            else
            {
                MessageBox.Show("The row isinsertedsuccessfully!");
            }


        }
    }
}
