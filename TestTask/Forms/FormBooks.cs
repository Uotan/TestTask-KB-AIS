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
        Book currentSelectedBook;
        string selectedBookId;
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

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbNameBook.Text))
            {
                MessageBox.Show("Название книги пустое");
                return;
            }

            Author _pickedAuthor = (Author)cmbxAuthors.SelectedItem;
            Shelf _pickedShelf = (Shelf)cmbxShelves.SelectedItem;

            object _insertedBookId = _providerBooks.AddBook(tbNameBook.Text, _pickedAuthor.Id, _pickedShelf.Id);
            MessageBox.Show($"Идентификатор добавленного объекта {_insertedBookId}");

            if (!String.IsNullOrEmpty(pickedImagePath))
            {
                Image imageFile = Image.FromFile(pickedImagePath);
                Bitmap bitmap = ImageResizer.ResizeImage(imageFile, 82, 128);
                bitmap.Save(@"data\books_img\book_" + _insertedBookId.ToString() + ".jpg");

                _providerBooks.UpdateBookImage(_insertedBookId.ToString(), "data\\books_img\\book_" + _insertedBookId + ".jpg");
            }


            pickedImagePath = null;
            pictbxBookImage.Image = null;
            tbNameBook.Text = null;

            ShowData();
        }

        private void dataGridBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //btnSelectImage.Enabled = false;
                //btnClearSelectedImage.Enabled = false;


                btnAddBook.Enabled = false;
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridBooks.Rows[index];

                selectedBookId = selectedRow.Cells[0].Value.ToString();

                Book _selectedBookObject = _providerBooks.GetBook(selectedBookId);
                //labelNumberOfYears.Text = (DateTime.Now.Year - _seaderRegDate.Year).ToString() + " лет(года)";

                cmbxAuthors.SelectedItem = cmbxAuthors.Items.Cast<Author>().Where(i => i.Name == _selectedBookObject.Author).Single();
                Author _pickedAuthor = (Author)cmbxAuthors.SelectedItem;
                MessageBox.Show(_pickedAuthor.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
