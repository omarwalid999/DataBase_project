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
    public partial class AllClients : Form
    {
        Controller c;
        public AllClients()
        {
            InitializeComponent();
            c = new Controller();
            DataTable dt = c.allclients();
            allclientsview.DataSource = dt;
            allclientsview.Refresh();
            DataTable dt2 = c.clientnames();
            clientcombo.DataSource = dt2;
            clientcombo.DisplayMember = "Fname + ' ' + Lname";
            clientcombo.ValueMember = "client_ID";
        }

        private void AllClients_Load(object sender, EventArgs e)
        {
          
        }

        private void editclient_Click(object sender, EventArgs e)
        {
            int clientid = (int)clientcombo.SelectedValue;
            Edit_Client edit_Client = new Edit_Client(clientid);
            edit_Client.Show();
            this.Hide();
        }

        private void clientcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
