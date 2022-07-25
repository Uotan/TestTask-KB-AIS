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
    public partial class FormCategories : Form
    {
        CategoriesControllerSQL _providerSQL;
        string _selectedCategoryId = null;
        List<Category> _categoriesList;

        public FormCategories()
        {
            InitializeComponent();
            _providerSQL = new CategoriesControllerSQL(@"data\data.db");
        }

        private void FormCategories_Load(object sender, EventArgs e)
        {
            ShowCategories(null,null);
        }


        /// <summary>
        /// Передай нулевые параметры, чтобы получить список всех категорий
        /// </summary>
        /// <param name="_categoryPartOfNAme"></param>
        void ShowCategories(string _categoryPartOfNAme, string _categoryID)
        {
            if (String.IsNullOrEmpty(_categoryPartOfNAme) && _selectedCategoryId != null)
            {
                _categoriesList = _providerSQL.GetCategories(_selectedCategoryId);
                dataGridCategories.DataSource = _categoriesList;
                dataGridCategories.RowTemplate.Height = 30;
                dataGridCategories.AutoResizeColumns();
                dataGridCategories.AutoResizeRows();
            }
            else
            {
                _categoriesList = _providerSQL.GetCategories(_categoryPartOfNAme);
                dataGridCategories.DataSource = _categoriesList;
                dataGridCategories.RowTemplate.Height = 30;
                dataGridCategories.AutoResizeColumns();
                dataGridCategories.AutoResizeRows();
            }

        }

        private void dataGridCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {



                btnAddCAtegory.Enabled = false;
                int index = e.RowIndex;// get the Row Index
                DataGridViewRow selectedRow = dataGridCategories.Rows[index];


                _selectedCategoryId = selectedRow.Cells[0].Value.ToString();



                labelID.Text = "ID: " + selectedRow.Cells[0].Value.ToString();
                tbNameCategory.Text = selectedRow.Cells[1].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddCAtegory_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbNameCategory.Text))
            {
                _providerSQL.AddCategory(tbNameCategory.Text);
                tbNameCategory.Text = null;
                ShowCategories(null,null);
            }
        }
    }
}
