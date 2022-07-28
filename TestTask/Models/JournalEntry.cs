using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Models
{
    public class JournalEntry
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int ReaderID { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public bool Returned { get; set; }
    }
}
