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
    public partial class client_event : Form
    {
        int id1;
        public client_event(int id)
        {
            id1 = id;
            InitializeComponent();
            eventname.Visible = false;
            budget.Visible = false;
            eventname_tb.Visible =  false;
            budget_tb.Visible = false;
            date.Visible = false;
            dateTimePicker1.Visible = false;
            otherchanges.Visible = false;
            no_of_attendees_tb.Visible = false;
            no_of_attendees.Visible = false;
            cancel.Visible = false;
            back.Visible = true;
            done.Visible = false;
            editeventbutton.Visible = true;
            message.Visible = false;
            Controller c = new Controller();
            DataTable dt= c.ShowClientEvents(id);
            DataTable dt1 = c.ShowClientEventsNames(id);
            clientseventdatagridview.DataSource = dt;
            clientseventdatagridview.Refresh();
            eventscombobox.DataSource = dt1;
            eventscombobox.DisplayMember = "eventname";
            //eventscombobox.ValueMember = "event_type";
        }

        private void client_event_Load(object sender, EventArgs e)
        {

        }

        private void editeventbutton_Click(object sender, EventArgs e)
        {
            clientseventdatagridview.Visible=false;
            eventscombobox.Visible = false;
            sendfeedbackbutton.Visible = false;
            eventname.Visible = true;
            budget.Visible = true;
            eventname_tb.Visible = true;
            budget_tb.Visible = true;
            date.Visible = true;
            dateTimePicker1.Visible = true;
            otherchanges.Visible = true;
            no_of_attendees_tb.Visible = true;
            no_of_attendees.Visible = true;
            cancel.Visible = true;
            back.Visible = false;
            done.Visible = true;
            editeventbutton.Visible = false;
            message.Visible = true;
        }

        private void sendfeedbackbutton_Click(object sender, EventArgs e)
        {
            client_feedback c = new client_feedback(id1);
            c.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            client_home ch = new client_home(id1);
            ch.Show();
            this.Hide();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            clientseventdatagridview.Visible = true;
            eventscombobox.Visible = true;
            sendfeedbackbutton.Visible = true;
            eventname.Visible = false;
            budget.Visible = false;
            eventname_tb.Visible = false;
            budget_tb.Visible = false;
            date.Visible = false;
            dateTimePicker1.Visible = false;
            otherchanges.Visible = false;
            no_of_attendees_tb.Visible = false;
            no_of_attendees.Visible = false;
            cancel.Visible = false;
            back.Visible = true;
            done.Visible = false;
            editeventbutton.Visible = true;
            message.Visible = false;
        }

        private void done_Click(object sender, EventArgs e)
        {

        }
    }
}
