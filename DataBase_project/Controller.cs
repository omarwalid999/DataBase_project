using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Microsoft.Win32;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        //omar






        //tarek
        //employee
        public bool CheckPass(int id, string enteredpassword)
        {
    
            string query = $"SELECT passkey FROM employee WHERE employee_ID = '{id}'";

            var storedPassword = dbMan.ExecuteScalar(query);

            // Compare the stored password with the entered password
            return storedPassword != null && storedPassword.ToString() == enteredpassword;
        }
        public int emp_id(string username)
        {
            string query = $"SELECT employee_ID FROM employee WHERE username = '{username}'";
            return (int)dbMan.ExecuteScalar(query);
        }
        public DataTable get_employees()
        {
            string query = "SELECT employee_ID, username FROM employee;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable sch_events(int id)
        {
            string query = $"SELECT eventname, event_date, venue_name, client.client_ID, event_ID FROM client, venue, event WHERE employee_ID = {id} AND event.client_ID = client.client_ID AND venue.venue_ID= event.venue_ID ;"; 
            return dbMan.ExecuteReader(query);
        }
        public DataTable task(int id)
        {
            string query = $"SELECT task, task_ID, task_status FROM task WHERE employee_ID = {id};";
            return dbMan.ExecuteReader(query);
        }
        public int Done(int id)
        {
            string query = $"UPDATE task SET task_status='Done' WHERE task_ID={id} ;";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Not_yet(int id)
        {
            string query = $"UPDATE task SET task_status='Not Yet' WHERE task_ID={id} ;";
            return dbMan.ExecuteNonQuery(query);
        }
        public int insert_task(int taskid, string tasks, string status, int id)
        {
            string query1 = $"SELECT COUNT(task) FROM task ";
            int count=(int)dbMan.ExecuteScalar(query1);
            string query = $"INSERT INTO task (task_id, task, task_status, employee_ID) VALUES ({taskid}, '{tasks}', {status}, '{id}')"; ;

            return dbMan.ExecuteNonQuery(query);
        }
        public int get_count()
        {
            string query1 = $"SELECT COUNT(task) FROM task ";
            int count = (int)dbMan.ExecuteScalar(query1);
           return count;
        }








        //noor
        //hagat client signup
        public int InsertNewClient(int clientid, string Fname, string Lname, string email, string phone, string username, string passkey)
        {
            string query = "INSERT INTO client (client_ID, Fname, Lname, email, phone, username,passkey)" +
                            "Values (" + clientid + ",'" + Fname + "','" + Lname + "','" + email + "','"+ phone+"','"+ username+"','"+passkey+"');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int CheckUsername(string username, string password)
        {
            string query = "SELECT client_ID FROM client WHERE username='" + username + "' AND passkey='"+password+"';";
            return Convert.ToInt32(query);
        }
        public DataTable ShowVendors()
        {
            string query = "SELECT * FROM Vendors;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable ShowAllEvents(int clientid) //for datagrid view
        {
            string query = "SELECT * FROM events Where client_ID="+clientid+";";
            return dbMan.ExecuteReader(query);
        }
        public DataTable ShowEvents(int clientid) //for combobox
        {
            string query = "SELECT * FROM events Where client_ID=" + clientid + ";";
            return dbMan.ExecuteReader(query);
        }

        //rawan





    };
}
