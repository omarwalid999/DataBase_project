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
    
    public partial class client_signup : Form
    {
        Controller c;
        public client_signup()
        {
            InitializeComponent();
            c= new Controller();
        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            int clientID =27;
            if ( Fnametb.Text != "" && Lnametb.Text != "" && emailtb.Text != "" && phonetb.Text != "" && usernametb.Text != "" && passkeytb.Text != "")
            {
                clientID++;
                int s = c.InsertNewClient(clientID, Fnametb.Text, Lnametb.Text, emailtb.Text, phonetb.Text, usernametb.Text, passkeytb.Text);
                if (s != 0)
                {
                    MessageBox.Show("Sign up done successfully, You're now a registered client");
                    client_login cl = new client_login();
                    cl.Show();
                }
                else
                {
                    MessageBox.Show("Sign up failed.");
                }
            }
            else
            {
                MessageBox.Show("error please enter all fields");
            }
        }
    }
}
