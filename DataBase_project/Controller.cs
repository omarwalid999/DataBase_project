using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        public int client_id(string username)
        {
            string query = $"SELECT client_ID FROM client WHERE username = '{username}'";
            return (int)dbMan.ExecuteScalar(query);
        }
         public void change_pass_c(string username,string pass)
        {
            string query = $"UPDATE client SET password={pass} WHERE username='{username}' ";
            dbMan.ExecuteNonQuery(query);
        }

        public void change_pass_e(string username, string pass)
        {
            string query = $"UPDATE employee SET password={pass} WHERE username='{username}' ";
            dbMan.ExecuteNonQuery(query);
        }

        public int get_dep_id(string user)
        {
            string query = $"SELECT dep_ID FROM employee WHERE username='{user}'";
            return (int)dbMan.ExecuteScalar(query);
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
        public int InsertFeedback(int feedbackid, int  clientid, string comment, string date, int rating)
        {
            string query = "INSERT INTO feedbacks (feedback_ID, client_ID, comment,feedback_date,rating)" +
                            "Values (" + feedbackid + "," + clientid + ",'" + comment + "','" + date + "'," + rating + ");" ;
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable ShowVendors()
        {
            string query = "SELECT * FROM Vendors;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable ShowClientEvents(int clientid)
        {
            string query = "SELECT event.eventname,event_types.event_type,event.event_date,event.budget,event.no_of_attendees,employee.fname,employee.lname FROM event, event_types,employee WHERE event.client_ID="+clientid+" AND event.event_type=event_types.types_ID AND event.employee_ID=employee.employee_ID;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable ShowClientEventsNames(int clientid) 
        {
            string query = "SELECT event.eventname FROM event  WHERE client_ID="+clientid+";";
            return dbMan.ExecuteReader(query);
        }
        public DataTable ShowTypes()
        {
            string query = "SELECT * FROM event_types;";
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
            string query = "SELECT E.event_ID, E.budget, F.event_type, E.event_date,  CONCAT(fname,' ',lname) AS e_name, V.venue_name, CONCAT(Fname,' ',Lname) AS c_name, E.no_of_attendees FROM event AS E, employee AS T, event_types AS F, venue AS V, client AS C WHERE E.event_type=F.types_ID AND E.employee_ID=T.employee_ID AND E.venue_ID=V.venue_ID AND E.client_ID=C.client_ID ;";
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
        public DataTable allclients()
        {
            string query = "SELECT * FROM client;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable clientnames()
        {
            string query = "SELECT CONCAT(Fname, ' ' , Lname) AS name FROM client ;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable clientinfo(int clientid)
        {
            string query = "SELECT * FROM client WHERE client_ID= " + clientid + " ;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable eventtypes()
        {
            string query = "SELECT * FROM event_types ;";
            return dbMan.ExecuteReader(query);
        }
        public int addtype(int type_ID, string type_name)
        {
            string query = "INSERT INTO event_type (types_ID, event_type)" +
                          "Values (" + type_ID + ",'" + type_name +  "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int deletetype(int type_ID, string type_name)
        {
            string query = "DELETE * FROM event_type WHERE types_ID= " + type_ID + " AND event_type=" + type_name + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable vendorsdetails()
        {
            string query = "SELECT vendors.*, services_offered.name_of_service FROM vendors JOIN services_offered ON vendors.vendor_ID=services_offered.vendor_ID ;";
            return dbMan.ExecuteReader(query);
        }
        public int addvendor(int vendor_ID, string vendor_name, int rating, string address, string phone, string email, string service)
        {
            string query = "INSERT INTO vendors (vendor_ID, vendor_name, rating, vendor_address, phone, email)" +
                            "Values (" + vendor_ID + ",'" + vendor_name + "','" + rating + "','" + address + "','" + phone + "','" + email + "');";
            string query2 = "INSERT INTO services_offered(vendor_ID, name_of_service)" + "Values(" + vendor_ID + ",'" + service + "');";
            int result1=dbMan.ExecuteNonQuery(query);
            int result2=dbMan.ExecuteNonQuery(query2);
            int result = result1 + result2;
            return result;
            
        }
        public int deletevendor(int vendor_ID)
        {
            string query = "DELETE vendors.*, services_offered.* FROM vendors, services_offered WHERE vendors.vendor_ID=services_offered.vendor_ID AND vendor.vendor_ID=" + vendor_ID + ";";
            return dbMan.ExecuteNonQuery(query);

        }
        public int Updatevendor(int vendor_ID, string vendor_name, int rating, string address, string phone, string email, string service)
        {
            string query = "UPDATE vendor SET vendor_ID='" + vendor_ID + "' , vendor_name='" + vendor_name + "' , rating='" + rating + "' , vendor_address='" + address + "' , phone='" + phone + "' , email='" + email + "' WHERE vendor_ID= '" +vendor_ID + "' ; ";
            string query2 ="UPDATE services_offered SET vendor_ID= '" + vendor_ID + " ' , name_of_service= ' " + service +" ' WHERE vendor_ID= ' " + vendor_ID + " ' ;";
            int result1= dbMan.ExecuteNonQuery(query);
            int result2= dbMan.ExecuteNonQuery(query2);
            int result = result1 + result2;
            return result;
        }
    };
}
