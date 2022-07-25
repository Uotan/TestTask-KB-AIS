﻿using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Models;

namespace TestTask.Controls
{
    public class CategoriesControllerSQL
    {
        string _path;
        public CategoriesControllerSQL(string _path)
        {
            this._path = _path;
        }

        public List<Category> GetCategories()
        {


            var _connection = new SQLiteConnection("DataSource=" + _path);


            List<Category> _categoriesList = new List<Category>();

            SQLiteCommand command = new SQLiteCommand();
            command.Connection = _connection;

            command.CommandText = "Select * From categories";


            _connection.Open();

            using (SQLiteDataReader readerSQL = command.ExecuteReader())
            {
                if (readerSQL.HasRows)
                {
                    while (readerSQL.Read())
                    {
                        Category category = new Category();
                        category.Id = readerSQL.GetValue(0).ToString();
                        category.Name = readerSQL.GetValue(1).ToString();
                        _categoriesList.Add(category);
                    }
                }
            }

            _connection.Close();
            return _categoriesList;
        }

        public object AddCategory(string _nameCategory)
        {
            var _connection = new SQLiteConnection("DataSource=" + _path);


            SQLiteCommand command = new SQLiteCommand();
            command.Connection = _connection;
            command.CommandText = "INSERT INTO categories (name_category) VALUES (@name_category);SELECT last_insert_rowid();";

            SQLiteParameter reg_dateParam = new SQLiteParameter("@name_category", _nameCategory);
            command.Parameters.Add(reg_dateParam);

            _connection.Open();

            object avgInsertedReader = command.ExecuteScalar();

            _connection.Close();

            return avgInsertedReader;
        }

        public void DeleteCategory(string _id)
        {
            var _connection = new SQLiteConnection("DataSource=" + _path);


            SQLiteCommand command = new SQLiteCommand();
            command.Connection = _connection;

            command.CommandText = "DELETE FROM categories where id=@id";

            SQLiteParameter idParam = new SQLiteParameter("@id", _id);
            command.Parameters.Add(idParam);

            _connection.Open();

            command.ExecuteNonQuery();

            _connection.Close();
        }
    }
}
