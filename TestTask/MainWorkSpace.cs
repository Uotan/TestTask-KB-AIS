using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TestTask.Forms;

namespace TestTask
{
    public partial class MainWorkSpace : Form
    {
        private Form _activeForm;
        public MainWorkSpace()
        {
            InitializeComponent();
        }

        private void MainWorkSpace_Load(object sender, EventArgs e)
        {
            CheckFilesAndDirectory();
        }

        void CheckFilesAndDirectory()
        {
            if (!Directory.Exists("data"))
            {
                Directory.CreateDirectory("data");
            }
            if (!Directory.Exists("data\\readers_img"))
            {
                Directory.CreateDirectory("data\\readers_img");
            }
            if (!Directory.Exists("data\\books_img"))
            {
                Directory.CreateDirectory("data\\books_img");
            }
            if (!File.Exists("data\\data.db"))
            {
                File.Create("data\\data.db");
            }

        }


        void OpenChildForm(Form childForm)
        {
            if (_activeForm!=null)
            {
                _activeForm.Close();
            }
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelWorkSpace.Controls.Add(childForm);
            this.panelWorkSpace.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            this.labelMainTitle.Text = childForm.Text;
        }

        private void btnToJournal_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormJournal());
        }

        private void btnToBooks_Click(object sender, EventArgs e)
        {

        }

        private void btnToReaders_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormReaders());
        }

        private void btnToAuthors_Click(object sender, EventArgs e)
        {

        }

        private void btnToTags_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTags());
        }

        private void btnToCategories_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCategories());
        }

        private void btnToShelves_Click(object sender, EventArgs e)
        {

        }
    }
}
