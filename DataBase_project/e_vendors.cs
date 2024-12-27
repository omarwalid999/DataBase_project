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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataBase_project
{
    public partial class e_vendors : Form
    {
        int b;
        public e_vendors(int id)
        {
            
            InitializeComponent();
            b = id;
            Controller controllerObj = new Controller();
            DataTable dt = controllerObj.ShowVendors();
            vendorsdataGridView.DataSource = dt;
            vendorsdataGridView.Refresh();
        }

        private void vendorsdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void e_vendors_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            employee_home eh = new employee_home(b);
            eh.Show();
            this.Hide();
        }
    }
}
