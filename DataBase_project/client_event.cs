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
            Controller c = new Controller();
            DataTable dt= c.ShowClientEvents(id);
            DataTable dt1 = c.ShowClientEventsNames(id);
            clientseventdatagridview.DataSource = dt;
            eventscombobox.DataSource = dt1;
            eventscombobox.DisplayMember = "eventname";
        }

        private void client_event_Load(object sender, EventArgs e)
        {

        }
    }
}
