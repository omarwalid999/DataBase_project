using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataBase_project
{
    public partial class client_home : Form
    {
        int id1;
        Controller c = new Controller();
        int event_type;
        string event_date;
        int client_budget;
        int no_of_attendeess;
        int event_id = 8;
        
      
        int employee_id;
        public client_home(int id)
        {

            InitializeComponent();
            id1 = id;
            cancell.Visible = false;
            eventscombobox.Visible = false;
            name.Visible = false;
            budget_label.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            label4.Visible = false;
            venues.Visible = false;
            venuess.Visible = false;
            event_date_picker.Visible = false;
            typesofevents.Visible = false;
            capacity.Visible = false;
            budgett.Visible = false;
            textBox1.Visible = false;
            venuesDGview.Visible = false;
            next.Visible = false;
            back2.Visible = false;
            sendfeedbackbutton.Visible = false; 
            done.Visible = false;
            editeventbutton.Visible = false;
            cancell.Visible = false;
            cancel.Visible = false;
            nextt.Visible = false;




        }

        private void client_home_Load(object sender, EventArgs e)
        {
            int notif_count = c.get_client_notif(id1);
            if (notif_count > 0)
            {
                notifications_count.Text = notif_count.ToString();
            }
            else
            {
                notifications_count.Hide();
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            login cl = new login();
            cl.Show();
            this.Hide();
        }
        public int GenerateRandomEmployee(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        private void venues_Click(object sender, EventArgs e)
        {
            client_budget = Convert.ToInt32(budgett.Value);
            no_of_attendeess = Convert.ToInt32(capacity.Value);
            DataTable dt1 = c.ShowVeneus(no_of_attendeess, client_budget);
            venuesDGview.DataSource = dt1;
            if (dt1 == null)
            {
                MessageBox.Show("no available venues within this capacity and budget");
            }
            else
            {
                next.Show();
                venuess.Show();
                venuesDGview.Show();
                venuesDGview.Refresh();
            }
           
            venuess.DataSource = dt1;
            venuess.DisplayMember = "venue";
            venuess.ValueMember = "venue_ID";
        }

        private void NewEvent_Click(object sender, EventArgs e)
        {
            int no_of_attendeess = Convert.ToInt32(capacity.Value);

            DataTable dt = c.ShowTypes();
            typesofevents.DataSource = dt;
            typesofevents.DisplayMember = "event_type";
            //typesofevents.ValueMember = "types_ID";
            venuesDGview.Hide();
            venuess.Hide();
            name.Visible = true;
            budget_label.Visible = true;
            label3.Visible = true;
            label5.Visible = true;
            label4.Visible = true;
            venues.Visible = true;
            venuess.Visible = true;
            next.Visible = true;
            event_date_picker.Visible = true;
            typesofevents.Visible = true;
            capacity.Visible = true;
            budgett.Visible = true;
            textBox1.Visible = true;
            venuesDGview.Visible = true;
            comment.Visible = false;
            comment_tb.Visible = false;
            label2.Visible = false;
            dateTimePickerof_feedback.Visible = false;
            rating.Visible = false;
            cancell.Visible = false;
            submit.Visible = false;
            ratingnumericUpDown1.Visible = false;
            clientseventdatagridview.Visible = false;
            eventname.Visible = false;
            budget.Visible = false;
            eventname_tb.Visible = false;
            budget_tb.Visible = false;
            date.Visible = false;
            eventdateTimePicker.Visible = false;
            otherchanges.Visible = false;
            no_of_attendees_tb.Visible = false;
            no_of_attendees.Visible = false;
            cancel.Visible = false;
            back.Visible = false;
            done.Visible = false;
            editeventbutton.Visible = false;
            message.Visible = false;
            cancell.Visible = false;
            back2.Visible = true;
            done.Visible = false;
            editeventbutton.Visible = false;
            cancell.Visible = false;
            eventscombobox.Visible = false;
            nextt.Visible = true;
            sendfeedbackbutton.Visible = false;
            DataTable dt2 = c.ShowVeneusnames(no_of_attendeess, client_budget);
            venuess.DataSource = dt2;
            venuess.DisplayMember = "venue";
            venuess.ValueMember = "venue_ID";
        }

        private void events_Click(object sender, EventArgs e)
        {
            eventscombobox.Visible = true;
            done.Visible = true;
            editeventbutton.Visible = true;
            cancell.Visible = true;
            next.Visible = false;
            name.Visible = false;
            budget_label.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            label4.Visible = false;
            venues.Visible = false;
            venuess.Visible = false;
            event_date_picker.Visible = false;
            typesofevents.Visible = false;
            capacity.Visible = false;
            budgett.Visible = false;
            textBox1.Visible = false;
            venuesDGview.Visible = false;
            comment.Visible = false;
            comment_tb.Visible = false;
            label2.Visible = false;
            dateTimePickerof_feedback.Visible = false;
            rating.Visible = false;
            cancell.Visible = false;
            submit.Visible = false;
            ratingnumericUpDown1.Visible = false;
            clientseventdatagridview.Visible = true;
            eventname.Visible = false;
            budget.Visible = false;
            eventname_tb.Visible = false;
            budget_tb.Visible = false;
            date.Visible = false;
            eventdateTimePicker.Visible = false;
            otherchanges.Visible = false;
            no_of_attendees_tb.Visible = false;
            no_of_attendees.Visible = false;
            cancel.Visible = false;
            back.Visible = true;
            done.Visible = false;
            editeventbutton.Visible = true;
            message.Visible = false;
            cancell.Visible = false;
            back2.Visible = false;
            sendfeedbackbutton.Visible = true;
            eventscombobox.Visible = true;
            nextt.Visible = false;
            DataTable dt = c.ShowClientEvents(id1);
            DataTable dt1 = c.ShowClientEventsNames(id1);
            clientseventdatagridview.DataSource = dt;
            clientseventdatagridview.Refresh();
            eventscombobox.DataSource = dt1;
            eventscombobox.DisplayMember = "eventname";
            
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            message_client m = new message_client(id1);
            m.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            
        }

        private void done_Click(object sender, EventArgs e)
        {
            if (eventname_tb.Text != "" && budget_tb.Text != "" && no_of_attendees_tb.Text != "")
            {
                string date = eventdateTimePicker.Value.ToString("yyyy-MM-dd");
                int g = c.change_event_details(id1, eventname_tb.Text, Convert.ToInt32(budget_tb.Text), Convert.ToInt32(no_of_attendees_tb.Text), date);
                if (g != 0)
                {
                    MessageBox.Show("event updated successfully");
                }
                else
                {
                    MessageBox.Show("update failed.");
                }
            }
        }

        private void message_Click(object sender, EventArgs e)
        {
            message_client m = new message_client(id1);
            m.Show();
            this.Hide();
        }

        //private void pictureBox2_Click(object sender, EventArgs e)
        //{
        //    client_home ch = new client_home(id1);
        //    ch.Show();
        //    this.Hide();

        //}

        private void cancel_Click(object sender, EventArgs e)
        {
            next.Visible = false;
            name.Visible = false;
            budget_label.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            label4.Visible = false;
            venues.Visible = false;
            venuess.Visible = false;
            event_date_picker.Visible = false;
            typesofevents.Visible = false;
            capacity.Visible = false;
            budgett.Visible = false;
            textBox1.Visible = false;
            venuesDGview.Visible = false;
            comment.Visible = false;
            comment_tb.Visible = false;
            label2.Visible = false;
            dateTimePickerof_feedback.Visible = false;
            rating.Visible = false;
            cancell.Visible = false;
            submit.Visible = false;
            ratingnumericUpDown1.Visible = false;
            clientseventdatagridview.Visible = true;
            eventscombobox.Visible = true;
            sendfeedbackbutton.Visible = true;
            eventname.Visible = false;
            budget.Visible = false;
            eventname_tb.Visible = false;
            budget_tb.Visible = false;
            date.Visible = false;
            eventdateTimePicker.Visible = false;
            otherchanges.Visible = false;
            no_of_attendees_tb.Visible = false;
            no_of_attendees.Visible = false;
            cancel.Visible = false;
            back.Visible = true;
            done.Visible = false;
            editeventbutton.Visible = true;
            message.Visible = false;
            back2.Visible = false;
            eventscombobox.Visible = true;
            nextt.Visible = false;

        }

        private void eventscombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editeventbutton_Click(object sender, EventArgs e)
        {
            next.Visible = false;
            name.Visible = false;
            budget_label.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            label4.Visible = false;
            venues.Visible = false;
            venuess.Visible = false;
            event_date_picker.Visible = false;
            typesofevents.Visible = false;
            capacity.Visible = false;
            budgett.Visible = false;
            textBox1.Visible = false;
            venuesDGview.Visible = false;
            comment.Visible = false;
            comment_tb.Visible = false;
            label2.Visible = false;
            dateTimePickerof_feedback.Visible = false;
            rating.Visible = false;
            cancell.Visible = false;
            submit.Visible = false;
            ratingnumericUpDown1.Visible = false;
            clientseventdatagridview.Visible = false;
            eventscombobox.Visible = false;
            sendfeedbackbutton.Visible = false;
            eventname.Visible = true;
            budget.Visible = true;
            eventname_tb.Visible = true;
            budget_tb.Visible = true;
            date.Visible = true;
            eventdateTimePicker.Visible = true;
            otherchanges.Visible = true;
            no_of_attendees_tb.Visible = true;
            no_of_attendees.Visible = true;
            cancel.Visible = true;
            back.Visible = false;
            done.Visible = true;
            editeventbutton.Visible = false;
            message.Visible = true;
            back2.Visible = false;
            nextt.Visible = false;

        }

        private void sendfeedbackbutton_Click(object sender, EventArgs e)
        {
            next.Visible = false;
            name.Visible = false;
            budget_label.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            label4.Visible = false;
            venues.Visible = false;
            venuess.Visible = false;
            event_date_picker.Visible = false;
            typesofevents.Visible = false;
            capacity.Visible = false;
            budgett.Visible = false;
            textBox1.Visible = false;
            venuesDGview.Visible = false;
            comment.Visible = true;
            comment_tb.Visible= true;
            label2.Visible = true;
            dateTimePickerof_feedback.Visible = true;
            rating.Visible = true;
            cancell.Visible = true;
            submit.Visible = true;
            ratingnumericUpDown1.Visible = true;
            clientseventdatagridview.Visible = false;
            eventname.Visible = false;
            budget.Visible = false;
            eventname_tb.Visible = false;
            budget_tb.Visible = false;
            date.Visible = false;
            eventdateTimePicker.Visible = false;
            otherchanges.Visible = false;
            no_of_attendees_tb.Visible = false;
            no_of_attendees.Visible = false;
            cancel.Visible = false;
            back.Visible = true;
            done.Visible = false;
            editeventbutton.Visible = true;
            message.Visible = false;
            back2.Visible = false;
            eventscombobox.Visible = false;
            nextt.Visible = false;
            //client_feedback c = new client_feedback(id1);
            //c.Show();
            //this.Hide();
        }

        private void ratingnumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cancell_Click(object sender, EventArgs e)
        {
            next.Visible = false;
            name.Visible = false;
            budget_label.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            label4.Visible = false;
            venues.Visible = false;
            venuess.Visible = false;
            event_date_picker.Visible = false;
            typesofevents.Visible = false;
            capacity.Visible = false;
            budgett.Visible = false;
            textBox1.Visible = false;
            venuesDGview.Visible = false;
            comment.Visible = false;
            comment_tb.Visible = false;
            label2.Visible = false;
            dateTimePickerof_feedback.Visible = false;
            rating.Visible = false;
            cancell.Visible = false;
            submit.Visible = false;
            ratingnumericUpDown1.Visible = false;
            clientseventdatagridview.Visible = true;
            eventname.Visible = false;
            budget.Visible = false;
            eventname_tb.Visible = false;
            budget_tb.Visible = false;
            date.Visible = false;
            eventdateTimePicker.Visible = false;
            otherchanges.Visible = false;
            no_of_attendees_tb.Visible = false;
            no_of_attendees.Visible = false;
            cancel.Visible = false;
            back.Visible = true;
            done.Visible = false;
            editeventbutton.Visible = true;
            message.Visible = false;
            cancell.Visible = false;
            back2.Visible = false;
            nextt.Visible = false;
            eventscombobox.Visible = true;
            DataTable dt = c.ShowClientEvents(id1);
            DataTable dt1 = c.ShowClientEventsNames(id1);
            clientseventdatagridview.DataSource = dt;
            clientseventdatagridview.Refresh();
            eventscombobox.DataSource = dt1;
            eventscombobox.DisplayMember = "eventname";
            
        }

       
        private void venuesDGview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nextt_Click(object sender, EventArgs e)
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
            client_budget = Convert.ToInt32(budgett.Value);
            no_of_attendeess = Convert.ToInt32(capacity.Value);
            event_date = event_date_picker.Value.ToString("yyyy-MM-dd");
            employee_id = GenerateRandomEmployee(1, 10);
            int venueid = Convert.ToInt32(venuess.SelectedValue);
            int s = c.InsertEvent(event_id, client_budget, event_type, event_date, employee_id, venueid, id1, no_of_attendeess, eventname.Text);
            if (s != 0)
            {
                MessageBox.Show("event registered successfully");
            }
            else
            {
                MessageBox.Show("event failed.");
            }
        }

        private void clientseventdatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void back2_Click(object sender, EventArgs e)
        {
            client_home c = new client_home(id1);
            c.Show();
            this.Hide();
        }

        private void venuess_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            int feedbackid = 50;
            string date = dateTimePickerof_feedback.Value.ToString("yyyy-MM-dd");
            feedbackid++;
            if (comment.Text != " " && comment.Text != "")
            {
                feedbackid++;
                int s = c.InsertFeedback(feedbackid, id1, comment_tb.ToString(), date, Convert.ToInt32(ratingnumericUpDown1.Value));
                if (s != 0)
                {
                    MessageBox.Show("Feedback registered successfully");
                }
                else
                {
                    MessageBox.Show("Feedback failed.");
                }
            }
            else
            {
                MessageBox.Show("you can't submit an empty feedback.");
            }
        }

        private void notifications_count_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            client_home c = new client_home(id1);
            c.Show();
            this.Hide();
        }

        private void notif_Click(object sender, EventArgs e)
        {
            client_notifications c = new client_notifications(id1);
            c.Show();
            this.Hide();
        }
        //momken neshil previous events w nezawed fi my events button feedback
    }
}
