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
    public partial class Services : Form
    {
        Controller c;
        int id;
        int id2;
        int id3;
        int id4;
        int manager_id;
        public Services(int id)
        {
            InitializeComponent();
            c=new Controller();
            manager_id=id;
            DataTable dt = c.allservices();
            servicesview.DataSource = dt;
        }

        private void Services_Load(object sender, EventArgs e)
        {

        }

        private void addservice_Click(object sender, EventArgs e)
        {
            int serviceid = Convert.ToInt32(serviceidtext.Text);
            int vendorid = Convert.ToInt32(vendortext.Text);
            int invoiceid = Convert.ToInt32(invoicetext.Text);
            int price = Convert.ToInt32(pricetext.Text.ToString());
            string servicename = servicenametext.Text;
            if (serviceidtext.Text == "" || vendortext.Text == "" || servicenametext.Text == "" || invoicetext.Text == "" || pricetext.Text == "" )
            {
                MessageBox.Show("Please enter all required fields");
            }
            else if (!int.TryParse(serviceidtext.Text, out serviceid) || !int.TryParse(vendortext.Text, out vendorid) || !int.TryParse(invoicetext.Text, out invoiceid) || !int.TryParse(pricetext.Text, out price))
            {
                    MessageBox.Show("Invalid ID number ");

            }
             else
             {
                int result;
                result = c.addservice(serviceid, vendorid, servicename, invoiceid, price);

                    if (result != 0)
                    {
                        MessageBox.Show("service added successfully");
                       servicesview.Refresh();
                    }

              }
                   
         }
        

        private void deleteservice_Click(object sender, EventArgs e)
        {
            int serviceid = Convert.ToInt32(serviceidtext.Text);
            int vendorid = Convert.ToInt32(vendortext.Text);
            int invoiceid = Convert.ToInt32(invoicetext.Text);
            int price = Convert.ToInt32(pricetext.Text);
            string servicename = servicenametext.Text;
            if (serviceidtext.Text == "" || vendortext.Text == "" || servicenametext.Text == "" || invoicetext.Text == "" || pricetext.Text == "")
            {
                MessageBox.Show("Please enter all required fields");
            }
            else if (!int.TryParse(serviceidtext.Text, out serviceid) || !int.TryParse(vendortext.Text, out vendorid) || !int.TryParse(invoicetext.Text, out invoiceid) || !int.TryParse(pricetext.Text, out price))
            {
                MessageBox.Show("Invalid ID number ");

            }
            else
            {
                int result;
                result = c.deleteservice(serviceid, invoiceid);

                if (result != 0)
                {
                    MessageBox.Show("service deleted successfully");
                    servicesview.Refresh();
                }

            }

        }
            
        

        private void updateservice_Click(object sender, EventArgs e)
        {
            int id;
            int id2;
            int id3;
            int id4;
            if (serviceidtext.Text == "" || vendortext.Text == "" || servicenametext.Text == "" || invoicetext.Text == "" || pricetext.Text == "")
            {
                MessageBox.Show("Please enter all required fields");
            }
            else if  (!int.TryParse(serviceidtext.Text, out id) || !int.TryParse(vendortext.Text, out id2) || !int.TryParse(invoicetext.Text, out id3) || !int.TryParse(pricetext.Text, out id4))
                {
                    MessageBox.Show("Invalid ID number ");

                }
                else
                {
                    int result;
                   // result = c.Updateservice(id, id2, servicenametext.Text, id3, id4);

                   // if (result != 0)
                   // {
                       // MessageBox.Show("service updates successfully");
                       // servicesview.Refresh();
                   // }

                }

            }
        

        private void back4_Click(object sender, EventArgs e)
        {
            Manager_home M = new Manager_home(manager_id);
            M.Show();
            this.Hide();
        }
    }
    }
   
    
   
