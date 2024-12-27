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
    public partial class message_manager : Form
    {
        Controller controllerobj;
        int manager_id;
        public message_manager( int id)
        {
            InitializeComponent();
            controllerobj = new Controller();
            manager_id= id;
        }

        private void message_manager_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt=controllerobj.get_employees_for_messages();
            employees.DataSource = dt;
            username_combobox.DataSource = dt;
            username_combobox.DisplayMember ="username" ;
        }
    }
}
