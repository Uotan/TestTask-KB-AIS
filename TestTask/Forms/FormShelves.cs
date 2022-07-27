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
    public partial class FormShelves : Form
    {
        ShelfControllerSQL _providerSQL;
        string _selectedShelfId = null;
        List<Shelf> _tagsList;

        public FormShelves()
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
            _tagsList = _providerSQL.GetShelves();
            dataGridShelves.DataSource = _tagsList;
            //dataGridShelves.RowTemplate.Height = 30;
            //dataGridShelves.AutoResizeColumns();
            //dataGridShelves.AutoResizeRows();

        }


        private void btnAddShelf_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbNameShelf.Text))
            {
                _providerSQL.AddShelf(tbNameShelf.Text);
                tbNameShelf.Text = null;
                ShowTags();
            }
        }

        private void dataGridShelves_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {



                //btnAddTag.Enabled = false;

                int index = e.RowIndex;// get the Row Index
                DataGridViewRow selectedRow = dataGridShelves.Rows[index];


                _selectedShelfId = selectedRow.Cells[0].Value.ToString();

                //tbNameCategory.Text = selectedRow.Cells[1].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteShelf_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Удалить выбранную полку?",
        "Внимание",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning,
        MessageBoxDefaultButton.Button1);

            if (result != DialogResult.Yes)
            {
                return;
            }
            _providerSQL.DeleteShelf(_selectedShelfId);
            ShowTags();
        }
    }
}
