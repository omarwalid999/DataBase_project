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
        public Goals()
        {
            InitializeComponent();
            c=new Controller();
            DataTable dt = c.goalslist();
            goalsview.DataSource=dt;
            
        }

        private void Goals_Load(object sender, EventArgs e)
        {

        }
    }
}
