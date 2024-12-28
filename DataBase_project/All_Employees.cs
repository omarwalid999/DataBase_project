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
    public partial class All_Employees : Form
    {
        Controller c;
        int manager_id;
        public All_Employees(int id)
        {
            InitializeComponent();
            c= new Controller();
            manager_id= id;
            DataTable dt = c.AllEmployees();
            allemployeesview.DataSource = dt;
            allemployeesview.Refresh();
        }

        private void All_Employees_Load(object sender, EventArgs e)
        {
          
        }

        private void add_e_Click(object sender, EventArgs e)
        {
           Hire h= new Hire(manager_id);
            h.Show();
            this.Hide();
        }

        private void remove_e_Click(object sender, EventArgs e)
        {
          M_Fire fire= new M_Fire(manager_id);
            fire.Show();
            this.Hide();
        }

        private void allemployeesview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void editemp_Click(object sender, EventArgs e)
        {
            EditEmp empedit= new EditEmp();
            empedit.Show();
            this.Hide();
        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Manager_home manager_Home = new Manager_home(manager_id);
            manager_Home.Show();
            this.Hide();
        }
    }
}
