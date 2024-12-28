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
            DataTable events = controllerobj.chosen(event_id);
            event_details_GDview.DataSource = events;
            comboBox1.Visible = false;
            button1.Visible = false;
            
        }

        private void employee_event_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            comboBox1.Visible = false;
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

        private void edit_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            comboBox1.Visible = true;
            DataTable events = controllerobj.get_venue();
            comboBox1.DataSource = events;
            comboBox1.DisplayMember = "venue_name";
            comboBox1.ValueMember = "venue_ID";
            event_details_GDview.Refresh();
            DataTable eventss = controllerobj.chosen(event_id);
            event_details_GDview.DataSource = eventss;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllerobj.change_venue(comboBox1.Text, (int)comboBox1.SelectedValue, event_id);
            event_details_GDview.Refresh();
            DataTable eventss = controllerobj.chosen(event_id);
            event_details_GDview.DataSource = eventss;
        }

        //private void button2_Click_1(object sender, EventArgs e)
        //{
        //    inv ee = new inv(id2);
        //    ee.Show();
            
        //}
    }
}
