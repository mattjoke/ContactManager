using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using Dapper;
using Contact_Manager.Entities;

namespace Contact_Manager
{
    public class DataAcess
    {
        //Loads data from Sqlite database
        public static List<Contact> Load()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Contact>("SELECT * FROM Person", new DynamicParameters());
                List<Contact> a = output.ToList();
                return a;
            }
        }
        //Saves Contact to databaase
        public static void Save(Contact con)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO Person (FirstName, LastName, Email, PhoneNumber) VALUES (@FName, @LName, @MailStr, @PhoneStr)", con);
            }
        }
        //Updates entry in database
        public static void Update(Contact con)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE Person SET FirstName=@FName, LastName=@LName, Email=@MailStr, PhoneNumber=@PhoneStr WHERE id=@ID", con);
            }
        }

        public static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
