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
using System.Net;
using DataBase_project;
using System.Runtime.InteropServices;
using System;
using System.Data.SqlClient;

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
        public int login_username_check(string username)
        {
            string query = $"SELECT employee_ID FROM employee WHERE username = '{username}'";
            var employee = dbMan.ExecuteScalar(query);
            string query1 = $"SELECT client_ID FROM client WHERE username= '{username}'";
            var client = dbMan.ExecuteScalar(query1); 
            if (employee == null && client==null)
            {
                return -1;
            }
            else if (employee == null)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
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
            var result = dbMan.ExecuteScalar(query);
            if (result == null)
            {
                return -1;
            }
            else
            {
                return (int)dbMan.ExecuteScalar(query);
            }
        }
         public void change_pass_c(string username,string pass)
        {
            string query = $"UPDATE client SET password='{pass}' WHERE username='{username}' ";
            dbMan.ExecuteNonQuery(query);
        }

        public void change_pass_e(string username, string pass)
        {
            string query = $"UPDATE employee SET password='{pass}' WHERE username='{username}' ";
            dbMan.ExecuteNonQuery(query);
        }

        public int get_dep_id(string user)
        {
            string query = $"SELECT dep_ID FROM employee WHERE username= '{user}' ;";
            return (int)dbMan.ExecuteScalar(query);
        }

        public DataTable client_events(int client_id)
        {
            string query = $"SELECT * FROM event WHERE client_ID={client_id} ";
            return dbMan.ExecuteReader(query);
        }

        public string get_employee_fname(int eventid)
        {
            string query = $"SELECT fname FROM employee,event WHERE event_ID={eventid} AND employee.employee_ID = event.employee_ID ";
            return dbMan.ExecuteScalar(query).ToString();
        }

        public string get_employee_lname(int eventid)
        {
            string query = $"SELECT lname FROM employee,event WHERE event_ID={eventid} AND employee.employee_ID = event.employee_ID ";
            return dbMan.ExecuteScalar(query).ToString();
        }

        public int message_count_ec()
        {
            string query = $"SELECT COUNT(*) FROM messages_ec";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int message_count_em()
        {
            string query = $"SELECT COUNT(*) FROM messages_em";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int addmessage_ec(int msg_id , string text ,DateTime time ,int client_id,int employee_id,bool flag)
        {
            string query = $"INSERT into messages_ec VALUES({msg_id},'{text}','{time}',{client_id},{employee_id},'{flag}')";
             return dbMan.ExecuteNonQuery(query);
        }

        public int employee_event(int event_id)
        {
            string query = $"SELECT employee_ID FROM event WHERE event_ID={event_id}";
            return (int)dbMan.ExecuteScalar(query);
        }
        public DataTable get_managers()
        {
            int dep = 6;
            string query = $"SELECT fname,lname,username FROM employee WHERE dep_ID={dep}";
            return dbMan.ExecuteReader(query);
        }
        
        public DataTable get_employee_clients_username(int emp_id)
        {
            int dep = 6;
            string query = $"SELECT DISTINCT client.username FROM client, event, employee WHERE event.employee_ID={emp_id} AND client.client_ID=event.client_ID UNION SELECT username FROM employee WHERE dep_ID={dep} ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable get_employee_clients(int emp_id)
        {
            string query = $"SELECT DISTINCT client.Fname, client.Lname, client.username FROM client, event, employee WHERE event.employee_ID={emp_id} AND client.client_ID=event.client_ID ";
            return dbMan.ExecuteReader(query);
        }
        public int get_emp_id_with_username(string username)
        {
            string query = $"SELECT employee_ID FROM employee WHERE username='{username}'";
            var result =dbMan.ExecuteScalar(query);
            if (result==null)
            {
                return -1;
            }
            else
            {
                return (int)result;
            }
            
        }
        public int get_client_id_with_username(string username)
        {
            string query = $"SELECT client_ID FROM client WHERE username='{username}'";
            var result = dbMan.ExecuteScalar(query);
            if (result == null)
            {
                return -1;
            }
            else
            {
                return (int)result;
            }
        }

        public int addmessage_em(int msg_id, string text, DateTime time, int manager_id, int employee_id, bool flag)
        {
            string query = $"INSERT into messages_em VALUES({msg_id},'{text}','{time}','{flag}',{employee_id},{manager_id})";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable get_employees_for_messages()
        {
            int department = 6;
            string query = $"SELECT fname,lname,username FROM employee WHERE dep_ID != {department}";
            return dbMan.ExecuteReader(query);
        }

        public int get_manager_notif(int manager_id)
        {
            string query = $"SELECT COUNT(*) FROM messages_em WHERE manager_ID='{manager_id}'AND flag=1";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int get_employee_notif(int employee_id)
        {
            string query = $"SELECT COUNT(*) FROM messages_em WHERE employee_ID='{employee_id}'AND flag=0";
            string query2= $"SELECT COUNT(*) FROM messages_ec WHERE employee_ID='{employee_id}'AND client_flag=1";
            return (int)dbMan.ExecuteScalar(query) + (int)dbMan.ExecuteScalar(query2);
        }

        public int get_client_notif(int client_id)
        {
        
            string query = $"SELECT COUNT(*) FROM messages_ec WHERE cliend_ID='{client_id}'AND client_flag=0";
            return (int)dbMan.ExecuteScalar(query);
        }

        public DataTable employee_notifications(int employee_id)
        {
            string query = $"SELECT username,text_msg FROM employee,messages_em WHERE messages_em.employee_ID={employee_id} AND flag=0 AND employee.employee_ID=messages_em.manager_ID UNION SELECT username,text_msg FROM client,messages_ec WHERE messages_ec.employee_ID={employee_id} AND client_flag=1 AND client.client_ID=messages_ec.client_ID";
            return dbMan.ExecuteReader(query);
        }
        public DataTable manager_notifications(int manager_id)
        {
            string query = $"SELECT username,text_msg FROM employee,messages_em WHERE messages_em.manager_ID={manager_id} AND flag=1 AND employee.employee_ID=messages_em.employee_ID";
               
            return dbMan.ExecuteReader(query);
        }

        public DataTable client_notifications(int client_id)
        {
            string query = $"SELECT username,text_msg FROM employee,messages_ec WHERE messages_ec.client_ID={client_id} AND flag=0 AND employee.employee_ID=messages_ec.employee_ID";

            return dbMan.ExecuteReader(query);
        }
        //tarek
        //employee

        //public bool check_login_e(string username, string password)
        //{
        //    string query = $"SELECT passkey FROM employee WHERE username = '{username}'";
        //    string pass = dbMan.ExecuteScalar(query).ToString();
        //    if (pass != password)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}
    
        public void RegisterUser(string username, string plainPassword)
        {
            // Hash the password
            string hashedPassword = PasswordHelper.HashPassword(plainPassword);

            // Construct the SQL query
            string query = $"INSERT INTO employee (username, passkey) VALUES ('{username}', '{hashedPassword}')";

            // Execute the query
            int result = dbMan.ExecuteNonQuery(query);

            if (result > 0)
            {
                MessageBox.Show("User registered successfully.");
            }
            else
            {
                MessageBox.Show("User registration failed.");
            }
        }
        public bool check_login_e(string username, string inputPassword)
        {
            string query = $"SELECT PasswordHash FROM Users WHERE Username = '{username}'";

            DataTable result = dbMan.ExecuteReader(query);

            if (result != null && result.Rows.Count > 0)
            {
                string storedPasswordHash = result.Rows[0]["PasswordHash"].ToString();

                // Verify the password using the helper class
                return PasswordHelper.VerifyPassword(inputPassword, storedPasswordHash);
            }

            return false; // Return false if the user is not found
        }
        public void change_venue(string venuename, int venue_id, int e)
        {
            string query = $"UPDATE event SET venue_ID={venue_id} WHERE event_ID={e}";
            dbMan.ExecuteNonQuery(query);
        }

        public int emp_id(string username)
        {
            string query = $"SELECT employee_ID FROM employee WHERE username = '{username}'";
            var result = dbMan.ExecuteScalar(query);
            if (result == null)
            {
                return -1;
            }
            else
            {
                return (int)dbMan.ExecuteScalar(query);
            }
        }
        public DataTable get_employees()
        {
            string query = "SELECT employee_ID, username FROM employee;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable getserv()
        {
            string query = "SELECT service_id, name_of_service FROM services_offered;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable get_venue()
        {
            string query = "SELECT venue_name, venue_ID FROM venue;";
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
        public int insert_invoice(int invoice_id, int amount, int event_id, int id, int vend, string date)
        {

            string query = $"INSERT INTO invoice (invoice_ID, amount, event_ID, service_ID, vendorid, invoice_date) VALUES ({invoice_id}, {amount}, {event_id}, {id}, {vend}, 'date')"; ;
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable chosen(int id)
        {
            string query = $"SELECT DISTINCT client.Fname, event.eventname, event.event_date, venue.venue_name, client.client_ID, event.no_of_attendees FROM event INNER JOIN client ON event.client_ID = client.client_ID INNER JOIN venue ON event.venue_ID = venue.venue_ID INNER JOIN employee ON event.employee_ID = employee.employee_ID\r\nWHERE \r\n    event.event_ID = {id};\r\n ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable invoice(int id)
        {
            string query = $"SELECT amount, name_of_service, vendor_name FROM vendors, services_offered, event, invoice WHERE invoice.event_ID=event.event_ID AND invoice.event_ID={id} AND services_offered.service_ID=vendors.service_id AND vendors.service_ID=invoice.service_ID;";
            return dbMan.ExecuteReader(query);
        }
        public int get_count()
        {
            string query1 = $"SELECT COUNT(task) FROM task ";
            int count = (int)dbMan.ExecuteScalar(query1);
           return count;
        }
        public int get_ct()
        {
            string query1 = $"SELECT COUNT(client_ID) FROM client ";
            int count = (int)dbMan.ExecuteScalar(query1);
            return count;
        }
        public string get_hashed_password(string username)
        {
            try
            {
                string query = "SELECT passkey FROM client WHERE username = @username";

                using (SqlCommand command = dbMan.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@username", username);

                    var result = command.ExecuteScalar();
                    return result != null ? result.ToString() : string.Empty;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return string.Empty;
            }
        }




        //noor
        //hagat client signup
        public int InsertNewClient(int clientid, string Fname, string Lname, string email, string phone, string username, string passkey)
        {
            string hashedPassword = PasswordHelper.HashPassword(passkey);
            string query = "INSERT INTO client (client_ID, Fname, Lname, email, phone, username,passkey)" +
                            "Values (" + clientid + ",'" + Fname + "','" + Lname + "','" + email + "','"+ phone+"','"+ username+"','"+hashedPassword+"');";
            return dbMan.ExecuteNonQuery(query);
        }
        //haget feedback
        public int InsertFeedback(int feedbackid, int  clientid, string comment, string date, int rating)
        {
            string query = "INSERT INTO feedbacks (feedback_ID, client_ID, comment,feedback_date,rating)" +
                            "Values (" + feedbackid + "," + clientid + ",'" + comment + "','" + date + "'," + rating + ");" ;
            return dbMan.ExecuteNonQuery(query);
        }

        //in employee show all vendors
        public DataTable ShowVendors()
        {
            string query = "SELECT * FROM Vendors;";
            return dbMan.ExecuteReader(query);
        }
        //shows client events datagrid view in clinet_event
        public DataTable ShowClientEvents(int clientid)
        {
            string query = "SELECT event.eventname,event_types.event_type,event.event_date,event.budget,event.no_of_attendees,employee.fname,employee.lname FROM event, event_types,employee WHERE event.client_ID="+clientid+" AND event.event_type=event_types.types_ID AND event.employee_ID=employee.employee_ID;";
            return dbMan.ExecuteReader(query);
        }
        //shows eventnames gowa combox
        public DataTable ShowClientEventsNames(int clientid) 
        {
            string query = "SELECT event.eventname FROM event  WHERE client_ID="+clientid+";";
            return dbMan.ExecuteReader(query);
        }
        //show types of events 3lhsna new event
        public DataTable ShowTypes()
        {
            string query = "SELECT * FROM event_types, venue WHERE ;";
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
        //changes event details from client_event form
        public int change_event_details(int clientid,string eventname, int budget, int noa, string date)
        {
            string query = "UPDATE event\r\nSET eventname = '" + eventname + "', budget=" + budget + ", no_of_attendees=" + noa + ",event_date='" + date + "'WHERE client_ID=" + clientid + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        //gets employee id responsible for event from client id
        public int get_emp_id(int clientid)
        {
            string query = "SELECT employee_ID FROM employee,event WHERE client_ID = "+clientid+" AND employee.client_ID = event.employee_ID";
            return (int)dbMan.ExecuteScalar(query);
        }
        //gets venues
        public DataTable ShowVeneus(int capacity, int price)
        {
            string query = "SELECT venue_name as venue, capacity as maximum_capacity, venue_address as adddress, price FROM venue WHERE capacity>"+capacity+" AND price<"+price+";";
            return dbMan.ExecuteReader(query);
        }
        public DataTable ShowVeneusnames(int capacity, int price)
        {
            string query = "SELECT * FROM venue WHERE capacity>=" + capacity + " AND price=<" + price + ";";
            return dbMan.ExecuteReader(query);
        }
        //insert new event 
        public int InsertEvent(int event_id, int budget, int event_type, string date, int employee_id, int venue_id, int client_id, int noa, string eventname)
        {
            string query = "INSERT INTO event(event_ID, budget, event_type,event_date, employee_id, venue_id, client_id, no_of_attendees, eventname)" +
                "Values("+event_id+", "+budget+","+event_type+", '"+date+"',"+employee_id+","+venue_id+","+client_id+","+noa+", '"+eventname+"'); ";
            return dbMan.ExecuteNonQuery(query);
        }
        //rawan
        //events
        public DataTable AllEvents()
        {
            string query = "SELECT * FROM event;";
            return dbMan.ExecuteReader(query);
        }
        public int eventid(string eventname){
            string query = "SELECT event_ID FROM event WHERE eventname='" + eventname + "';";
            return dbMan.ExecuteNonQuery(query);

        }
      public DataTable EventsList()
       {
            string query = "SELECT * FROM event ;";
            return dbMan.ExecuteReader(query) ;
       }
        public DataTable eventinfo(int eventid)
        {
            string query = "SELECT * FROM event WHERE event_ID=" + eventid + ";";
            return dbMan.ExecuteReader(query);
        }
        public int deleteevent(int eventid)
        {
            string query="DELETE FROM event WHERE event_ID=" + eventid + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        
        public int updatevent(int eventid, int budget, int eventtype, string date, int employee, int venue, int client, int capacity, string eventname)
        {
            string query = "UPDATE event SET event_ID=" + eventid + ", budget=" + budget + ", event_type=" + eventtype + ", event_date='" + date + "' , employee_ID=" + employee + ", venue_ID=" + venue + ", client_ID=" + client + ", no_of_attendees=" + capacity + ", eventname='" + eventname + "' WHERE event_ID= " + eventid + "; ";
            return dbMan.ExecuteNonQuery(query);
        }
        //employees
        public DataTable AllEmployees()     //for datagrid view 
        {
            string query = "SELECT * FROM employee ;";
            return dbMan.ExecuteReader(query);
        }
     
        public DataTable department()          //combobox in hiring 
        {
            string query = "SELECT * FROM departments;";
            return dbMan.ExecuteReader(query);
        }
        public int depid(string depname)
        {
            string query = $"SELECT dep_ID FROM departments WHERE dep_name = '{depname}'";
            var result = dbMan.ExecuteScalar(query);
            if (result == null)
            {
                return -1;
            }
            else
            {
                return (int)dbMan.ExecuteScalar(query);
            }
        }
        public int empid(string employee)
        {
            string query = $"SELECT employee_ID FROM employee WHERE CONCAT(fname,' ',lname)= '{employee}'";
            var result = dbMan.ExecuteScalar(query);
            if (result == null)
            {
                return -1;
            }
            else
            {
                return Convert.ToInt32(result);
            }
        }
        public int InsertNewEmployee(int e_ID, string Fname, string Lname, string email, string phone, string gender, int age, string username, string passkey, int depid)
        {
            string query = "INSERT INTO employee(employee_ID, fname, lname, email, phone, gender, age, username, passkey, dep_ID) " +
                "Values(" + e_ID + ", '" + Fname + "', '" + Lname + "', '" + email + "', '" + phone + "', '" + gender + "'," + age + ", '" + username + "', '" + passkey + "'," + depid + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public int updatemployee(int employeeid , string fname , string lname, string email, string phone, string gender, int age, string username, string passkey, int depid)
        {
            string query = "UPDATE employee SET employee_ID="+employeeid+", fname='"+fname+"', lname='"+lname+"', email='"+email+"', phone='"+phone+"', gender='"+gender+"', age="+age+", username='"+username+"', passkey='"+passkey+"', dep_ID="+depid+" WHERE employee_ID= " + employeeid + " ;";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable Employeesnames()
        {
            string query = "SELECT *,CONCAT(fname,' ',lname) AS name FROM employee ;";
            return dbMan.ExecuteReader(query);
        }
        
        public int DeleteEmployee(int employeeid)
        {
            string query= "DELETE FROM employee WHERE employee_ID=" + employeeid + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        //client
        public DataTable allclients()
        {
            string query = "SELECT client.*, event.eventname, feedbacks.comment FROM client, event, feedbacks WHERE event.client_ID=client.client_ID AND event.client_ID=feedbacks.client_ID ;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable clientnames()
        {
            string query = "SELECT *, CONCAT(Fname, ' ' , Lname) AS name FROM client ;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable clientinfo(int clientid)
        {
            string query = "SELECT * FROM client WHERE client_ID= " + clientid + " ;";
            return dbMan.ExecuteReader(query);
        }
        //event_type
        public DataTable eventtypes()    //for datagrid view
        {
            string query = "SELECT * FROM event_types ;";
            return dbMan.ExecuteReader(query);
        }
        public int addtype(int type_ID, string type_name)     //add a new type 
        {
            string query = "INSERT INTO event_types (types_ID, event_type)" +
                          "Values (" + type_ID + ",'" + type_name +  "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int deletetype(int type_ID)          // delete a type 
        {
            string query = "DELETE FROM event_types WHERE types_ID=" + type_ID + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable typesnames()
        {
            string query = "SELECT * FROM event_types;";
            return dbMan.ExecuteReader(query);
        }
        public int typeid(string typname)
        {
            string query = "SELECT types_ID FROM event_types WHERE event_type='" + typname + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        //vendor
        public DataTable vendorsdetails()
        {
            string query = "SELECT vendors.*, services_offered.name_of_service FROM vendors, services_offered WHERE vendors.vendor_ID = services_offered.vendor_ID ;";
            return dbMan.ExecuteReader(query);
        }
        public int addvendor(int vendor_ID, string vendor_name, int rating, string address, string phone, string email, string service)
        {
            string query = $"INSERT INTO vendors (vendor_ID, vendor_name, rating, vendor_address, phone, email, service_id) VALUES({vendor_ID}, '{vendor_name}', {rating}, '{address}', '{phone}', '{email}', '{service}')";
            /*string query2 = "INSERT INTO services_offered(vendor_ID, name_of_service)"
                + "Values(" + vendor_ID + ",'" + service + "');";*/
            /* int result2=dbMan.ExecuteNonQuery(query2);
             int result = result1 + result2;*/
            return dbMan.ExecuteNonQuery(query);
            
        }

        public int deletevendor(int vendor_ID)
        {
            string query = "DELETE FROM vendors, services_offered WHERE vendors.vendor_ID=services_offered.vendor_ID AND vendors.vendor_ID=" + vendor_ID + ";";
            return dbMan.ExecuteNonQuery(query);

        }
        public int Updatevendor(int vendor_ID, string vendor_name, int rating, string address, string phone, string email, string service)
        {
            string query = "UPDATE vendors SET vendor_ID='" + vendor_ID + "' , vendor_name='" + vendor_name + "' , rating='" + rating + "' , vendor_address='" + address + "' , phone='" + phone + "' , email='" + email + "' WHERE vendor_ID= " +vendor_ID + "; ";
            string query2 ="UPDATE services_offered SET vendor_ID= '" + vendor_ID + " ' , name_of_service= ' " + service +" ' WHERE vendor_ID=  " + vendor_ID + " ;";
            int result1= dbMan.ExecuteNonQuery(query);
            int result2= dbMan.ExecuteNonQuery(query2);
            int result = result1 + result2;
            return result;
        }
        //services
        public DataTable allservices()
        {
            string query = "SELECT * FROM services_offered ;";
            return dbMan.ExecuteReader(query);
        }
        public int addservice(int service_id, int vendor_id, string name_of_service, int invoice_id, int price)
        {
            string query = "INSERT INTO services_offered(service_ID, vendor_ID,name_of_service, invoice_ID,price)" +
                "Values("+ service_id + "," + vendor_id + ",'" + name_of_service + "'," + invoice_id + "," + price + "); ";
            return dbMan.ExecuteNonQuery(query);
        }
        public int deleteservice(int service_ID , int invoiceide)
        {
            string query = "DELETE FROM services_offered WHERE service_ID=" + service_ID + " AND invoice_id=" + invoiceide +";";
            return dbMan.ExecuteNonQuery(query);

        }
        public int Updateservice(int service_ID, int vendor_ID, string name_of_service, int invoice_ID, int price)
        {
            string query = "UPDATE services_offered SET service_ID=" + service_ID + " , vendor_ID=" + vendor_ID + " , name_of_service='" + name_of_service + "' , invoice_id=" + invoice_ID + ", price=" + price + " WHERE service_ID= " + service_ID + " ; ";
            return dbMan.ExecuteNonQuery(query);
        }
        //Goals
        public DataTable goalslist()
        {
            string query = "SELECT goals.*, departments.dep_name FROM goals, departments WHERE departments.dep_ID=goals.dep_ID ;";
            return dbMan.ExecuteReader(query);
        }
        public int setgoal(int goalid, int depid, int goal)
        {
            string query = "INSERT INTO goals(goal_ID, dep_ID, monthly)" +
                "Values(" + goalid + "," + depid + "," + goal + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public int deletegoal(int goalid, int depid)
        {
            string query = "DELETE FROM goals WHERE goal_ID=" + goalid + " AND dep_ID=" + depid + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        //venues 
        public DataTable venuesnames()
        {
            string query = "SELECT * FROM venue;";
            return dbMan.ExecuteReader(query);
        }
        public int capacity(int venue)
        {
            string query = "SELECT capacity FROM venue WHERE venue_ID=" + venue + ";";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int UpdateEvent(int eventid,int budget, int event_type, string date, int employee_id, int venue_id, int client_id, int noa, string eventname)
        {
            string query = "UPDATE event SET budget=" + budget + ", event_type=" + event_type + ",event_date='" + date + "', employee_id=" + employee_id + ", venue_id=" + venue_id + ", client_id=" + client_id + ", no_of_attendees=" + noa + ", eventname='"+ eventname + "'WHERE event_id="+eventid+";";
            return dbMan.ExecuteNonQuery(query);
        }
        
    };
}
