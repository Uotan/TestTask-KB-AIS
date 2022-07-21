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

namespace TestTask.Forms
{
    public partial class FormJournal : Form
    {
        public FormJournal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(textBox1.Text))
            {
                pictureBox1.Image = Image.FromFile(textBox1.Text);
            }
            //MessageBox.Show(DateTime.Now.ToString());
        }
    }
}
