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
    public partial class e_scheduled_events : Form
    {
        int id2;
        Controller controllerobj;
        public e_scheduled_events(int val)
        {
            controllerobj = new Controller();
            InitializeComponent();
            DataTable events = controllerobj.sch_events(val);
            dataGridView1.DataSource= events;
            event_combo.DataSource = events;
            event_combo.DisplayMember = "eventname";
            event_combo.ValueMember = "event_ID";


        }

        private void e_scheduled_events_Load(object sender, EventArgs e)
        {

        }

        private void choose_event_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
