﻿using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;

namespace bnn.DataAccessLibrary
{
    class DataAccess
    {
        public static string SQL_CONNECTION_STRING =
            "Filename = song_manager.db";
        public static void InitializeDatabase()
        {
            using (SqliteConnection db =
                new SqliteConnection(SQL_CONNECTION_STRING))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT " +
                                      "EXISTS Songs ( id INTEGER PRIMARY KEY, " +
                                      "name NVARCHAR(150) ,thumbnail NVARCHAR(2048)";


                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();
            }
        }
        
    }
}
