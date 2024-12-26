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
    public partial class Vendors : Form
    {
        Controller c;
        public Vendors()
        {
            InitializeComponent();
            c = new Controller();
            DataTable dt = c.vendorsdetails();
            vendorsview.DataSource = dt;

        }

        private void Vendors_Load(object sender, EventArgs e)
        {

        }

        private void vendorsview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addvendor_Click(object sender, EventArgs e)
        {
            if (vendoridtext.Text == "" || vendornametext.Text == "" || vaddresstext.Text == "" || ratingtext.Text == "" || phonetext.Text == "" || vemailtext.Text == "" || servicetext.Text == "")
            {
                MessageBox.Show("Please enter all required fields");
            }
            else
            {
                int id;
                if (!int.TryParse(vendoridtext.Text, out id))
                {
                    MessageBox.Show("Invalid ID");

                }
                else
                {
                    int rate;
                    if (!int.TryParse(ratingtext.Text, out rate))
                    {
                        MessageBox.Show("Invalid value");

                    }
                    else
                    {
                        if (rate < '1' || rate > '5')
                        {
                            MessageBox.Show("Invalid Value");
                        }
                        else
                        {
                            int result;
                            result = c.addvendor(id, vendornametext.Text, rate, vaddresstext.Text, phonetext.Text, vemailtext.Text, servicetext.Text);
                            if (result != 0)
                            {
                                MessageBox.Show("Added successfully");
                                vendorsview.Refresh();
                            }

                        }

                    }
                }
            }
        }

        private void deletevendor_Click(object sender, EventArgs e)
        {
            if (vendoridtext.Text == "" || vendornametext.Text == "" || vaddresstext.Text == "" || ratingtext.Text == "" || phonetext.Text == "" || vemailtext.Text == "" || servicetext.Text == "")
            {
                MessageBox.Show("Please enter all required fields");
            }
            else
            {
                int id;
                if (!int.TryParse(vendoridtext.Text, out id))
                {
                    MessageBox.Show("Invalid ID");

                }
                else
                {
                    int rate;
                    if (!int.TryParse(ratingtext.Text, out rate))
                    {
                        MessageBox.Show("Invalid value");

                    }
                    else
                    {
                        if (rate < '1' || rate > '5')
                        {
                            MessageBox.Show("Invalid Value");
                        }
                        else
                        {
                            int result;
                            result = c.deletevendor(id);
                            if (result != 0)
                            {
                                MessageBox.Show("Deleted successfully");
                                vendorsview.Refresh();
                            }

                        }

                    }
                }
            }
        }

        private void updatevendor_Click(object sender, EventArgs e)
        {
            if (vendoridtext.Text == "" || vendornametext.Text == "" || vaddresstext.Text == "" || ratingtext.Text == "" || phonetext.Text == "" || vemailtext.Text == "" || servicetext.Text == "")
            {
                MessageBox.Show("Please enter all required fields");
            }
            else
            {
                int id;
                if (!int.TryParse(vendoridtext.Text, out id))
                {
                    MessageBox.Show("Invalid ID");

                }
                else
                {
                    int rate;
                    if (!int.TryParse(ratingtext.Text, out rate))
                    {
                        MessageBox.Show("Invalid value");

                    }
                    else
                    {
                        if (rate < '1' || rate > '5')
                        {
                            MessageBox.Show("Invalid Value");
                        }
                        else
                        {
                            int result;
                            result = c.Updatevendor(id, vendornametext.Text, rate, vaddresstext.Text, phonetext.Text, vemailtext.Text, servicetext.Text);
                            if (result != 0)
                            {
                                MessageBox.Show("Updated successfully");
                                vendorsview.Refresh();
                            }

                        }

                    }
                }
            }
        }

    }
    }
   

