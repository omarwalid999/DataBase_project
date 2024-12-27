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
        int manager_id;
        public Manager_home(int id)
        {
            manager_id = id;
            InitializeComponent();
        }

        private void allevents_Click(object sender, EventArgs e)
        {
            M_Events m_Events = new M_Events(manager_id);
            m_Events.Show();
            this.Hide();

           
        }

        private void allemployees_Click(object sender, EventArgs e)
        {
            All_Employees all_Employees = new All_Employees(manager_id);
            all_Employees.Show();
            this.Hide();
        }

        private void allclients_Click(object sender, EventArgs e)
        {
            AllClients allclients = new AllClients(manager_id);
            allclients.Show();
            this.Hide();
        }

        private void eventtypes_Click(object sender, EventArgs e)
        {
            Event_Types event_Types = new Event_Types(manager_id);
            event_Types.Show();
            this.Hide();
        }

        private void vendors_Click(object sender, EventArgs e)
        {
            Vendors vendors = new Vendors(manager_id);
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
            Goals goals = new Goals(manager_id);
            goals.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            message_manager f=new message_manager(manager_id);
            f.Show();
            this.Hide();
        }

        private void Manager_home_Load(object sender, EventArgs e)
        {

        }
    }
}
