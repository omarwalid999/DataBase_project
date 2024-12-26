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
    public partial class Manager_home : Form
    {
        public Manager_home()
        {
            InitializeComponent();
        }

        private void allevents_Click(object sender, EventArgs e)
        {
            M_Events m_Events = new M_Events();
            m_Events.Show();
            this.Hide();

           
        }

        private void allemployees_Click(object sender, EventArgs e)
        {
            All_Employees all_Employees = new All_Employees();
            all_Employees.Show();
            this.Hide();
        }
    }
}
