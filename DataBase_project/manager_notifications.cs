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
    public partial class manager_notifications : Form
    {
        Controller controllerobj;
        int manager_id;
        public manager_notifications(int id)
        {
            manager_id = id;
            controllerobj = new Controller();
            InitializeComponent();
        }

        private void manager_notifications_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable=controllerobj.manager_notifications(manager_id);
            messages.DataSource = dataTable;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Manager_home f = new Manager_home(manager_id);
            f.Show();
            this.Close();
        }
    }
}
