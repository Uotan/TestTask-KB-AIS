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
        CategoriesControllerSQL _provider;
        public FormBooks()
        {
            InitializeComponent();
            _provider = new CategoriesControllerSQL(@"data\data.db");
            List<Category> shit = _provider.GetCategories();
            //comboBox1.DataSource = shit;


            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = shit;

            comboBox1.DataSource = bindingSource1.DataSource;

            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Name";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category category = (Category)comboBox1.SelectedItem;
            MessageBox.Show(category.Id);
        }
    }
}
