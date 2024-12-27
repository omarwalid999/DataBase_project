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
        int employee_id;
        public message_employee(int id)
        {
            employee_id = id;
            InitializeComponent();
        }

        private void message_employee_Load(object sender, EventArgs e)
        {

        }
    }
}
