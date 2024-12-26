﻿using DBapplication;
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
        public All_Employees()
        {
            InitializeComponent();
            c= new Controller();
        }

        private void All_Employees_Load(object sender, EventArgs e)
        {
            DataTable dt = c.AllEmployees();
            allemployeesview.DataSource = dt;
            allemployeesview.Refresh();
        }

        private void add_e_Click(object sender, EventArgs e)
        {
            Hire hire = new Hire();
            hire.Show();
            this.Hide();
        }

        private void remove_e_Click(object sender, EventArgs e)
        {
            M_Fire m_Fire = new M_Fire();
            m_Fire.Show();  
            this.Hide();
        }
    }
}