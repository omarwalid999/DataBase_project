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
    public partial class Statistics : Form
    {
       
        public Statistics()
        {
            InitializeComponent();
            Controller cobj = new Controller();
            DataTable dt = cobj.ShowAgeGroups();
            AgeGroups.DataSource = dt;
            AgeGroups.Refresh();
            maxprice_tb.Text = cobj.ShowMaxPrice().ToString();
            max_cap_tb.Text = cobj.ShowMaxCapacity().ToString();
            DataTable dt1 = cobj.showstatistics();
            dg2.DataSource = dt1;
            dg2.Refresh();

        }

        private void Statistics_Load(object sender, EventArgs e)
        {

        }

        private void AgeGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void max_cap_tb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
