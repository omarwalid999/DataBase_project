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
    public partial class client_message : Form
    {
        int id2;
        Controller cobj = new Controller();
        public client_message(int id)
        {
            InitializeComponent();
            id2 = id;
        }

        private void client_message_Load(object sender, EventArgs e)
        {
            int employeeid= cobj.get_emp_id(id2);
            //3ayzeen neshouf hena han display wla han send wla hane3mel eh
        }
    }
}
