using DataBase_project;
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
    public partial class client_newevent : Form
    {
        int id2;
        Controller cobj = new Controller();
        public client_newevent(int id)
        {
            InitializeComponent();

            this.id2 = id;

            DataTable dt = cobj.ShowTypes();
            typesofevents.DataSource = dt;
            typesofevents.DisplayMember = "event_type";
            //typesofevents.ValueMember = "types_ID";
            venuesDGview.Hide();
            venuess.Hide();
            back2.Hide();
            next.Hide();

        }
        public int GenerateRandomEmployee(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        int event_type;
        string event_date;
        int event_id=8;
        int client_budget;
        int no_of_attendees;
        int employee_id;
        private void themes_Click(object sender, EventArgs e)
        { 
            int client_budget= Convert.ToInt32(budget.Value);
            int no_of_attendees= Convert.ToInt32(capacity.Value);
            DataTable dt1 = cobj.ShowVeneus(no_of_attendees, client_budget);
            venuesDGview.DataSource = dt1;
            if (dt1 == null)
            {
                MessageBox.Show("no available venues within this capacity and budget");
            }
            else
            {
                back2.Show();
                next.Show();
                venuess.Show();
                venuesDGview.Show();
                venuesDGview.Refresh();
            }
            DataTable dt2 = cobj.ShowVeneusnames(no_of_attendees,client_budget);
            venuess.DataSource = dt2;
            venuess.DisplayMember = "venue_name";
            venuess.ValueMember = "venue_ID";
        }
     
        private void bachellorrette3_Click(object sender, EventArgs e)
        {
            //
        }

        private void back_Click(object sender, EventArgs e)
        {
            client_home c = new client_home(id2);
            c.Show();
            this.Hide();
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (typesofevents.Text == "Wedding") //wedding
            {
                event_type = 1;
            }
            else if (typesofevents.Text == "Bachelorette")
            {
                event_type = 6;
            }
            else if (typesofevents.Text == "Birthday Party") //birthday
            {
                event_type = 3;
            }
            else if (typesofevents.Text == "Engagement")
            {
                event_type = 4;
            }
            else if (typesofevents.Text == "Corporate Event")
            {
                event_type = 2;

            }
            else if (typesofevents.Text == "Charity Event")
            {
                event_type = 4;
            }
            event_id++;
            int client_budget = Convert.ToInt32(budget.Value);
            int no_of_attendees = Convert.ToInt32(capacity.Value);
            event_date = event_date_picker.Value.ToString("yyyy-MM-dd");
            employee_id= GenerateRandomEmployee(1,10);
            int venueid = Convert.ToInt32(venuess.SelectedValue);
            int s = cobj.InsertEvent(event_id, client_budget, event_type, event_date, employee_id, venueid, id2, no_of_attendees, eventname.Text);
            if (s != 0)
            {
                MessageBox.Show("event registered successfully");
            }
            else
            {
                MessageBox.Show("event failed.");
            }
        }
    }
}