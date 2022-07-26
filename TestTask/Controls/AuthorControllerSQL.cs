using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Models;

namespace TestTask.Controls
{
    public class AuthorControllerSQL
    {
        string _path;
        public AuthorControllerSQL(string _path)
        {
            this._path = _path;
        }

        public List<Author> GetAuthors()
        {


            var _connection = new SQLiteConnection("DataSource=" + _path);


            List<Author> _authorList = new List<Author>();

            SQLiteCommand command = new SQLiteCommand();
            command.Connection = _connection;

            command.CommandText = "Select * From authors";


            _connection.Open();

            using (SQLiteDataReader readerSQL = command.ExecuteReader())
            {
                if (readerSQL.HasRows)
                {
                    while (readerSQL.Read())
                    {
                        Author author = new Author();
                        author.Id = readerSQL.GetValue(0).ToString();
                        author.Name = readerSQL.GetValue(1).ToString();
                        _authorList.Add(author);
                    }
                }
            }

            _connection.Close();
            return _authorList;
        }

        public object AddAuthor(string _nameCategory)
        {
            var _connection = new SQLiteConnection("DataSource=" + _path);


            SQLiteCommand command = new SQLiteCommand();
            command.Connection = _connection;
            command.CommandText = "INSERT INTO authors (name) VALUES (@name_author);SELECT last_insert_rowid();";

            SQLiteParameter nameAuthorParam = new SQLiteParameter("@name_author", _nameCategory);
            command.Parameters.Add(nameAuthorParam);

            _connection.Open();

            object avgInsertedReader = command.ExecuteScalar();

            _connection.Close();

            return avgInsertedReader;
        }

        public void DeleteAuthor(string _id)
        {
            var _connection = new SQLiteConnection("DataSource=" + _path);


            SQLiteCommand command = new SQLiteCommand();
            command.Connection = _connection;

            command.CommandText = "DELETE FROM authors where id=@id";

            SQLiteParameter idParam = new SQLiteParameter("@id", _id);
            command.Parameters.Add(idParam);

            _connection.Open();

            command.ExecuteNonQuery();

            _connection.Close();
        }
    }
}
