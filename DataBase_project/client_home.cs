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
    public partial class client_home : Form
    {
        int id1;
        Controller c = new Controller();
        public client_home(int id)
        {
            InitializeComponent();
            this.id1 = id;
        }

        private void client_home_Load(object sender, EventArgs e)
        {
            ////
        }

        private void logout_Click(object sender, EventArgs e)
        {
            client_login cl = new client_login();
            cl.Show();
            this.Hide();
        }

        private void NewEvent_Click(object sender, EventArgs e)
        {
            client_newevent c = new client_newevent(id1);
            c.Show();
            this.Hide();
        }

        private void events_Click(object sender, EventArgs e)
        {
            client_event ce = new client_event(id1);
            ce.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            client_message m = new client_message(id1);
            m.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Home m = new Home();
            m.Show();
            this.Hide();
        }
        //momken neshil previous events w nezawed fi my events button feedback
    }
}
