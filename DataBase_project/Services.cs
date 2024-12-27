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

        public Services()
        {
            InitializeComponent();
            c=new Controller();
            DataTable dt = c.allservices();
            servicesview.DataSource = dt;
        }

        private void Services_Load(object sender, EventArgs e)
        {

        }

        private void addservice_Click(object sender, EventArgs e)
        { 

            if (serviceidtext.Text == "" || vendornametext.Text == "" || vendortext.Text=="" || servicenametext.Text=="" || invoicetext.Text=="" || pricetext.Text=="")
            {
                MessageBox.Show("Please enter all required fields");
            }
            else if (!int.TryParse(serviceidtext.Text, out id) || !int.TryParse(vendortext.Text, out id2) || !int.TryParse(invoicetext.Text, out id3) || !int.TryParse(pricetext.Text, out id4))
            {
                    MessageBox.Show("Invalid ID number ");

            }
             else
             {
                 int result;
                id=Convert.ToInt32(serviceidtext.Text);
                id2=Convert.ToInt32(vendortext.Text);
                id3=Convert.ToInt32(invoicetext.Text);
                id4 = Convert.ToInt32(pricetext.Text);
                result = c.addservice(id, id2, servicenametext.Text, id3, id4);

                    if (result != 0)
                    {
                        MessageBox.Show("service added successfully");
                       servicesview.Refresh();
                    }

              }
                   
         }
        

        private void deleteservice_Click(object sender, EventArgs e)
        {
            int id;
            int id2;
            int id3;
            int id4;
            if (serviceidtext.Text == "" || vendornametext.Text == "" || vendortext.Text == "" || servicenametext.Text == "" || invoicetext.Text == "" || pricetext.Text == "")
            {
                MessageBox.Show("Please enter all required fields");
            }
            else if (!int.TryParse(serviceidtext.Text, out id) || !int.TryParse(vendortext.Text, out id2) || !int.TryParse(invoicetext.Text, out id3) || !int.TryParse(pricetext.Text, out id4))
             {
                    MessageBox.Show("Invalid ID number ");

             }
              else
               {
                    int result;
                    result = c.deleteservice(id);

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
            if (serviceidtext.Text == "" || vendornametext.Text == "" || vendortext.Text == "" || servicenametext.Text == "" || invoicetext.Text == "" || pricetext.Text == "")
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
                    result = c.Updateservice(id, id2, servicenametext.Text, id3, id4, vendornametext.Text);

                    if (result != 0)
                    {
                        MessageBox.Show("service updates successfully");
                        servicesview.Refresh();
                    }

                }

            }
        

        private void back4_Click(object sender, EventArgs e)
        {
            Manager_home M = new Manager_home();
            M.Show();
            this.Hide();
        }
    }
    }
   
    
   
