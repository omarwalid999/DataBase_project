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
        int manager_id;
        public AllClients(int id)
        {
            InitializeComponent();
            c = new Controller();
            manager_id = id;
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
            Manager_home M6= new Manager_home(manager_id);
            M6.Show();
            this.Hide();
        }

        private void allclientsview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
