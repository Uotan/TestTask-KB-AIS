using System.Data.SQLite;
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

        public List<Reader> GetReaders(string _readerName)
        {
            

            var _connection = new SQLiteConnection("DataSource="+_path);


            List<Reader> readers = new List<Reader>();
            
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = _connection;


            if (String.IsNullOrEmpty(_readerName))
            {
                command.CommandText = "Select * From readers";
            }
            else
            {
                //не хочет подсовывать параметр - потенциальная уязвимость

                //command.CommandText = "SELECT * FROM readers where fullname LIKE \'%@reader_name%\'";
                //command.CommandText = "SELECT * FROM readers where fullname LIKE \'%Дмитрий%\'";
                command.CommandText = "SELECT * FROM readers where fullname LIKE \'%"+_readerName+"%\'";
                
            }

            //SQLiteParameter readerNameParam = new SQLiteParameter("@reader_name", _readerName);
            //command.Parameters.Add(readerNameParam);

            _connection.Open();

            using (SQLiteDataReader readerSQL = command.ExecuteReader())
            {
                if (readerSQL.HasRows)
                {
                    while (readerSQL.Read())
                    {
                        Reader r = new Reader();
                        r.Id = readerSQL.GetValue(0).ToString();
                        r.RegDate = readerSQL.GetValue(1).ToString();
                        r.FullName = readerSQL.GetValue(2).ToString();
                        r.Birthday = readerSQL.GetValue(3).ToString();
                        r.ImagePath = readerSQL.GetValue(4).ToString();
                        readers.Add(r);
                    }
                }
            }

            _connection.Close();
            return readers;
        }
        public object AddReader(string _reg_date, string _fullname, string _birthday, string _image_path)
        {
            var _connection = new SQLiteConnection("DataSource=" + _path);


            SQLiteCommand command = new SQLiteCommand();
            command.Connection = _connection;
            command.CommandText = "INSERT INTO readers (reg_date, fullname, birthday, image_path) VALUES (@reg_date, @fullname, @birthday, @image_path);SELECT last_insert_rowid();";
            
            SQLiteParameter reg_dateParam = new SQLiteParameter("@reg_date", _reg_date);
            command.Parameters.Add(reg_dateParam);

            SQLiteParameter fullnameParam = new SQLiteParameter("@fullname", _fullname);
            command.Parameters.Add(fullnameParam);

            SQLiteParameter birthdayParam = new SQLiteParameter("@birthday", _birthday);
            command.Parameters.Add(birthdayParam);

            SQLiteParameter image_pathParam = new SQLiteParameter("@image_path", _image_path);
            command.Parameters.Add(image_pathParam);

            _connection.Open();

            object avgInsertedReader = command.ExecuteScalar();

            _connection.Close();

            return avgInsertedReader;
        }

        public void UpdateReaderImage(string _id, string _imagePath)
        {
            var _connection = new SQLiteConnection("DataSource=" + _path);


            SQLiteCommand command = new SQLiteCommand();
            command.Connection = _connection;
            
            command.CommandText = "UPDATE readers SET image_path=@imagePath WHERE id=@id";

            SQLiteParameter idParam = new SQLiteParameter("@id", _id);
            command.Parameters.Add(idParam);

            SQLiteParameter imagePathParam = new SQLiteParameter("@imagePath", _imagePath);
            command.Parameters.Add(imagePathParam);

            _connection.Open();

            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void DeleteReader(string _id)
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

        public void UpdateReaderData(string _id, string _birthDay, string _fullName, string _imagePath)
        {
            var _connection = new SQLiteConnection("DataSource=" + _path);


            SQLiteCommand command = new SQLiteCommand();
            command.Connection = _connection;

            command.CommandText = "UPDATE readers SET image_path=@imagePath, fullname=@fullName, birthday=@birthDay WHERE id=@id";

            SQLiteParameter idParam = new SQLiteParameter("@id", _id);
            command.Parameters.Add(idParam);

            SQLiteParameter imagePathParam = new SQLiteParameter("@imagePath", _imagePath);
            command.Parameters.Add(imagePathParam);

            SQLiteParameter birthDayParam = new SQLiteParameter("@birthDay", _birthDay);
            command.Parameters.Add(birthDayParam);

            SQLiteParameter fullNameParam = new SQLiteParameter("@fullName", _fullName);
            command.Parameters.Add(fullNameParam);

            _connection.Open();

            command.ExecuteNonQuery();

            _connection.Close();
        }
    }
}
