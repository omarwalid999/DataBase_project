using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DataBase_project
{
    public partial class AddEvent : Form
    {
        Controller c;
        int manager_id;
        public AddEvent(int id)
        {
            InitializeComponent();
            c=new Controller();
            manager_id=id;
   
            DataTable dt = c.typesnames();
            evtypecombo.DataSource = dt;
            evtypecombo.DisplayMember = "event_type";
            evtypecombo.ValueMember = "types_ID";
            DataTable dt2 = c.venuesnames();
            venuecombo.DataSource = dt2;
            venuecombo.DisplayMember = "venue_name";
            venuecombo.ValueMember = "venue_ID";
            DataTable dt3=c.Employeesnames();
            empcombo.DataSource = dt3;
            empcombo.DisplayMember = "name";
            empcombo.ValueMember = "employee_ID";
            DataTable dt4 = c.clientnames();

            client_combobox.DataSource = dt4;
            client_combobox.DisplayMember = "name";
            client_combobox.ValueMember = "client_ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check that event_id unique
            //eventname string
            //budget w no of attendees numbers

          
            int venue_id = Convert.ToInt32(venuecombo.SelectedValue); //venue
            int typeid = Convert.ToInt32(evtypecombo.SelectedValue); //type
            int empid = Convert.ToInt32(empcombo.SelectedValue);//employee
            int budget = Convert.ToInt32(budgettext.Text.ToString());//budget
            int capacity = Convert.ToInt32(capacitytext.Text.ToString());//capacity
            int eventid = Convert.ToInt32(eventidtext.Text);//eventid
            string eventname = eventnametext.Text;
            int venue_cap = c.capacity(venue_id);

            if (eventidtext.Text == "" || budgettext.Text == "" || capacitytext.Text == "" || eventnametext.Text == "")
            {
                MessageBox.Show("Please enter all required fields");
            }
            else if (!int.TryParse(eventidtext.Text, out eventid) || !int.TryParse(budgettext.Text, out budget) || !int.TryParse(capacitytext.Text, out capacity))
            {
                MessageBox.Show("Invalid value ");

            }
            else if (venue_cap < capacity)
            {
                MessageBox.Show(" The number of attendees exceeds this venue's capacity");
            }
            else
            {
                string date = eventdate.Value.ToString("yyyy-MM-dd");
                int r;

                r = c.InsertEvent(eventid, budget, typeid, date, empid, venue_id, Convert.ToInt32(client_combobox.SelectedValue), capacity, eventname);
                if (r != 0)
                {
                    MessageBox.Show("Event added successfully");
                } else
                {
                    MessageBox.Show("failed to add event");
                }
            }
        }

               

             

        private void evtypecombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void venuecombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void empcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void back9_Click(object sender, EventArgs e)
        {
            M_Events ev2 = new M_Events(manager_id);
            ev2.Show();
            this.Hide();
        }

        private void eventdate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    }
    

