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
        public AddEvent()
        {
            InitializeComponent();
            c=new Controller();
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
            empcombo.DisplayMember = "fname";
            empcombo.ValueMember = "employee_ID";
        }

        private void button1_Click(object sender, EventArgs e)
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
            string date = datetext.Text;
         
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
            else if (datetext.Text!="")
            {
                if (DateTime.TryParse(date, out DateTime validdate))
                {
                    if (validdate < DateTime.Now)
                    {
                        MessageBox.Show("This date is in the past");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid date");
                }
               

            }
            
            else
            {
                int r;
                r = c.insertevent(id, id2, eventtype, date, emp, venueid, id4, id3, eventnametext.Text);
                if (r != 0)
                {
                    MessageBox.Show("Event added successfully");
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
            M_Events ev2 = new M_Events();
            ev2.Show();
            this.Hide();
        }
    }
    }
    
