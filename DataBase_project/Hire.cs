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
        public Hire()
        {
            InitializeComponent();
            c = new Controller();
            DataTable dt = c.department();
            departmentcombo.DataSource = dt;
            departmentcombo.DisplayMember = "dep_name";
            departmentcombo.ValueMember = "dep_ID";
        }

        private void hirebutton_Click(object sender, EventArgs e)
        {
          

            if (eidtext.Text=="" ||fnametext.Text == "" || lnametext.Text == "" || emailtext.Text == "" || phonetext.Text == "" || agetext.Text == "" || usernametext.Text == "" || passkeytext.Text == "" || !radioButton1.Checked || !radioButton2.Checked || departmentcombo.SelectedIndex == -1)
            {
                MessageBox.Show("Please Enter All Required Fields");
            }
            else
            {
                int age;
                if (!int.TryParse(agetext.Text, out age))
                {
                    MessageBox.Show("Incorrect Age Value");
                }
                else
                {
                    if (age <= 0)
                    {
                        MessageBox.Show("Please enter a valid age value");
                    }
                    else
                    {
                        if (!fnametext.Text.All(c => char.IsLetter(c)) && !lnametext.Text.All(c => char.IsLetter(c)))
                        {
                            MessageBox.Show("Please Enter valid name");
                        }
                        else
                        {
                            int id;
                            if (!int.TryParse(eidtext.Text, out id))
                                {
                                    MessageBox.Show("Incorrect ID Value");
                                }
                            else
                            {
                                string gender = "";
                                if (radioButton1.Checked)
                                {
                                    gender = "Female";
                                }
                                else if (radioButton2.Checked)
                                {
                                    gender = "Male";
                                }
                                int depid = (int)departmentcombo.SelectedIndex;
                                int result;
                                result = c.InsertNewEmployee(id, fnametext.Text, lnametext.Text, emailtext.Text, phonetext.Text, gender, age, usernametext.Text, passkeytext.Text, depid);
                                if (result != 0)
                                {
                                    MessageBox.Show("Added susscessfully");
                                }

                            }
                        }

                    }

                }
            }
           
        
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            

        }

        private void back2_Click(object sender, EventArgs e)
        {
            All_Employees all_Employees = new All_Employees();
            all_Employees.Show();
            this.Hide();
        }
    }
}
