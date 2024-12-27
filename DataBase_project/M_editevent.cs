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
           // evtypecombo.ValueMember = "types_ID";
            DataTable dt2 = c.venuesnames();
            venuecombo.DataSource = dt2;
            venuecombo.DisplayMember = "venue_name";
          //  venuecombo.ValueMember = "venue_ID";
            DataTable dt3 = c.Employeesnames();
            empcombo.DataSource = dt3;
            empcombo.DisplayMember = "name";
            //empcombo.ValueMember = "employee_ID";




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
            int id, id2, id3, id4;
            int result;
            //   int venueid = Convert.ToInt32(venuecombo.SelectedValue);
            string selectedvenue = venuecombo.SelectedItem.ToString();
            result = c.capacity(selectedvenue);
            Console.WriteLine(selectedvenue);

            string eventtype = evtypecombo.SelectedItem.ToString();
            int typeid = c.typeid(eventtype);
            Console.WriteLine(typeid);

            string employee = empcombo.SelectedItem.ToString();
            int empid = c.empid(employee);
            Console.WriteLine(empid);
            id3 = Convert.ToInt32(capacitytext.Text);


            if (eventidtext.Text == "" || budgettext.Text == "" || capacitytext.Text == "" || eventnametext.Text == "" || clienttext.Text == "" || evtypecombo.SelectedIndex == -1 || empcombo.SelectedIndex == -1 || venuecombo.SelectedIndex == -1 || cidtext.Text == "")
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
                string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                id = Convert.ToInt32(eventidtext.Text);
                id2 = Convert.ToInt32(budgettext.Text);
                id3 = Convert.ToInt32(capacitytext.Text);
                id4 = Convert.ToInt32(cidtext.Text);

                int r;
                r = c.insertevent(id, id2, typeid, date, empid, result, id4, id3, eventnametext.Text);
                if (r != 0)
                {
                    MessageBox.Show("Event added successfully");
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    }

