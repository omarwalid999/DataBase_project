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
    public partial class M_Events : Form
    {
        Controller c;
        public M_Events()
        {
            InitializeComponent();
            c=new Controller();
        }

        private void alleventsview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void M_Events_Load(object sender, EventArgs e)
        {
            DataTable dt = c.AllEvents();
            alleventsview.DataSource = dt;
            alleventsview.Refresh();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            M_editevent m_Editevent = new M_editevent();
            m_Editevent.Show();
            this.Hide();
        }
    }
}
