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
using System.IO;
using System.Diagnostics;

namespace TestTask.Forms
{
    public partial class FormReaders : Form
    {
        ReaderControllerSQL _providerSQL;
        string _selectedImageFile = null;
        string _selectedReaderId = null;
        List<Reader> _readersList;
        public FormReaders()
        {
            InitializeComponent();
            _providerSQL = new ReaderControllerSQL(@"data\data.db"); 
        }

        private void FormReaders_Load(object sender, EventArgs e)
        {
            ShowReaders(null,null);
        }

        void ShowReaders(string _readerPartOfName,string _readerID)
        {
            if (String.IsNullOrEmpty(_readerPartOfName)&&_readerID!=null)
            {
                _readersList = _providerSQL.GetReadersByID(_readerID);
                dataGridReaders.DataSource = _readersList;
                dataGridReaders.RowTemplate.Height = 100;
                dataGridReaders.AutoResizeColumns();
                dataGridReaders.AutoResizeRows();
            }
            else
            {
                _readersList = _providerSQL.GetReaders(_readerPartOfName);
                dataGridReaders.DataSource = _readersList;
                //dataGridReaders.RowTemplate.Height = 100;
                //dataGridReaders.AutoResizeColumns();
                //dataGridReaders.AutoResizeRows();
            }
            
        }



        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            _selectedImageFile = openFileDialog1.FileName;

            pictBoxNewReaderImage.Image = Image.FromFile(_selectedImageFile);

        }

        private void btnAddReader_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbNameReader.Text))
            {
                MessageBox.Show("Имя читателя пустое");
                return;
            }
            DateTime dateTimeCurrent = DateTime.UtcNow;
            object _insertedReader = _providerSQL.AddReader(dateTimeCurrent.ToString(),tbNameReader.Text,dateBirthPicker.Value.ToString(), null);
            MessageBox.Show($"Идентификатор добавленного объекта {_insertedReader}");

            if (!String.IsNullOrEmpty(_selectedImageFile))
            {
                Image imageFile = Image.FromFile(_selectedImageFile);
                Bitmap bitmap = ImageResizer.ResizeImage(imageFile, 128, 128);
                bitmap.Save(@"data\readers_img\reader_" + _insertedReader.ToString()+".jpg");

                _providerSQL.UpdateReaderImage(_insertedReader.ToString(), "data\\readers_img\\reader_" + _insertedReader + ".jpg");
            }
            

            _selectedImageFile = null;
            pictBoxNewReaderImage.Image = null;
            tbNameReader.Text = null;
            tbFilterReader.Text = null;

            ShowReaders(null,null);
        }

        private void btnClearSelectedImage_Click(object sender, EventArgs e)
        {
            _selectedImageFile = null;
            pictBoxNewReaderImage.Image = null;
        }

        private void tbFilterReader_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbFilterByID.Text = null;
                ShowReaders(tbFilterReader.Text,null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridReaders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnSelectImage.Enabled = false;
                btnClearSelectedImage.Enabled = false;


                btnAddReader.Enabled = false;
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridReaders.Rows[index];

                _selectedReaderId = selectedRow.Cells[0].Value.ToString();

                DateTime _seaderRegDate = DateTime.Parse(selectedRow.Cells[3].Value.ToString());


                labelNumberOfYears.Text = (DateTime.Now.Year - _seaderRegDate.Year).ToString()+" лет(года)";

                dateBirthPicker.Value = _seaderRegDate;

                labelReaderId.Text = "ID: "+selectedRow.Cells[0].Value.ToString();
                tbNameReader.Text = selectedRow.Cells[2].Value.ToString();
                Reader _currentReader = (Reader)_readersList.Where(x => x.Id == selectedRow.Cells[0].Value.ToString()).FirstOrDefault();

                if (String.IsNullOrEmpty(_currentReader.ImagePath))
                {
                    pictBoxNewReaderImage.Image = null;
                    _selectedImageFile = null;
                }
                else
                {
                    _selectedImageFile = _currentReader.ImagePath;
                    pictBoxNewReaderImage.Image = Image.FromFile(_currentReader.ImagePath);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        void ClearFields()
        {
            _selectedReaderId = null;
            _selectedImageFile = null;

            btnSelectImage.Enabled = true;
            btnClearSelectedImage.Enabled = true;

            labelNumberOfYears.Text = null;

            btnAddReader.Enabled = true;
            tbNameReader.Text = null;
            labelReaderId.Text = null;
            dateBirthPicker.Value = DateTime.Now;
            pictBoxNewReaderImage.Image = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnDeleteReader_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Удалить выбранного читателя?",
        "Внимание",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning,
        MessageBoxDefaultButton.Button1);

            if (result != DialogResult.Yes)
            {
                return;
            }
            _providerSQL.DeleteReader(_selectedReaderId);
            ShowReaders(null, null);
        }

        

        private void btnSaveEdits_Click(object sender, EventArgs e)
        {
            pictBoxNewReaderImage.Image = null;
            if (!String.IsNullOrEmpty(_selectedReaderId))
            {
                _providerSQL.UpdateReaderData(_selectedReaderId,dateBirthPicker.Value.ToString(),tbNameReader.Text);
            }

            ClearFields();

            ShowReaders(null, null);
        }

        private void tbFilterByID_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbFilterByID.Text))
            {
                ShowReaders(null, null);
            }
            else
            {
                tbFilterReader.Text = null;
                ShowReaders(null, tbFilterByID.Text);

            }
            
        }

        private void tbFilterByID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
