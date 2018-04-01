using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Tuyendung.General
{
    public class UserLogin
    {
        SqlConnection myDBconnection = new SqlConnection(@"Data Source = CHAOS-LORD\CHAOS;Initial Catalog=QLTD;Integrated Security=True");
        
        //SqlConnection myDBconnection = new SqlConnection(@"Data Source = .\SQLExpress; Initial Catalog = QLTD;  Integrated Security = True;");
       // SqlConnection myDBconnection = new SqlConnection(@"Data Source = .; Initial Catalog = QLTD;  Integrated Security = True;");

        private static UserLogin _userLogin;
        public string username, password;//bien tam thay cho txtusername,txtpassword
        //public string User_ten;
        public string Error;
        public int User_ID;
        public Stopwatch watch;
        private UserLogin()
        {
            watch = new Stopwatch();
            watch.Start();
        }

        public static UserLogin getUser()
        {
            if (_userLogin == null)
            {
                _userLogin = new UserLogin();
            }

            return _userLogin;
        }
        public SqlConnection DatabaseConnectionOpen()
        {
            if (myDBconnection.State == System.Data.ConnectionState.Closed)
            {
                myDBconnection.Open();
            }

            return myDBconnection;
        }
        public void DatabaseConnectionClosed()
        {
            myDBconnection.Close();
        }
        public bool Login(string _username, string _password)
        {
            username = _username;
            password = _password;
            //so sánh và lấy ra giá trị so sánh cho chuỗi
            string query = "Select * From Register Where Username=@Username and Password=@Password";
            
            try
            {
                myDBconnection.Open();
                SqlCommand cmd = new SqlCommand(query, myDBconnection);
                //khai báo tham số cho txt
                cmd.Parameters.AddWithValue("@Username", _username);
                cmd.Parameters.AddWithValue("@Password", _password);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        //User_ten = reader["Ten"].ToString();
                        User_ID = int.Parse(reader["UserID"].ToString());
                        return true;
                    }
                    else { return false; }
                }

            }
            catch (Exception f)
            {
                Error = "Veritabanı Hatası:\n\n" + f.ToString();
                return false;
            }
            finally
            {
                myDBconnection.Close();
            }
        }
    }
}
    
