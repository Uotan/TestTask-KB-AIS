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
            //dataGridTags.RowTemplate.Height = 30;
            //dataGridTags.AutoResizeColumns();
            //dataGridTags.AutoResizeRows();

        }

        private void dataGridTags_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {



                //btnAddTag.Enabled = false;

                int index = e.RowIndex;// get the Row Index
                DataGridViewRow selectedRow = dataGridTags.Rows[index];


                _selectedTagId = selectedRow.Cells[0].Value.ToString();

                //tbNameCategory.Text = selectedRow.Cells[1].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddTag_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbNameTag.Text))
            {
                _providerSQL.AddTag(tbNameTag.Text);
                tbNameTag.Text = null;
                ShowTags();
            }
        }

        private void btnDeleteTag_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Удалить выбранный тэг?",
        "Внимание",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning,
        MessageBoxDefaultButton.Button1);

            if (result != DialogResult.Yes)
            {
                return;
            }
            _providerSQL.DeleteTag(_selectedTagId);
            ShowTags();
        }
    }
}
