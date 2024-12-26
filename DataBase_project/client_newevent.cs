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
            hotelbox1.Hide();
            beachbox1.Hide();
            this.id2 = id;
            Controller cobj = new Controller();
            DataTable dt = cobj.ShowTypes();
            typesofevents.DataSource = dt;
            typesofevents.DisplayMember = "event_type";
            typesofevents.ValueMember = "types_ID";
        }

        private void typesofevents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(typesofevents.SelectedIndex == 1) //wedding
            {
                hotelbox1.Show();
                beachbox1.Show();
            }
        }

        private void client_newevent_Load(object sender, EventArgs e)
        {

        }
    }
}
