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
    public partial class Hire : Form
    {
        Controller c;
        int id;
        int age;
        string gender = "";
        int manager_id;
        public Hire(int id)
        {
            InitializeComponent();
            c = new Controller();
            manager_id = id;
            DataTable dt = c.department();
            departcombo.DataSource = dt;
            departcombo.DisplayMember = "dep_name";
            departcombo.ValueMember = "dep_ID";
            
        }

        private void hirebutton_Click(object sender, EventArgs e)
        {

            int age;
            int dwpid = Convert.ToInt32(departcombo.SelectedValue.ToString());
            if (radioButton1.Checked)
            {
                gender = "Female";
            }
            else if (radioButton2.Checked)
            {
                gender = "Male";
            }
          

            if (eidtext.Text == "" || fnametext.Text == "" || lnametext.Text == "" || emailtext.Text == "" || phonetext.Text == "" || agetext.Text == "" || usernametext.Text == "" || passkeytext.Text == "" || (!radioButton1.Checked && !radioButton2.Checked) || departcombo.SelectedIndex == -1)
            {
                MessageBox.Show("Please Enter All Required Fields");
            }
            else if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("please choose gender");
            }
            else if (!int.TryParse(agetext.Text, out age) || !int.TryParse(eidtext.Text, out id))
            {
                MessageBox.Show("Incorrect Value");
            }
            else if (age <= 0)
            {
                MessageBox.Show("Please enter a valid age value");
            }
            else if (!fnametext.Text.All(c => char.IsLetter(c)) && !lnametext.Text.All(c => char.IsLetter(c)))
            {
                MessageBox.Show("Please Enter valid name");
            }
            else
            {
                id = Convert.ToInt32(eidtext.Text);
                age = Convert.ToInt32(agetext.Text);
                int result;
                result = c.InsertNewEmployee(id, fnametext.Text, lnametext.Text, emailtext.Text, phonetext.Text, gender, Convert.ToInt32(agetext.Text), usernametext.Text, passkeytext.Text, Convert.ToInt32(departcombo.SelectedValue));
                if (result != 0)
                {
                    MessageBox.Show("Added susscessfully");
                }
            }
        }

        



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            

        }
       

        private void updateemp_Click(object sender, EventArgs e)
        {
            int age;
            int dwpid = Convert.ToInt32(departcombo.SelectedValue.ToString());
            if (radioButton1.Checked)
            {
                gender = "Female";
            }
            else if (radioButton2.Checked)
            {
                gender = "Male";
            }


            if (eidtext.Text == "" || fnametext.Text == "" || lnametext.Text == "" || emailtext.Text == "" || phonetext.Text == "" || agetext.Text == "" || usernametext.Text == "" || passkeytext.Text == "" || (!radioButton1.Checked && !radioButton2.Checked) || departcombo.SelectedIndex == -1)
            {
                MessageBox.Show("Please Enter All Required Fields");
            }
            else if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("please choose gender");
            }
            else if (!int.TryParse(agetext.Text, out age) || !int.TryParse(eidtext.Text, out id))
            {
                MessageBox.Show("Incorrect Value");
            }
            else if (age <= 0)
            {
                MessageBox.Show("Please enter a valid age value");
            }
            else if (!fnametext.Text.All(c => char.IsLetter(c)) && !lnametext.Text.All(c => char.IsLetter(c)))
            {
                MessageBox.Show("Please Enter valid name");
            }
            else
            {
                id = Convert.ToInt32(eidtext.Text);
                age = Convert.ToInt32(agetext.Text);
                int result;
                result = c.updatemployee(id, fnametext.Text, lnametext.Text, emailtext.Text, phonetext.Text, gender, Convert.ToInt32(agetext.Text), usernametext.Text, passkeytext.Text, Convert.ToInt32(departcombo.SelectedValue));
                if (result != 0)
                {
                    MessageBox.Show("updated susscessfully");
                }
            }
        }

        private void Hire_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            All_Employees all_Employees = new All_Employees(manager_id);
            all_Employees.Show();
            this.Hide();
        }
    }
    }

