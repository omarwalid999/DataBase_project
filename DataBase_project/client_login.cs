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
    public partial class client_login : Form
    {
        Controller cobj = new Controller();
        public client_login()
        {
            InitializeComponent();
        }

        private void change_password_button_Click(object sender, EventArgs e)
        {
            c_change_pass c_Change_Pass = new c_change_pass();
            c_Change_Pass.Show();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (username_textbox.Text != "" && password_textbox.Text != "")
            {
                int id = cobj.client_id(username_textbox.Text);
                if (id != -1)
                {
                    string storedHashedPassword = cobj.get_hashed_password(username_textbox.Text); // Retrieve hashed password

                    if (!string.IsNullOrEmpty(storedHashedPassword) &&
                        PasswordHelper.VerifyPassword(password_textbox.Text, storedHashedPassword))
                    {
                        client_home f = new client_home(id);
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password!");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username!");
                }
            }
            else
            {
                MessageBox.Show("Please enter username and password");
            }
        }

        private void client_login_Load(object sender, EventArgs e)
        {

        }
    }
    }
