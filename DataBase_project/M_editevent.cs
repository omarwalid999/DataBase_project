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
    public partial class M_editevent : Form
    {
        Controller c;
        int eventid;
        public M_editevent(int id)
        {
            eventid = id;
            InitializeComponent();
            c=new Controller();
            DataTable dt = c.eventinfo(eventid);
            eventinfoview.DataSource = dt;



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editevent_Click(object sender, EventArgs e)
        {
            
        }

        private void M_editevent_Load(object sender, EventArgs e)
        {

        }
    }
}
