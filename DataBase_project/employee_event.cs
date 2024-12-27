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
    public partial class employee_event : Form
    {
        int event_id;
        int id2;
        Controller controllerobj;
        public employee_event(int ids, int idd)
        {
            InitializeComponent();
            controllerobj = new Controller();
            event_id = ids;
            id2 = idd;
            DataTable events = controllerobj.chosen(event_id, id2);
            event_details_GDview.DataSource = events;
            
        }

        private void employee_event_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            event_details_GDview.Refresh();
            DataTable events = controllerobj.invoice(event_id);
            event_details_GDview.DataSource = events;
        }

        private void back_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            employee_home ee = new employee_home(id2);
            ee.Show();
            this.Hide();
        }
    }
}
