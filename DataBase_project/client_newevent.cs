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
            hotelwedding.Visible = false;
            beachwedding.Visible = false;
            gardenwedding.Visible = false;
            bachellorrette1.Visible = false;
            bachellorrette2.Visible = false;
            bachellorrette3.Visible = false;
        }

        private void themes_Click(object sender, EventArgs e)
        {
            if (typesofevents.Text == "Wedding") //wedding
            {
                hotelwedding.Visible = true;
                beachwedding.Visible = true;
                gardenwedding.Visible= true;
            }
            if (typesofevents.Text == "Bachelorette") //wedding
            {
                bachellorrette1.Visible = true;
                bachellorrette2.Visible = true;
                bachellorrette3.Visible = true;
            }
        }

        private void bachellorrette3_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
