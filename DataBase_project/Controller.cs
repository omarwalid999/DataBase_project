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
        public bool check_login_c (string username, string password)
        {
            string query = $"SELECT passkey FROM client WHERE username = '{username}'";
            string pass=dbMan.ExecuteScalar(query).ToString();
            if(pass != password)
            {
                return false;
            }
            else
            {
                return true;
            }
        }





        //tarek
        //employee
        public bool CheckPass(int id, string enteredpassword)
        {
    
            string query = $"SELECT passkey FROM employee WHERE employee_ID = '{id}'";

            var storedPassword = dbMan.ExecuteScalar(query);

            // Compare the stored password with the entered password
            return storedPassword != null && storedPassword.ToString() == enteredpassword;
        }
        public bool check_login_e(string username, string password)
        {
            string query = $"SELECT passkey FROM employee WHERE username = '{username}'";
            string pass = dbMan.ExecuteScalar(query).ToString();
            if (pass != password)
            {
                return false;
            }
            else
            {
                return true;
            }
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
           
            string query = $"INSERT INTO task (task_id, task, task_status, employee_ID) VALUES ({taskid}, '{tasks}', '{status}', {id})"; ;

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

        public DataTable AllEvents()
        {
            string query = "SELECT E.event_ID, E.budget, F.event_type, E.event_date,  CONCAT(fname,' ',lname) AS e_name, V.venue_name, CONCAT(Fname,' ',Lname) AS c_name, E.no_of_attendees FROM event AS E, employee AS T, event_types AS F, venue AS V, client AS C WHERE E.event_type=F.types_ID, E.employee_ID=T.employee_ID, E.venue_ID=V.venue_ID, E.client_ID=C.client_ID ;";
            return dbMan.ExecuteReader(query);
        }
      //  public DataTable EventsList()
       // {
           // string query = "SELECT "
      //  }
        public DataTable AllEmployees()
        {
            string query = "SELECT * FROM employee ;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable department()
        {
            string query = "SELECT dep_name FROM departments;";
            return dbMan.ExecuteReader(query);
        }
        public int InsertNewEmployee(int e_ID, string Fname, string Lname, string email, string phone, string gender, int age, string username, string passkey, int depid)
        {
            string query = "INSERT INTO employee (employee_ID, fname, lname, email, phone, gender, username, passkey, dep_ID)" +
                            "Values (" + e_ID + ",'" + Fname + "','" + Lname + "','" + email + "','" + phone + "','" + gender + "','" + age + "','" + username + "','" + passkey + "','" + depid + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable Employeesnames()
        {
            string query = "SELECT CONCAT(fname,' ',lname) AS name FROM employee ;";
            return dbMan.ExecuteReader(query);
        }
        public int DeleteEmployee(int employeeid)
        {
            string query= "DELETE * FROM employee WHERE employee_ID=" + employeeid + ";";
            return dbMan.ExecuteNonQuery(query);
        }


    };
}
