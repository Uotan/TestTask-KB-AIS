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

        string _selectedImageFile = null;
        string _selectedNewImageFile = null;
        bool isEditMode = false;


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

            if (!isEditMode)
            {
                _selectedImageFile = openFileDialog1.FileName;

                pictbxBookImage.Image = Image.FromFile(_selectedImageFile);
            }
            else
            {
                _selectedNewImageFile = openFileDialog1.FileName;

                pictbxBookImage.Image = Image.FromFile(_selectedNewImageFile);
            }
        }

        private void btnClearSelectedImage_Click(object sender, EventArgs e)
        {
            _selectedImageFile = null;
            _selectedNewImageFile = null;
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

            if (!String.IsNullOrEmpty(_selectedImageFile))
            {
                Image imageFile = Image.FromFile(_selectedImageFile);
                Bitmap bitmap = ImageResizer.ResizeImage(imageFile, 82, 128);
                bitmap.Save(@"data\books_img\book_" + _insertedBookId.ToString() + ".jpg");

                _providerBooks.UpdateBookImage(_insertedBookId.ToString(), "data\\books_img\\book_" + _insertedBookId + ".jpg");
            }


            _selectedImageFile = null;
            pictbxBookImage.Image = null;
            tbNameBook.Text = null;

            ShowData();
        }

        private void dataGridBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnAddBook.Enabled = false;

                //btnSelectImage.Enabled = false;
                //btnClearSelectedImage.Enabled = false;


                btnAddBook.Enabled = false;
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridBooks.Rows[index];

                selectedBookId = selectedRow.Cells[0].Value.ToString();

                currentSelectedBook = _providerBooks.GetBook(selectedBookId);
                tbNameBook.Text = currentSelectedBook.Name;

                cmbxAuthors.SelectedItem = cmbxAuthors.Items.Cast<Author>().Where(i => i.Name == currentSelectedBook.Author).Single();
                cmbxShelves.SelectedItem = cmbxShelves.Items.Cast<Shelf>().Where(i => i.Name == currentSelectedBook.Shelf).Single();

                if (String.IsNullOrEmpty(currentSelectedBook.ImagePath))
                {
                    pictbxBookImage.Image = null;
                    _selectedImageFile = null;
                }
                else
                {
                    _selectedImageFile = currentSelectedBook.ImagePath;
                    
                    pictbxBookImage.Image = Image.FromFile(currentSelectedBook.ImagePath);
                }
                isEditMode = true;

                //cmbxAuthors.SelectedItem = cmbxAuthors.Items.Cast<Author>().Where(i => i.Name == _selectedBookObject.Author).Single();
                //Author _pickedAuthor = (Author)cmbxAuthors.SelectedItem;
                //MessageBox.Show(_pickedAuthor.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveEdits_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(currentSelectedBook.Id))
            {
                Author _pickedAuthor = (Author)cmbxAuthors.SelectedItem;
                Shelf _pickedShelf = (Shelf)cmbxShelves.SelectedItem;
                _providerBooks.UpdateBookData(currentSelectedBook.Id, tbNameBook.Text, _pickedAuthor.Id,_pickedShelf.Id);
            }
            if (!String.IsNullOrEmpty(_selectedNewImageFile)&& !String.IsNullOrEmpty(currentSelectedBook.Id))
            {
                //pictbxBookImage.Image = null;
                //_readersList.Clear();
                //dataGridReaders.DataSource = null;

                Image _imageFile = Image.FromFile(_selectedNewImageFile);
                Bitmap bitmap = ImageResizer.ResizeImage(_imageFile, 82, 128);

                bitmap.Save(@"data\books_img\book_" + currentSelectedBook.Id + "_" + DateTime.Now.ToString("dd/MM/yy_H.mm.ss") + ".jpg");

                _providerBooks.UpdateBookImage(currentSelectedBook.Id, "data\\books_img\\book_" + currentSelectedBook.Id + "_" + DateTime.Now.ToString("dd/MM/yy_H.mm.ss") + ".jpg");
            }




            ClearFields();

            ShowData();
        }

        void ClearFields()
        {
            currentSelectedBook=null;

            isEditMode = false;
            _selectedNewImageFile = null;


            //_selectedReaderId = null;
            _selectedImageFile = null;

            btnSelectImage.Enabled = true;
            btnClearSelectedImage.Enabled = true;

            btnAddBook.Enabled = true;
            tbNameBook.Text = null;
            pictbxBookImage.Image = null;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Удалить выбранную книгу?",
        "Внимание",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning,
        MessageBoxDefaultButton.Button1);

            if (result != DialogResult.Yes)
            {
                return;
            }
            try
            {
                _providerBooks.DeleteBook(selectedBookId);
                ClearFields();
                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
