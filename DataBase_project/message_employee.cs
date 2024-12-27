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
    public partial class message_employee : Form
    {
        Controller controllerobj;
        int employee_id;
        public message_employee(int id)
        {
            employee_id = id;
            controllerobj = new Controller();
            InitializeComponent();
        }

        private void message_employee_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = controllerobj.get_managers();
            managers.DataSource = dt;
            DataTable dt1 = new DataTable();
            dt1 =controllerobj.get_employee_clients(employee_id);
            clients.DataSource = dt1;
        }
    }
}
