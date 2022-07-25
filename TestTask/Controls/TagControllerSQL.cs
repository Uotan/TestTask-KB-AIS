using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Models;

namespace TestTask.Controls
{
    public class TagControllerSQL
    {
        string _path;
        public TagControllerSQL(string _path)
        {
            this._path = _path;
        }

        public List<Tag> GetTags()
        {


            var _connection = new SQLiteConnection("DataSource=" + _path);


            List<Tag> _tagsList = new List<Tag>();

            SQLiteCommand command = new SQLiteCommand();
            command.Connection = _connection;

            command.CommandText = "Select * From tags";


            _connection.Open();

            using (SQLiteDataReader readerSQL = command.ExecuteReader())
            {
                if (readerSQL.HasRows)
                {
                    while (readerSQL.Read())
                    {
                        Tag tag = new Tag();
                        tag.Id = readerSQL.GetValue(0).ToString();
                        tag.Name = readerSQL.GetValue(1).ToString();
                        _tagsList.Add(tag);
                    }
                }
            }

            _connection.Close();
            return _tagsList;
        }

        public object AddTag(string _nameTag)
        {
            var _connection = new SQLiteConnection("DataSource=" + _path);


            SQLiteCommand command = new SQLiteCommand();
            command.Connection = _connection;
            command.CommandText = "INSERT INTO tags (name_tag) VALUES (@name_tag);SELECT last_insert_rowid();";

            SQLiteParameter tagNameParam = new SQLiteParameter("@name_tag", _nameTag);
            command.Parameters.Add(tagNameParam);

            _connection.Open();

            object avgInsertedReader = command.ExecuteScalar();

            _connection.Close();

            return avgInsertedReader;
        }

        public void DeleteTag(string _id)
        {
            var _connection = new SQLiteConnection("DataSource=" + _path);


            SQLiteCommand command = new SQLiteCommand();
            command.Connection = _connection;

            command.CommandText = "DELETE FROM tags where id=@id";

            SQLiteParameter idParam = new SQLiteParameter("@id", _id);
            command.Parameters.Add(idParam);

            _connection.Open();

            command.ExecuteNonQuery();

            _connection.Close();
        }
    }
}
