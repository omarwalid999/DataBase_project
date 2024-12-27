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
           
        }

        private void AllClients_Load(object sender, EventArgs e)
        {
          
        }

        private void editclient_Click(object sender, EventArgs e)
        {
           
        }

        private void clientcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void back12_Click(object sender, EventArgs e)
        {
            Manager_home M6= new Manager_home();
            M6.Show();
            this.Hide();
        }

        private void allclientsview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
