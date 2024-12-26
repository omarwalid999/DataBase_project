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
        }

        private void client_event_Load(object sender, EventArgs e)
        {

        }
    }
}
