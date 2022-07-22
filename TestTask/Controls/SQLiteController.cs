using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Models;

namespace TestTask.Controls
{
    public class SQLiteController
    {
        string _path;
        //SqliteConnection connection;
        public SQLiteController(string path)
        {
            _path = path;
            //connection = new SqliteConnection(_path);
        }

        public List<Reader> GetReaders()
        {
            var _connection = new SqliteConnection("DataSource=data\\data.db");


            List<Reader> readers = new List<Reader>();
            
            SqliteCommand command = new SqliteCommand();
            command.Connection = _connection;
            command.CommandText = "Select * From readers";

            _connection.Open();

            using (SqliteDataReader readerSQL = command.ExecuteReader())
            {
                if (readerSQL.HasRows)
                {
                    while (readerSQL.Read())
                    {
                        Reader r = new Reader();
                        r.Id = readerSQL.GetValue(1).ToString();
                        r.RegDate = readerSQL.GetValue(1).ToString();
                        r.FullName = readerSQL.GetValue(2).ToString();
                        r.Birthday = readerSQL.GetValue(3).ToString();
                        r.ImagePath = readerSQL.GetValue(4).ToString();
                        readers.Add(r);
                    }
                }
            }
            return readers;
        }

    }
}
