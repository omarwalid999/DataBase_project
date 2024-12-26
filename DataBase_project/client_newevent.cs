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
    public partial class client_newevent : Form
    {
        public client_newevent()
        {
            InitializeComponent();
            Controller cobj = new Controller();
            DataTable dt = cobj.ShowTypes();
            typesofevents.DataSource = dt;
            typesofevents.DisplayMember = "event_type";
            typesofevents.ValueMember = "types_ID";
        }

        private void typesofevents_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }
    }
}
