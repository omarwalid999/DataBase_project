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
        public e_vendors()
        {
            InitializeComponent();
            Controller controllerObj = new Controller();
            DataTable dt = controllerObj.ShowVendors();
            vendorsdataGridView.DataSource = dt;
            vendorsdataGridView.Refresh();
        }
    }
}
