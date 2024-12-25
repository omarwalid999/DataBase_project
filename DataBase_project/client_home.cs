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
    public partial class client_home : Form
    {
        public client_home()
        {
            InitializeComponent();
        }

        private void client_home_Load(object sender, EventArgs e)
        {
            ////
        }

        private void logout_Click(object sender, EventArgs e)
        {
            client_login cl = new client_login();
            cl.Show();
        }
    }
}
