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
    public partial class M_Events : Form
    {
        Controller c;
        public M_Events()
        {
            InitializeComponent();
            c=new Controller();
            DataTable dt = c.AllEvents();
            alleventsview.DataSource = dt;
            
           
            DataTable dt2 = c.EventsList();
            eventscombo.DataSource = dt2;
            eventscombo.DisplayMember = "eventname";
            //eventscombo.ValueMember = "event_ID";
        }

        private void alleventsview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void M_Events_Load(object sender, EventArgs e)
        {
           
        }

        private void edit_Click(object sender, EventArgs e)
        {
            string selectedevent=eventscombo.SelectedItem.ToString();
            int eventid=c.eventid(selectedevent);
            M_editevent m_Editevent = new M_editevent(eventid);
            m_Editevent.Show();
            this.Hide();
        }

        private void eventscombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void back7_Click(object sender, EventArgs e)
        {
            Manager_home M4= new Manager_home();
            M4.Show();
            this.Hide();

        }

        private void deletevent_Click(object sender, EventArgs e)
        {
            int eventid=(int)eventscombo.SelectedValue;
            int result;
            result=c.deleteevent(eventid);
            if (result != 0)
            {
                MessageBox.Show("Event deleted successfully");
               
            }

        }

        private void addevent_Click(object sender, EventArgs e)
        {
            AddEvent a=new AddEvent();
            a.Show();
            this.Hide();
        }
    }
}
