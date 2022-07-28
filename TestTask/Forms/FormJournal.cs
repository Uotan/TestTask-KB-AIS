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
using TestTask.Controls;
using TestTask.Models;

namespace TestTask.Forms
{
    public partial class FormJournal : Form
    {
        List<JournalEntry> journalEntries = new List<JournalEntry>();
        JournalControllerSQL providerJournal;

        JournalEntry selectedJournalEntry = null;
        public FormJournal()
        {
            InitializeComponent();
            providerJournal = new JournalControllerSQL(@"data\data.db");
        }

        private void FormJournal_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        void ShowData()
        {
            journalEntries = providerJournal.GetJournalEntries();
            dataGridJournalEntries.DataSource = journalEntries;
        }

        private void tbBookID_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbReaderID_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBookID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbReaderID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void dataGridJournalEntries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                btnSaveEntry.Enabled = true;

                DataGridViewRow selectedRow = dataGridJournalEntries.Rows[index];

                string _selectedEntryID = selectedRow.Cells[0].Value.ToString();
                selectedJournalEntry = providerJournal.GetJournalEntry(_selectedEntryID);

                tbEntryID.Text = selectedJournalEntry.Id.ToString();
                tbBookID.Text = selectedJournalEntry.BookId.ToString();
                tbReaderID.Text = selectedJournalEntry.ReaderID.ToString();
                dateTimerStart.Value = selectedJournalEntry.DateStart;
                dateTimerEnd.Value = selectedJournalEntry.DateEnd;
                chckbxReturned.Checked = selectedJournalEntry.Returned;
                btnAddEntry.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void btnAddEntry_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbBookID.Text) || String.IsNullOrEmpty(tbReaderID.Text))
            {
                return;
            }
            try
            {
                object selectedEntryId = providerJournal.AddEntry(tbBookID.Text, tbReaderID.Text, dateTimerStart.Value.ToString(), dateTimerEnd.Value.ToString(), chckbxReturned.Checked.ToString());
                MessageBox.Show($"Идентификатор добавленного объекта {selectedEntryId}");
                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnResetData_Click(object sender, EventArgs e)
        {
            tbEntryID.Text = null;
            tbBookID.Text = null;
            tbReaderID.Text = null;
            dateTimerStart.Value = DateTime.Now;
            dateTimerEnd.Value = DateTime.Now;
            chckbxReturned.Checked = false;
            btnAddEntry.Enabled = true;
            selectedJournalEntry = null;
            btnSaveEntry.Enabled = false;
        }

        private void btnSaveEntry_Click(object sender, EventArgs e)
        {
            providerJournal.UpdateEntry(tbEntryID.Text,tbBookID.Text, tbReaderID.Text, dateTimerStart.Value.ToString(), dateTimerEnd.Value.ToString(), chckbxReturned.Checked.ToString());
            ShowData();
        }
    }
}
