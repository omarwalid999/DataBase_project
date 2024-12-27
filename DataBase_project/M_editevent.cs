﻿using DBapplication;
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
            eventinfoview.Refresh();

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
            empcombo.DisplayMember = "name";
            empcombo.ValueMember = "employee_ID";
            DataTable dt5 = c.clientnames();

            client_combobox.DataSource = dt5;
            client_combobox.DisplayMember = "name";
            client_combobox.ValueMember = "client_ID";



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
            int venue_id = Convert.ToInt32(venuecombo.SelectedValue); //venue
            int typeid = Convert.ToInt32(evtypecombo.SelectedValue); //type
            int empid = Convert.ToInt32(empcombo.SelectedValue);//employee
            int budget = Convert.ToInt32(budgettext.Text.ToString());//budget
            int capacity = Convert.ToInt32(capacitytext.Text.ToString());//capacity
            
            string eventname = eventnametext.Text;
            int venue_cap = c.capacity(venue_id);

            if (budgettext.Text == "" || capacitytext.Text == "" || eventnametext.Text == "")
            {
                MessageBox.Show("Please enter all required fields");
            }
            else if (!int.TryParse(budgettext.Text, out budget) || !int.TryParse(capacitytext.Text, out capacity))
            {
                MessageBox.Show("Invalid value ");

            }
            else if (venue_cap < capacity)
            {
                MessageBox.Show(" The number of attendees exceeds this venue's capacity");
            }
            else
            {
                string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                int r;

                r = c.UpdateEvent(eventid,budget, typeid, date, empid, venue_id, Convert.ToInt32(client_combobox.SelectedValue), capacity, eventname);
                if (r != 0)
                {
                    MessageBox.Show("Event updated successfully");
                }
                else
                {
                    MessageBox.Show("failed to update event");
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

