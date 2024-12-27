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
        public client_newevent(int id)
        {
            InitializeComponent();
            
            this.id2 = id;
            Controller cobj = new Controller();
            DataTable dt = cobj.ShowTypes();
            typesofevents.DataSource = dt;
            typesofevents.DisplayMember = "event_type";
            //typesofevents.ValueMember = "types_ID";
            
        }

        private void typesofevents_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void client_newevent_Load(object sender, EventArgs e)
        {
            //kolo hidden
            hotelwedding.Visible = false;
            beachwedding.Visible = false;
            gardenwedding.Visible = false;
            bachellorrette1.Visible = false;
            bachellorrette2.Visible = false;
            bachellorrette3.Visible = false;
            birthday1.Visible = false;
            birthday2.Visible = false;
            birthday3.Visible = false;
            corporate1.Visible = false;
            corporate2.Visible = false;
            corporate3.Visible = false;
            engagement1.Visible = false;
            engagement2.Visible = false;
            engagement3.Visible = false;
            charity1.Visible = false;
            charity2.Visible = false;
            charity3.Visible = false;
        }

        private void themes_Click(object sender, EventArgs e)
        {
            if (typesofevents.Text == "Wedding") //wedding
            {
                //wedding true
                hotelwedding.Visible = true;
                beachwedding.Visible = true;
                gardenwedding.Visible= true;
                //ba2y falsse
                bachellorrette1.Visible = false;
                bachellorrette2.Visible = false;
                bachellorrette3.Visible = false;
                birthday1.Visible = false;
                birthday2.Visible = false;
                birthday3.Visible = false;
                corporate1.Visible = false;
                corporate2.Visible = false;
                corporate3.Visible = false;
                engagement1.Visible = false;
                engagement2.Visible = false;
                engagement3.Visible = false;
                charity1.Visible = false;
                charity2.Visible = false;
                charity3.Visible = false;
            }
            else if (typesofevents.Text == "Bachelorette") 
            {
                //bachellorette tru
                bachellorrette1.Visible = true;
                bachellorrette2.Visible = true;
                bachellorrette3.Visible = true;
                //ba2y false
                hotelwedding.Visible = false;
                beachwedding.Visible = false;
                gardenwedding.Visible = false;
                birthday1.Visible = false;
                birthday2.Visible = false;
                birthday3.Visible = false;
                corporate1.Visible = false;
                corporate2.Visible = false;
                corporate3.Visible = false;
                engagement1.Visible = false;
                engagement2.Visible = false;
                engagement3.Visible = false;
                charity1.Visible = false;
                charity2.Visible = false;
                charity3.Visible = false;
            }
            else if (typesofevents.Text == "Birthday Party") //birthday
            {
                //birthday true
                birthday1.Visible = true;
                birthday2.Visible = true;
                birthday3.Visible = true;
                //ba2y false
                hotelwedding.Visible = false;
                beachwedding.Visible = false;
                gardenwedding.Visible = false;
                bachellorrette1.Visible = false;
                bachellorrette2.Visible = false;
                bachellorrette3.Visible = false;
                corporate1.Visible = false;
                corporate2.Visible = false;
                corporate3.Visible = false;
                engagement1.Visible = false;
                engagement2.Visible = false;
                engagement3.Visible = false;
                charity1.Visible = false;
                charity2.Visible = false;
                charity3.Visible = false;
            }
            else if (typesofevents.Text== "Engagement")
            {
                //engagement pics
                engagement1.Visible = true;
                engagement2.Visible = true;
                engagement3.Visible = true;
                //ba2y false
                hotelwedding.Visible = false;
                beachwedding.Visible = false;
                gardenwedding.Visible = false;
                bachellorrette1.Visible = false;
                bachellorrette2.Visible = false;
                bachellorrette3.Visible = false;
                birthday1.Visible = false;
                birthday2.Visible = false;
                birthday3.Visible = false;
                corporate1.Visible = false;
                corporate2.Visible = false;
                corporate3.Visible = false;
                charity1.Visible = false;
                charity2.Visible = false;
                charity3.Visible = false;
            }
            else if(typesofevents.Text== "Corporate Event")
            {
                //corporate pics
                corporate1.Visible = true;
                corporate2.Visible = true;
                corporate3.Visible = true;
                //ba2i false
                hotelwedding.Visible = false;
                beachwedding.Visible = false;
                gardenwedding.Visible = false;
                bachellorrette1.Visible = false;
                bachellorrette2.Visible = false;
                bachellorrette3.Visible = false;
                birthday1.Visible = false;
                birthday2.Visible = false;
                birthday3.Visible = false;
                engagement1.Visible = false;
                engagement2.Visible = false;
                engagement3.Visible = false;
                charity1.Visible = false;
                charity2.Visible = false;
                charity3.Visible = false;
            }
            else if (typesofevents.Text == "Charity Event")
            {
                //charity pics
                charity1.Visible = true;
                charity2.Visible = true;
                charity3.Visible = true;
                //ba2i false
                corporate1.Visible = false;
                corporate2.Visible = false;
                corporate3.Visible = false;
                hotelwedding.Visible = false;
                beachwedding.Visible = false;
                gardenwedding.Visible = false;
                bachellorrette1.Visible = false;
                bachellorrette2.Visible = false;
                bachellorrette3.Visible = false;
                birthday1.Visible = false;
                birthday2.Visible = false;
                birthday3.Visible = false;
                engagement1.Visible = false;
                engagement2.Visible = false;
                engagement3.Visible = false;
            }
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
            //check themepicker
            //check which type
            //save them 
            if (typesofevents.Text == "Wedding") //wedding
            {
             if(themepicker.Value == 1)
                {

                } 
             else if(themepicker.Value == 2)
                {

                }
                else if (themepicker.Value == 3)
                {

                }
            }
            else if (typesofevents.Text == "Bachelorette") 
            {
                if (themepicker.Value == 1)
                {

                }
                else if (themepicker.Value == 2)
                {

                }
                else if (themepicker.Value == 3)
                {

                }
            }
            else if (typesofevents.Text == "Birthday Party") 
            {
                if (themepicker.Value == 1)
                {

                }
                else if (themepicker.Value == 2)
                {

                }
                else if (themepicker.Value == 3)
                {

                }
            }
            else if (typesofevents.Text == "Engagement")
            {
                if (themepicker.Value == 1)
                {
                    //home ballons w kda setup
                }
                else if (themepicker.Value == 2)
                {
                    //garden
                }
                else if (themepicker.Value == 3)
                {
                    //home tarabiza
                }
            }
            else if (typesofevents.Text == "Corporate Event")
            {
                if (themepicker.Value == 1)
                {

                }
                else if (themepicker.Value == 2)
                {

                }
                else if (themepicker.Value == 3)
                {

                }
            }
            else if (typesofevents.Text == "Charity Event")
            {
                if (themepicker.Value == 1)
                {
                    //ballroom
                }
                else if (themepicker.Value == 2)
                {
                    //marathon
                }
                else if (themepicker.Value == 3)
                {
                    //red carpet
                }
            }
        }
    }
}
//nerouh nekhtar elbudget w elcapacity w date
//el venue
