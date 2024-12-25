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
    public partial class client_events : Form
    {
        public client_events()
        {
            InitializeComponent();
            Controller controllerObj = new Controller();
            //get client id men form ely ablo
            //DataTable dt1 = controllerObj.ShowAllEvents(id);
            //eventdataGridView.DataSource = dt1;
            //eventdataGridView.Refresh();
            //DataTable dt = controllerObj.ShowEvents(); 
            //eventcomboBox.DataSource = dt;
            //eventcomboBox.DisplayMember = "Dlocation"; // Note: we used only the display member here
            
            

        }

        private void client_events_Load(object sender, EventArgs e)
        {

        }
    }
}
