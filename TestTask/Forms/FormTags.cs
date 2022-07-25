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
    public partial class FormTags : Form
    {
        TagControllerSQL _providerSQL;
        string _selectedTagId = null;
        List<Tag> _tagsList;

        public FormTags()
        {
            InitializeComponent();
            _providerSQL = new TagControllerSQL(@"data\data.db");
        }

        private void FormTags_Load(object sender, EventArgs e)
        {
            ShowTags();
        }

        void ShowTags()
        {
            _tagsList = _providerSQL.GetTags();
            dataGridTags.DataSource = _tagsList;
            dataGridTags.RowTemplate.Height = 30;
            dataGridTags.AutoResizeColumns();
            dataGridTags.AutoResizeRows();

        }
    }
}
