using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTask.Controls;
using TestTask.Models;

namespace TestTask.Forms
{
    public partial class FormAuthors : Form
    {
        ShelfControllerSQL _providerSQL;
        string _selectedAuthorfId = null;
        List<Author> _authorsList;

        public FormAuthors()
        {
            InitializeComponent();
            _providerSQL = new ShelfControllerSQL(@"data\data.db");
        }

        private void FormTags_Load(object sender, EventArgs e)
        {
            ShowTags();
        }

        void ShowTags()
        {
            _authorsList = _providerSQL.GetShelves();
            dataGridAuthor.DataSource = _authorsList;
            dataGridAuthor.RowTemplate.Height = 30;
            dataGridAuthor.AutoResizeColumns();
            dataGridAuthor.AutoResizeRows();

        }

    }
}
