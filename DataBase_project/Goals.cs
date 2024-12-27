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
    public partial class Goals : Form
    {
        Controller c;
        int manager_id;
        public Goals(int id)
        {
            InitializeComponent();
            c=new Controller();
            manager_id=id;
            DataTable dt = c.goalslist();
            goalsview.DataSource=dt;
            DataTable dt2 = c.department();
            depcombo.DataSource=dt2;
            depcombo.DisplayMember = "dep_name";
            depcombo.ValueMember = "dep_ID";
            
        }

        private void Goals_Load(object sender, EventArgs e)
        {

        }

        private void depcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
