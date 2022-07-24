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
        SQLiteController _providerSQL;
        string _selectedImageFile = null;
        string _selectedReaderId = null;
        List<Reader> _readersList;
        public FormReaders()
        {
            InitializeComponent();
            _providerSQL = new SQLiteController(@"data\data.db"); 
        }

        private void FormReaders_Load(object sender, EventArgs e)
        {
            ShowReaders(null);
        }

        void ShowReaders(string _readerPartOfName)
        {
            _readersList = _providerSQL.GetReaders(_readerPartOfName);
            dataGridReaders.DataSource = _readersList;
            dataGridReaders.RowTemplate.Height = 100;
            dataGridReaders.AutoResizeColumns();
            dataGridReaders.AutoResizeRows();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            _selectedImageFile = openFileDialog1.FileName;
            // сохраняем текст в файл
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
                //Debug.WriteLine("[hello]"+_insertedReader);
                //Debug.WriteLine("[hello]"+ "data\\readers_img\\reader_" + _insertedReader + ".jpg");
                _providerSQL.UpdateReaderImage(_insertedReader.ToString(), "data\\readers_img\\reader_" + _insertedReader + ".jpg");
            }
            

            _selectedImageFile = null;
            pictBoxNewReaderImage.Image = null;
            tbNameReader.Text = null;
            tbFilterReader.Text = null;

            ShowReaders(null);
            //MessageBox.Show(dateBirthPicker.Value.ToString());
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
                ShowReaders(tbFilterReader.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //finally
            //{
            //    ShowReaders(null);
            //} 
            
        }

        private void dataGridReaders_SelectionChanged(object sender, EventArgs e)
        {
            var ses = dataGridReaders.SelectedRows;
            //MessageBox.Show(ses[1].ToString());
        }

        private void dataGridReaders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnAddReader.Enabled = false;
                int index = e.RowIndex;// get the Row Index
                DataGridViewRow selectedRow = dataGridReaders.Rows[index];

                //MessageBox.Show(selectedRow.Cells[2].Value.ToString());

                _selectedReaderId = selectedRow.Cells[0].Value.ToString();

                //MessageBox.Show(selectedRow.Cells[3].ToString().Trim());

                DateTime _seaderRegDate = DateTime.Parse(selectedRow.Cells[3].Value.ToString());
                dateBirthPicker.Value = _seaderRegDate;

                labelReaderId.Text = "ID: "+selectedRow.Cells[0].Value.ToString();
                tbNameReader.Text = selectedRow.Cells[2].Value.ToString();
                Reader _currentReader = (Reader)_readersList.Where(x => x.Id == selectedRow.Cells[0].Value.ToString()).FirstOrDefault();
                //MessageBox.Show(_currentReader.imagePathString);
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

        private void button2_Click(object sender, EventArgs e)
        {
            btnAddReader.Enabled = true;
            tbNameReader.Text = null;
            labelReaderId.Text = null;
            dateBirthPicker.Value = DateTime.Now;
            pictBoxNewReaderImage.Image = null;
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
            ShowReaders(null);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
