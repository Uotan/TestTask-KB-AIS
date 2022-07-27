using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Models;

namespace TestTask.Controls
{
    public class BookCategAndTagController
    {
        string _path;
        public BookCategAndTagController(string _path)
        {
            this._path = _path;
        }

        public List<TagToBookRef> GetTagsOfBook(string _bookID)
        {


            var _connection = new SQLiteConnection("DataSource=" + _path);


            List<TagToBookRef> _tagList = new List<TagToBookRef>();

            SQLiteCommand command = new SQLiteCommand();
            command.Connection = _connection;

            command.CommandText = "SELECT boot_to_tag.id,boot_to_tag.book_id,tags.name_tag From boot_to_tag INNER JOIN tags on tags.id = boot_to_tag.tag_id WHERE book_id =@book_id";

            SQLiteParameter bookIdentifierParam = new SQLiteParameter("@book_id", _bookID);
            command.Parameters.Add(bookIdentifierParam);


            _connection.Open();

            using (SQLiteDataReader readerSQL = command.ExecuteReader())
            {
                if (readerSQL.HasRows)
                {
                    while (readerSQL.Read())
                    {
                        TagToBookRef tag = new TagToBookRef()
;                       tag.Id = readerSQL.GetValue(0).ToString();
;                       tag.BookId = readerSQL.GetValue(1).ToString();
;                       tag.TagName = readerSQL.GetValue(2).ToString();
                        _tagList.Add(tag);
                    }
                }
            }


            _connection.Close();
            return _tagList;
        }

        //public List<Category> GetCategoriesOfBook()
        //{


        //    var _connection = new SQLiteConnection("DataSource=" + _path);


        //    List<Author> _authorList = new List<Author>();

        //    SQLiteCommand command = new SQLiteCommand();
        //    command.Connection = _connection;

        //    command.CommandText = "Select * From authors";


        //    _connection.Open();

        //    using (SQLiteDataReader readerSQL = command.ExecuteReader())
        //    {
        //        if (readerSQL.HasRows)
        //        {
        //            while (readerSQL.Read())
        //            {
        //                Author author = new Author();
        //                author.Id = readerSQL.GetValue(0).ToString();
        //                author.Name = readerSQL.GetValue(1).ToString();
        //                _authorList.Add(author);
        //            }
        //        }
        //    }

        //    _connection.Close();
        //    return _authorList;
        //}
    }
}
