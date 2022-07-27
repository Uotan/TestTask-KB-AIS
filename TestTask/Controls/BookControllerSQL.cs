﻿using System.Data.SQLite;
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
                "INNER Join shelves on shelves.id = book.shelf_id ";


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

        public Book GetBook(string _idBook)
        {


            var _connection = new SQLiteConnection("DataSource=" + _path);


            Book _book = new Book();

            SQLiteCommand command = new SQLiteCommand();
            command.Connection = _connection;



            command.CommandText = "Select book.id,book.name, authors.name,shelves.name,book.reader_id, book.image_path From book " +
                "INNER Join authors on authors.id = book.author_id " +
                "INNER Join shelves on shelves.id = book.shelf_id where book.id=@idBook";


            SQLiteParameter nameParam = new SQLiteParameter("@idBook", _idBook);
            command.Parameters.Add(nameParam);

            _connection.Open();

            using (SQLiteDataReader readerSQL = command.ExecuteReader())
            {
                if (readerSQL.HasRows)
                {
                    while (readerSQL.Read())
                    {
                        _book.Id = readerSQL.GetValue(0).ToString();
                        _book.Name = readerSQL.GetValue(1).ToString();
                        _book.Author = readerSQL.GetValue(2).ToString();
                        _book.Shelf = readerSQL.GetValue(3).ToString();
                        _book.Reader = readerSQL.GetValue(4).ToString();
                        _book.ImagePath = readerSQL.GetValue(5).ToString();
                    }
                }
            }

            _connection.Close();
            return _book;
        }

        public object AddBook(string _nameBook, string _authorId, string _shelfId)
        {
            var _connection = new SQLiteConnection("DataSource=" + _path);


            SQLiteCommand command = new SQLiteCommand();
            command.Connection = _connection;
            command.CommandText = "INSERT INTO book (name,author_id,shelf_id) VALUES (@name, @authorId, @shelfId);SELECT last_insert_rowid();";

            SQLiteParameter nameParam = new SQLiteParameter("@name", _nameBook);
            command.Parameters.Add(nameParam);

            SQLiteParameter authorIdentifireParam = new SQLiteParameter("@authorId", _authorId);
            command.Parameters.Add(authorIdentifireParam);

            SQLiteParameter shelfIdentifierParam = new SQLiteParameter("@shelfId", _shelfId);
            command.Parameters.Add(shelfIdentifierParam);

            _connection.Open();

            object avgInsertedReader = command.ExecuteScalar();

            _connection.Close();

            return avgInsertedReader;
        }

        public void UpdateBookImage(string _id, string _imagePath)
        {
            var _connection = new SQLiteConnection("DataSource=" + _path);


            SQLiteCommand command = new SQLiteCommand();
            command.Connection = _connection;

            command.CommandText = "UPDATE book SET image_path=@imagePath WHERE id=@id";

            SQLiteParameter idParam = new SQLiteParameter("@id", _id);
            command.Parameters.Add(idParam);

            SQLiteParameter imagePathParam = new SQLiteParameter("@imagePath", _imagePath);
            command.Parameters.Add(imagePathParam);

            _connection.Open();

            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void DeleteBook(string _id)
        {
            var _connection = new SQLiteConnection("DataSource=" + _path);


            SQLiteCommand command = new SQLiteCommand();
            command.Connection = _connection;

            command.CommandText = "DELETE FROM readers where id=@id";

            SQLiteParameter idParam = new SQLiteParameter("@id", _id);
            command.Parameters.Add(idParam);

            _connection.Open();

            command.ExecuteNonQuery();

            _connection.Close();
        }
    }
}
