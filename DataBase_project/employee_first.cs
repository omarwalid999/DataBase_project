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
    public partial class employee_first : Form
    {
        public employee_first()
        {
            InitializeComponent();
        }

        private void manager_button_Click(object sender, EventArgs e)
        {
            manager_login f=new manager_login();
            f.Show();
        }

        private void employee_button_Click(object sender, EventArgs e)
        {
            employee_login f=new employee_login();
            f.Show();
        }
    }
}
