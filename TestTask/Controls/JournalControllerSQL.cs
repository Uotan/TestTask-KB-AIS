using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Models;

namespace TestTask.Controls
{
    public class JournalControllerSQL
    {
        string _path;
        public JournalControllerSQL(string _path)
        {
            this._path = _path;
        }

        public List<JournalEntry> GetJournalEntries()
        {


            var _connection = new SQLiteConnection("DataSource=" + _path);


            List<JournalEntry> _journalEntries = new List<JournalEntry>();

            SQLiteCommand command = new SQLiteCommand();
            command.Connection = _connection;

            command.CommandText = "SELECT * From journal";

            //SQLiteParameter boo = new SQLiteParameter("@book_id", _bookID);
            //command.Parameters.Add(bookIdentifierParam);


            _connection.Open();

            using (SQLiteDataReader readerSQL = command.ExecuteReader())
            {
                if (readerSQL.HasRows)
                {
                    while (readerSQL.Read())
                    {
                        JournalEntry _entry = new JournalEntry();
                        _entry.Id = Convert.ToInt32(readerSQL.GetValue(0));
                        _entry.BookId = Convert.ToInt32(readerSQL.GetValue(1));
                        _entry.ReaderID = Convert.ToInt32(readerSQL.GetValue(2));
                        _entry.DateStart = DateTime.Parse(readerSQL.GetValue(3).ToString());
                        _entry.DateEnd = DateTime.Parse(readerSQL.GetValue(4).ToString());
                        _entry.Returned = bool.Parse(readerSQL.GetValue(5).ToString());
                        _journalEntries.Add(_entry);
                    }
                }
            }


            _connection.Close();
            return _journalEntries;
        }

        public JournalEntry GetJournalEntry(string _ID)
        {


            var _connection = new SQLiteConnection("DataSource=" + _path);


            JournalEntry _journalEntry = new JournalEntry();

            SQLiteCommand command = new SQLiteCommand();
            command.Connection = _connection;

            command.CommandText = "SELECT * From journal where id=@id";

            SQLiteParameter EntryIdParam = new SQLiteParameter("@id", _ID);
            command.Parameters.Add(EntryIdParam);


            _connection.Open();

            using (SQLiteDataReader readerSQL = command.ExecuteReader())
            {
                if (readerSQL.HasRows)
                {
                    while (readerSQL.Read())
                    {
                        _journalEntry.Id = Convert.ToInt32(readerSQL.GetValue(0));
                        _journalEntry.BookId = Convert.ToInt32(readerSQL.GetValue(1));
                        _journalEntry.ReaderID = Convert.ToInt32(readerSQL.GetValue(2));
                        _journalEntry.DateStart = DateTime.Parse(readerSQL.GetValue(3).ToString());
                        _journalEntry.DateEnd = DateTime.Parse(readerSQL.GetValue(4).ToString());
                        _journalEntry.Returned = bool.Parse(readerSQL.GetValue(5).ToString());
                    }
                }
            }


            _connection.Close();
            return _journalEntry;
        }

        public object AddEntry(string _bookId,string _readerId, string _startDate, string _endDate, string _returned)
        {


            var _connection = new SQLiteConnection("DataSource=" + _path);


            SQLiteCommand command = new SQLiteCommand();
            command.Connection = _connection;

            command.CommandText = "INSERT INTO journal (book_id,reader_id,start_date,end_date,returned) VALUES (@book_id, @reader_id, @start_date, @end_date,@returned);SELECT last_insert_rowid();";

            SQLiteParameter bookIdParam = new SQLiteParameter("@book_id", _bookId);
            command.Parameters.Add(bookIdParam);

            SQLiteParameter readerIdParam = new SQLiteParameter("@reader_id", _readerId);
            command.Parameters.Add(readerIdParam);

            SQLiteParameter startDateParam = new SQLiteParameter("@start_date", _startDate);
            command.Parameters.Add(startDateParam);

            SQLiteParameter endDateParam = new SQLiteParameter("@end_date", _endDate);
            command.Parameters.Add(endDateParam);

            SQLiteParameter returnedParam = new SQLiteParameter("@returned", _returned);
            command.Parameters.Add(returnedParam);


            _connection.Open();

            object avgInsertedEntry = command.ExecuteScalar();

            _connection.Close();

            return avgInsertedEntry;
        }


