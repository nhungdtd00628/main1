using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bnn.Entity;
using Microsoft.Data.Sqlite;

namespace bnn.DataAccessLibrary
{
    class SongModel
    {
        public static void Add(Song song)
        {
            using (SqliteConnection db = new SqliteConnection(DataAccess.SQL_CONNECTION_STRING))
            {
                db.Open();
                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;
                insertCommand.CommandText = "INSERT INTO Songs (name, thumbnail) VALUES (@name, @thumbnail)";
                insertCommand.Parameters.AddWithValue("@name", song.name);
                insertCommand.Parameters.AddWithValue("@thumbnail", song.thumbnail);
                insertCommand.ExecuteReader();
            }
        }
    }
}
