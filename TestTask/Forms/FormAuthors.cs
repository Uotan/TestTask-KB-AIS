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
        AuthorControllerSQL _providerSQL;
        string _selectedAuthorfId = null;
        List<Author> _authorsList;

        public FormAuthors()
        {
            InitializeComponent();
            _providerSQL = new AuthorControllerSQL(@"data\data.db");
        }

        private void FormTags_Load(object sender, EventArgs e)
        {
            ShowAuthors();
        }

        void ShowAuthors()
        {
            _authorsList = _providerSQL.GetAuthors();
            dataGridAuthor.DataSource = _authorsList;
            dataGridAuthor.RowTemplate.Height = 30;
            dataGridAuthor.AutoResizeColumns();
            dataGridAuthor.AutoResizeRows();

        }

        private void dataGridAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {



                //btnAddTag.Enabled = false;

                int index = e.RowIndex;// get the Row Index
                DataGridViewRow selectedRow = dataGridAuthor.Rows[index];


                _selectedAuthorfId = selectedRow.Cells[0].Value.ToString();

                //tbNameCategory.Text = selectedRow.Cells[1].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbNameAuthor.Text))
            {
                _providerSQL.AddAuthor(tbNameAuthor.Text);
                tbNameAuthor.Text = null;
                ShowAuthors();
            }
        }

        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Удалить выбранного автора?",
        "Внимание",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning,
        MessageBoxDefaultButton.Button1);

            if (result != DialogResult.Yes)
            {
                return;
            }
            _providerSQL.DeleteAuthor(_selectedAuthorfId);
            ShowAuthors();
        }
    }
}