        public void UpdateEntry(string _entryID,string _bookId, string _readerId, string _startDate, string _endDate, string _returned)
        {


            var _connection = new SQLiteConnection("DataSource=" + _path);


            SQLiteCommand command = new SQLiteCommand();
            command.Connection = _connection;

            command.CommandText = "UPDATE journal SET book_id=@book_id,reader_id=@reader_id,start_date=@start_date,end_date=@end_date,returned=@returned WHERE id=@id";

            SQLiteParameter entryIdParam = new SQLiteParameter("@id", _entryID);
            command.Parameters.Add(entryIdParam);

            SQLiteParameter bookIdParam = new SQLiteParameter("@book_id", _bookId);
            command.Parameters.Add(bookIdParam);

            SQLiteParameter readerIdParam = new SQLiteParameter("@reader_id", _readerId);
            command.Parameters.Add(readerIdParam);

            SQLiteParameter startDateParam = new SQLiteParameter("@start_date", _startDate);
            command.Parameters.Add(startDateParam);

            SQLiteParameter endDateParam = new SQLiteParameter("@end_date", _endDate);
            command.Parameters.Add(endDateParam);

            SQLiteParameter returnedParam = new SQLiteParameter("@returned", _returned);
            command.Parameters.Add(returnedParam);


            _connection.Open();

            command.ExecuteNonQuery();

            _connection.Close();

        }

        public List<JournalEntry> GetJournalEntriesByBookID(string _bookId)
        {


            var _connection = new SQLiteConnection("DataSource=" + _path);


            List<JournalEntry> _journalEntries = new List<JournalEntry>();

            SQLiteCommand command = new SQLiteCommand();
            command.Connection = _connection;

            command.CommandText = "SELECT * From journal where book_id LIKE \'%" + _bookId + "%\'";

            //SQLiteParameter boo = new SQLiteParameter("@book_id", _bookID);
            //command.Parameters.Add(bookIdentifierParam);


            _connection.Open();

            using (SQLiteDataReader readerSQL = command.ExecuteReader())
            {
                if (readerSQL.HasRows)
                {
                    while (readerSQL.Read())
                    {
                        JournalEntry _entry = new JournalEntry();
                        _entry.Id = Convert.ToInt32(readerSQL.GetValue(0));
                        _entry.BookId = Convert.ToInt32(readerSQL.GetValue(1));
                        _entry.ReaderID = Convert.ToInt32(readerSQL.GetValue(2));
                        _entry.DateStart = DateTime.Parse(readerSQL.GetValue(3).ToString());
                        _entry.DateEnd = DateTime.Parse(readerSQL.GetValue(4).ToString());
                        _entry.Returned = bool.Parse(readerSQL.GetValue(5).ToString());
                        _journalEntries.Add(_entry);
                    }
                }
            }


            _connection.Close();
            return _journalEntries;
        }

        public List<JournalEntry> GetJournalEntriesByReaderID(string _readerId)
        {


            var _connection = new SQLiteConnection("DataSource=" + _path);


            List<JournalEntry> _journalEntries = new List<JournalEntry>();

            SQLiteCommand command = new SQLiteCommand();
            command.Connection = _connection;

            command.CommandText = "SELECT * From journal where reader_id LIKE \'%" + _readerId + "%\'";

            //SQLiteParameter boo = new SQLiteParameter("@book_id", _bookID);
            //command.Parameters.Add(bookIdentifierParam);


            _connection.Open();

            using (SQLiteDataReader readerSQL = command.ExecuteReader())
            {
                if (readerSQL.HasRows)
                {
                    while (readerSQL.Read())
                    {
                        JournalEntry _entry = new JournalEntry();
                        _entry.Id = Convert.ToInt32(readerSQL.GetValue(0));
                        _entry.BookId = Convert.ToInt32(readerSQL.GetValue(1));
                        _entry.ReaderID = Convert.ToInt32(readerSQL.GetValue(2));
                        _entry.DateStart = DateTime.Parse(readerSQL.GetValue(3).ToString());
                        _entry.DateEnd = DateTime.Parse(readerSQL.GetValue(4).ToString());
                        _entry.Returned = bool.Parse(readerSQL.GetValue(5).ToString());
                        _journalEntries.Add(_entry);
                    }
                }
            }


            _connection.Close();
            return _journalEntries;
        }
    }
}
