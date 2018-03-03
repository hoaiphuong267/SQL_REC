using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Tuyendung.General
{
    public class Employee
    {
        private UserLogin database;
        public bool error;
        private int m_userID ;
        private string m_firstname;
        private string m_lastname;
        private string m_username;
        private string m_password;
        public string EmpError;
        public int UserID
        {
            get { return m_userID; }
            //set { m_userID = value; }
        }
        public string EmployeeFirstName
        {
            get { return m_firstname; }
            set { m_firstname = value; }
        }
        public string EmployeeLastName
        {
            get { return m_lastname; }
            set { m_lastname = value; }
        }


        public string EmployeeUsername
        {
            get { return m_username; }
            set { m_username = value; }
        }
        public string EmployeePassword
        {
            get { return m_password; }
            set { m_password = value; }
        }
        public Employee() { }

        public bool saveEmployee()
        {
            bool kayitDurumu;
            database = UserLogin.getUser();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select Username From Register Where Username = @username";
                cmd.Connection = database.DatabaseConnectionOpen();
                cmd.Parameters.AddWithValue("@username", m_username);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        kayitDurumu = false;
                    }
                    else
                    {
                        reader.Close();
                        kayitDurumu = true;
                        cmd.CommandText = "Insert Into Register(Ho,Ten,Username, Password) Values(@firstname,@lastname, @username, @password)";
                        cmd.Parameters.AddWithValue("@firstname", m_firstname);
                        cmd.Parameters.AddWithValue("@lastname", m_lastname);
                        cmd.Parameters.AddWithValue("@username", m_username);
                        cmd.Parameters.AddWithValue("@password", m_password);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception f)
            {
                kayitDurumu = false;
                EmpError = f.ToString();
            }
            // finally { database.DatabaseConnectionClosed(); }

            return kayitDurumu;
        }
    }
}
