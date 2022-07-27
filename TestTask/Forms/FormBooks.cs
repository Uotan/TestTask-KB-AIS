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
    public partial class FormBooks : Form
    {
        CategoriesControllerSQL _providerCategories;
        TagControllerSQL _providerTags;
        BookControllerSQL _providerBooks;
        BookCategAndTagController _providerBookCategAndTag;
        AuthorControllerSQL _providerAuthors;
        ShelfControllerSQL _providerShelves;
        List<Book> _listBooks;

        string pickedImagePath = null;


        public FormBooks()
        {
            InitializeComponent();

            _providerCategories = new CategoriesControllerSQL(@"data\data.db");
            _providerTags = new TagControllerSQL(@"data\data.db");
            _providerBooks = new BookControllerSQL(@"data\data.db");
            _providerBookCategAndTag = new BookCategAndTagController(@"data\data.db");
            _providerAuthors = new AuthorControllerSQL(@"data\data.db");
            _providerShelves = new ShelfControllerSQL(@"data\data.db");

            FillComboboxes();

            ShowData();
        }


        void FillComboboxes()
        {
            List<Category> _categories = _providerCategories.GetCategories();
            List<Tag> _tags = _providerTags.GetTags();


            var bindingSource1 = new BindingSource();
            var bindingSource2 = new BindingSource();
            bindingSource1.DataSource = _categories;
            bindingSource2.DataSource = _tags;

            cmbxCategories.DataSource = bindingSource1.DataSource;
            cmbxTags.DataSource = bindingSource2.DataSource;

            cmbxCategories.DisplayMember = "Name";
            cmbxCategories.ValueMember = "Name";

            cmbxTags.DisplayMember = "Name";
            cmbxTags.ValueMember = "Name";




            List<Author> _authors = _providerAuthors.GetAuthors();
            List<Shelf> _shelves = _providerShelves.GetShelves();


            var bindingSourceAuthors = new BindingSource();
            var bindingSourceShelves = new BindingSource();
            bindingSourceAuthors.DataSource = _authors;
            bindingSourceShelves.DataSource = _shelves;

            cmbxAuthors.DataSource = bindingSourceAuthors.DataSource;
            cmbxShelves.DataSource = bindingSourceShelves.DataSource;

            cmbxAuthors.DisplayMember = "Name";
            cmbxAuthors.ValueMember = "Name";

            cmbxShelves.DisplayMember = "Name";
            cmbxShelves.ValueMember = "Name";




            //category = (Category)cmbxAuthors.SelectedItem;
            //MessageBox.Show(category.Id);
        }


        void ShowData()
        {
            _listBooks = _providerBooks.GetBooks();
            dataGridBooks.DataSource = _listBooks;
            //dataGridBooks.RowTemplate.Height = 100;
            //dataGridBooks.AutoResizeColumns();
            //dataGridBooks.AutoResizeRows();
        }


        private void FormBooks_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            if (cmbxCategories.SelectedItem==null)
            {
                lstbxPickedCategies.Items.Add(cmbxCategories.Text);
            }
        }

        

        private void btnCreateTag_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            pickedImagePath = openFileDialog1.FileName;

            pictbxBookImage.Image = Image.FromFile(pickedImagePath);
        }

        private void btnClearSelectedImage_Click(object sender, EventArgs e)
        {
            pickedImagePath = null;
            pictbxBookImage.Image = null;
        }
    }
}
