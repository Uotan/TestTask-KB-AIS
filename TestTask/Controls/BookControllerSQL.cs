using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Models;

namespace TestTask.Controls
{
    public class BookControllerSQL
    {
        string _path;
        public BookControllerSQL(string _path)
        {
            this._path = _path;
        }

        public List<Book> GetBooks()
        {


            var _connection = new SQLiteConnection("DataSource=" + _path);


            List<Book> _booksList = new List<Book>();

            SQLiteCommand command = new SQLiteCommand();
            command.Connection = _connection;

            command.CommandText = "Select book.id,book.name, authors.name,shelves.name,book.reader_id, book.image_path From book " +
                "INNER Join authors on authors.id = book.author_id " +
                "INNER Join shelves on shelves.id = book.shelf_id " +
                "INNER Join readers on readers.id = book.id";


            _connection.Open();

            using (SQLiteDataReader readerSQL = command.ExecuteReader())
            {
                if (readerSQL.HasRows)
                {
                    while (readerSQL.Read())
                    {
                        Book book = new Book();
                        book.Id = readerSQL.GetValue(0).ToString();
                        book.Name = readerSQL.GetValue(1).ToString();
                        book.Author = readerSQL.GetValue(2).ToString();
                        book.Shelf = readerSQL.GetValue(3).ToString();
                        book.Reader = readerSQL.GetValue(4).ToString();
                        book.ImagePath = readerSQL.GetValue(5).ToString();
                        _booksList.Add(book);
                    }
                }
            }

            _connection.Close();
            return _booksList;
        }

        //public object AddAuthor(string _nameCategory)
        //{
        //    var _connection = new SQLiteConnection("DataSource=" + _path);


        //    SQLiteCommand command = new SQLiteCommand();
        //    command.Connection = _connection;
        //    command.CommandText = "INSERT INTO authors (name) VALUES (@name_author);SELECT last_insert_rowid();";

        //    SQLiteParameter nameAuthorParam = new SQLiteParameter("@name_author", _nameCategory);
        //    command.Parameters.Add(nameAuthorParam);

        //    _connection.Open();

        //    object avgInsertedReader = command.ExecuteScalar();

        //    _connection.Close();

        //    return avgInsertedReader;
        //}

        //public void DeleteAuthor(string _id)
        //{
        //    var _connection = new SQLiteConnection("DataSource=" + _path);


        //    SQLiteCommand command = new SQLiteCommand();
        //    command.Connection = _connection;

        //    command.CommandText = "DELETE FROM authors where id=@id";

        //    SQLiteParameter idParam = new SQLiteParameter("@id", _id);
        //    command.Parameters.Add(idParam);

        //    _connection.Open();

        //    command.ExecuteNonQuery();

        //    _connection.Close();
        //}
    }
}
