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
    public partial class Edit_Client : Form
    {
        int clientid;
        Controller c;
        public Edit_Client(int id)
        {
            clientid = id; 
            InitializeComponent();
            c= new Controller();
            DataTable dt = c.clientinfo(clientid);
            clientinfoview.DataSource = dt; 
            clientinfoview.Refresh();
        }

        private void Edit_Client_Load(object sender, EventArgs e)
        {

        }
    }
}
