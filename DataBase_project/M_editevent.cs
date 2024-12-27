using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_project
{
    public partial class M_editevent : Form
    {
        Controller c;
        int eventid;
        public M_editevent(int id)
        {
            eventid = id;
            InitializeComponent();
            c = new Controller();
            DataTable dt4=c.eventinfo(eventid);
            eventinfoview.DataSource = dt4;
            DataTable dt = c.typesnames();
            evtypecombo.DataSource = dt;
            evtypecombo.DisplayMember = "event_type";
            evtypecombo.ValueMember = "types_ID";
            DataTable dt2 = c.venuesnames();
            venuecombo.DataSource = dt2;
            venuecombo.DisplayMember = "venue_name";
            venuecombo.ValueMember = "venue_ID";
            DataTable dt3 = c.Employeesnames();
            empcombo.DataSource = dt3;
            empcombo.DisplayMember = "fname";
            empcombo.ValueMember = "employee_ID";




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editevent_Click(object sender, EventArgs e)
        {
            
        }

        private void M_editevent_Load(object sender, EventArgs e)
        {

        }

        private void evtypecombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addevent_Click(object sender, EventArgs e)
        {
        }

        private void updatevent_Click(object sender, EventArgs e)
        {
            int id;
            int id2;
            int id3;
            int id4;
            int result;
            int venueid = (int)venuecombo.SelectedValue;
            result = c.capacity(venueid);
            int eventtype = (int)evtypecombo.SelectedValue;
            int emp = (int)empcombo.SelectedValue;
            if (eventidtext.Text == "" || datetext.Text == "" || budgettext.Text == "" || capacitytext.Text == "" || eventnametext.Text == "" || clienttext.Text == "" || evtypecombo.SelectedIndex == -1 || empcombo.SelectedIndex == -1 || venuecombo.SelectedIndex == -1 || cidtext.Text == "")
            {
                MessageBox.Show("Please enter all required fields");
            }
            else if (!int.TryParse(eventidtext.Text, out id) || !int.TryParse(budgettext.Text, out id2) || !int.TryParse(capacitytext.Text, out id3) || !int.TryParse(cidtext.Text, out id4))
            {
                MessageBox.Show("Invalid value ");

            }
            else if (result < id3)
            {
                MessageBox.Show(" The number of attendees exceeds this venue's capacity");
            }
            else if (!clienttext.Text.All(c => char.IsLetter(c)))

            {

                MessageBox.Show("Please Enter valid name");
            }
            else
            {
                int r;
                r = c.updatevent(id, id2, eventtype, datetext.Text, emp, venueid, id4, id3, eventnametext.Text);
                if (r != 0)
                {
                    MessageBox.Show("Event updated successfully");
                    eventinfoview.Refresh();
                }
            }
        }
        

        private void back8_Click(object sender, EventArgs e)
        {
            M_Events ev=new M_Events();
            ev.Show();
            this.Hide();
        }

        private void eventinfoview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

