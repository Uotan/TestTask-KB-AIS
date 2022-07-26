using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Models;

namespace TestTask.Controls
{
    public class ShelfControllerSQL
    {
        string _path;
        public ShelfControllerSQL(string _path)
        {
            this._path = _path;
        }

        public List<Shelf> GetShelves()
        {


            var _connection = new SQLiteConnection("DataSource=" + _path);


            List<Shelf> _shelvesList = new List<Shelf>();

            SQLiteCommand command = new SQLiteCommand();
            command.Connection = _connection;

            command.CommandText = "Select * From shelves";


            _connection.Open();

            using (SQLiteDataReader readerSQL = command.ExecuteReader())
            {
                if (readerSQL.HasRows)
                {
                    while (readerSQL.Read())
                    {
                        Shelf shelf = new Shelf();
                        shelf.Id = readerSQL.GetValue(0).ToString();
                        shelf.Name = readerSQL.GetValue(1).ToString();
                        _shelvesList.Add(shelf);
                    }
                }
            }

            _connection.Close();
            return _shelvesList;
        }

        public object AddShelf(string _nameShelf)
        {
            var _connection = new SQLiteConnection("DataSource=" + _path);


            SQLiteCommand command = new SQLiteCommand();
            command.Connection = _connection;
            command.CommandText = "INSERT INTO shelves (name) VALUES (@name_shelf);SELECT last_insert_rowid();";

            SQLiteParameter tagNameParam = new SQLiteParameter("@name_shelf", _nameShelf);
            command.Parameters.Add(tagNameParam);

            _connection.Open();

            object avgInsertedReader = command.ExecuteScalar();

            _connection.Close();

            return avgInsertedReader;
        }

        public void DeleteShelf(string _id)
        {
            var _connection = new SQLiteConnection("DataSource=" + _path);


            SQLiteCommand command = new SQLiteCommand();
            command.Connection = _connection;

            command.CommandText = "DELETE FROM shelves where id=@id";

            SQLiteParameter idParam = new SQLiteParameter("@id", _id);
            command.Parameters.Add(idParam);

            _connection.Open();

            command.ExecuteNonQuery();

            _connection.Close();
        }
    }
}
