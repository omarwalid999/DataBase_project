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
    public partial class client_notifications : Form
    {
        Controller controllerobj;
        int client_id;
        public client_notifications(int id)
        {
            client_id = id;
            controllerobj = new Controller();
            InitializeComponent();
        }

        private void client_notifications_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable=controllerobj.client_notifications(client_id);
            messages.DataSource = dataTable;

        }
    }
}
