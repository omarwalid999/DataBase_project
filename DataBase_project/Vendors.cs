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
        int manager_id;
        public Vendors(int id)
        {
            InitializeComponent();
            c = new Controller();
            manager_id = id;
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
            int id=Convert.ToInt32(vendoridtext.Text.ToString());
            int rate=Convert.ToInt32(ratingtext.Text.ToString());  
            string service=servicetext.Text.ToString();
            string vendor=vendornametext.Text.ToString();
            if (vendoridtext.Text == "" || vendornametext.Text == "" || vaddresstext.Text == "" || ratingtext.Text == "" || phonetext.Text == "" || vemailtext.Text == "" || servicetext.Text == "")
            {
                MessageBox.Show("Please enter all required fields");
            }
            else if (!int.TryParse(vendoridtext.Text.ToString(), out id) || !int.TryParse(ratingtext.Text.ToString(), out rate))
            {
                MessageBox.Show("Invalid value");

            }
            else if (rate < 1 || rate > 5)
            {
                MessageBox.Show("Invalid Value");
            }
            //else
            //{
            //    int result;
            //    result = c.addvendor(Convert.ToInt32(vendoridtext.Text.ToString()), vendor, rate, vaddresstext.Text.ToString(), phonetext.Text.ToString(), vemailtext.Text.ToString(), service);
            //    if (result != 0)
            //    {
            //        MessageBox.Show("Added successfully");
            //        DataTable dt1 = c.vendorsdetails();
            //        vendorsview.DataSource = dt1;
            //        vendorsview.Refresh();
            //    } else
            //    {
            //        MessageBox.Show("failed to add vendor");
            //    }

            }
        


        private void deletevendor_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(vendoridtext.Text.ToString());
           
            if (vendoridtext.Text == "" )
            {
                MessageBox.Show("Please enter all required fields");
            }
            else if (!int.TryParse(vendoridtext.Text, out id) )
            {
                MessageBox.Show("Invalid value");

            }
        
            else
            {
                int result;
                result = c.deletevendor(id);
                if (result != 0)
                {
                    MessageBox.Show("Deleted successfully");
                    DataTable dt = c.vendorsdetails();
                    vendorsview.DataSource = dt;
                    vendorsview.Refresh();
                }

            }
        }



        private void updatevendor_Click(object sender, EventArgs e)
        {
            int id;
            int rate;
            if (vendoridtext.Text == "" || vendornametext.Text == "" || vaddresstext.Text == "" || ratingtext.Text == "" || phonetext.Text == "" || vemailtext.Text == "" || servicetext.Text == "")
            {
                MessageBox.Show("Please enter all required fields");
            }
            else if (!int.TryParse(vendoridtext.Text, out id) || !int.TryParse(ratingtext.Text, out rate))
            {
                MessageBox.Show("Invalid value");
            }
            else if (rate < '1' || rate > '5')
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

        private void back5_Click(object sender, EventArgs e)
        {
            Manager_home M2 = new Manager_home(manager_id);
            M2.Show();
            this.Hide();
        }
    }
    }
   

