using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Controls;
using TestTask.Models;
using System.Windows.Forms;

namespace TestTask.Forms
{
    public partial class FormReaders : Form
    {
        SQLiteController providerSQL;
        public FormReaders()
        {
            InitializeComponent();
            providerSQL = new SQLiteController(@"data\data.db"); 
        }

        private void FormReaders_Load(object sender, EventArgs e)
        {
            List<Reader> list = providerSQL.GetReaders();
            dataGridView1.DataSource = list;
        }
    }
}
