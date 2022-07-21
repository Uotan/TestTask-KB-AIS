using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Models
{
    public class Reader
    {
        public string Id { get; set; }
        public string RegDate { get; set; }
        public string FullName { get; set; }
        public string Birthday { get; set; }
        public string ImagePath
        {
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    if (File.Exists(value))
                    {
                        ReaderPicture = Image.FromFile(value);
                    }
                }
            }
        }
        public Image ReaderPicture { get; set; }
    }
}
