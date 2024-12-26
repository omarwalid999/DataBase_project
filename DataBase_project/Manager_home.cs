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
    public partial class Manager_home : Form
    {
        public Manager_home()
        {
            InitializeComponent();
        }

        private void allevents_Click(object sender, EventArgs e)
        {
            M_Events m_Events = new M_Events();
            m_Events.Show();
            this.Hide();

           
        }

        private void allemployees_Click(object sender, EventArgs e)
        {
            All_Employees all_Employees = new All_Employees();
            all_Employees.Show();
            this.Hide();
        }

        private void allclients_Click(object sender, EventArgs e)
        {
            AllClients allclients = new AllClients();
            allclients.Show();
            this.Hide();
        }

        private void eventtypes_Click(object sender, EventArgs e)
        {
            Event_Types event_Types = new Event_Types();
            event_Types.Show();
            this.Hide();
        }

        private void vendors_Click(object sender, EventArgs e)
        {
            Vendors vendors = new Vendors();
            vendors.Show();
            this.Hide();
        }

        private void services_Click(object sender, EventArgs e)
        {
            Services services = new Services();
            services.Show();
            this.Hide();
        }

        private void goals_Click(object sender, EventArgs e)
        {
            Goals goals = new Goals();
            goals.Show();
            this.Hide();
        }
    }
}
