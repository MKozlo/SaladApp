using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace SaladApp
{
    internal class SaladAppDbContext
    {
        public static SQLiteConnection Connection;
        public static SQLiteCommand Command;

        public static string SaladAppDB = "SaladAppDB.db";
        public static string SaladAppDBConnection = "Data Source=" + SaladAppDB + ";Version=3;New=False;Compress=True;";

        public SQLiteCommand Connect() // connection
        {
            try 
            {
                Connection = new SQLiteConnection(SaladAppDBConnection);
                Connection.Open();
                Command = Connection.CreateCommand();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error with connecting to database: " + ex.Message);
                throw;
            }
            return Command;
        }

        public void Disconnect()
        {
            Connection.Close();
        }
    }
}
