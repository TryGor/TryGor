using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
/*
namespace TryGor
{
    public MySQLConnect
    {
        //Constructor
        //public DBConnect()

        MySQLConnect();
        private void MySQLConnect()
        {
            server = "localhost";
            database = "connectcsharptomysql";
            uid = "username";
            password = "password";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
        }

        //Close connection
        private bool CloseConnection()
        {
        }
    }
}

/*
     // MySqlConnection connection = new MySqlConnection("datasource = localhost; port = 3306; username = root; password = 1977");
      static class MySQLConnection
      {
          private static MySqlConnection connection;
          public static MySqlConnection Connection
          {
              get
              {
                  if (connection.State == ConnectionState.Closed)
                  {
                      string cs = @"Data Source = localhost; port = 3306; Initial Catalog = data; User Id = root; password = 1977";
                      connection = new MySqlConnection(cs);
                  }

                  if (connection.State == ConnectionState.Closed)
                      try
                      {
                          connection.Open();
                      }
                      catch (Exception ex)
                      {
                          //handle your exception here

                      }
                  return connection;
              }
          }
      }
  }*/
