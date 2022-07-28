namespace TestTask.Forms
{
    partial class FormJournal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTagName = new System.Windows.Forms.Label();
            this.tbBookID = new System.Windows.Forms.TextBox();
            this.dataGridJournalEntries = new System.Windows.Forms.DataGridView();
            this.btnAddEntry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbReaderID = new System.Windows.Forms.TextBox();
            this.dateTimerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimerEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnResetData = new System.Windows.Forms.Button();
            this.btnSaveEntry = new System.Windows.Forms.Button();
            this.chckbxReturned = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEntryID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJournalEntries)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTagName
            // 
            this.labelTagName.AutoSize = true;
            this.labelTagName.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTagName.Location = new System.Drawing.Point(127, 32);
            this.labelTagName.Name = "labelTagName";
            this.labelTagName.Size = new System.Drawing.Size(60, 18);
            this.labelTagName.TabIndex = 26;
            this.labelTagName.Text = "ID книги";
            // 
            // tbBookID
            // 
            this.tbBookID.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBookID.Location = new System.Drawing.Point(130, 54);
            this.tbBookID.Name = "tbBookID";
            this.tbBookID.Size = new System.Drawing.Size(95, 25);
            this.tbBookID.TabIndex = 25;
            this.tbBookID.TextChanged += new System.EventHandler(this.tbBookID_TextChanged);
            this.tbBookID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBookID_KeyPress);
            // 
            // dataGridJournalEntries
            // 
            this.dataGridJournalEntries.AllowUserToAddRows = false;
            this.dataGridJournalEntries.AllowUserToDeleteRows = false;
            this.dataGridJournalEntries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridJournalEntries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridJournalEntries.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridJournalEntries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridJournalEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridJournalEntries.Location = new System.Drawing.Point(12, 176);
            this.dataGridJournalEntries.MultiSelect = false;
            this.dataGridJournalEntries.Name = "dataGridJournalEntries";
            this.dataGridJournalEntries.ReadOnly = true;
            this.dataGridJournalEntries.RowHeadersWidth = 51;
            this.dataGridJournalEntries.Size = new System.Drawing.Size(1106, 414);
            this.dataGridJournalEntries.TabIndex = 24;
            this.dataGridJournalEntries.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridJournalEntries_CellClick);
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(213)))));
            this.btnAddEntry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEntry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddEntry.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddEntry.Location = new System.Drawing.Point(868, 12);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(152, 46);
            this.btnAddEntry.TabIndex = 27;
            this.btnAddEntry.Text = "Добавить запись в журнал";
            this.btnAddEntry.UseVisualStyleBackColor = false;
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(241, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "ID читателя";
            // 
            // tbReaderID
            // 
            this.tbReaderID.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbReaderID.Location = new System.Drawing.Point(244, 54);
            this.tbReaderID.Name = "tbReaderID";
            this.tbReaderID.Size = new System.Drawing.Size(95, 25);
            this.tbReaderID.TabIndex = 28;
            this.tbReaderID.TextChanged += new System.EventHandler(this.tbReaderID_TextChanged);
            this.tbReaderID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbReaderID_KeyPress);
            // 
            // dateTimerStart
            // 
            this.dateTimerStart.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimerStart.Location = new System.Drawing.Point(363, 54);
            this.dateTimerStart.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimerStart.Name = "dateTimerStart";
            this.dateTimerStart.Size = new System.Drawing.Size(151, 25);
            this.dateTimerStart.TabIndex = 30;
            // 
            // dateTimerEnd
            // 
            this.dateTimerEnd.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimerEnd.Location = new System.Drawing.Point(539, 54);
            this.dateTimerEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimerEnd.Name = "dateTimerEnd";
            this.dateTimerEnd.Size = new System.Drawing.Size(151, 25);
            this.dateTimerEnd.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(360, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Дата ВРУЧЕНИЯ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(536, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Дата ВОЗВРАТА";
            // 
            // btnResetData
            // 
            this.btnResetData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.btnResetData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetData.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResetData.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnResetData.Location = new System.Drawing.Point(868, 102);
            this.btnResetData.Name = "btnResetData";
            this.btnResetData.Size = new System.Drawing.Size(152, 23);
            this.btnResetData.TabIndex = 35;
            this.btnResetData.Text = "Сбросить";
            this.btnResetData.UseVisualStyleBackColor = false;
            this.btnResetData.Click += new System.EventHandler(this.btnResetData_Click);
            // 
            // btnSaveEntry
            // 
            this.btnSaveEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(213)))));
            this.btnSaveEntry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveEntry.Enabled = false;
            this.btnSaveEntry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveEntry.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveEntry.Location = new System.Drawing.Point(868, 65);
            this.btnSaveEntry.Name = "btnSaveEntry";
            this.btnSaveEntry.Size = new System.Drawing.Size(152, 29);
            this.btnSaveEntry.TabIndex = 36;
            this.btnSaveEntry.Text = "Сохранить изменения";
            this.btnSaveEntry.UseVisualStyleBackColor = false;
            this.btnSaveEntry.Click += new System.EventHandler(this.btnSaveEntry_Click);
            // 
            // chckbxReturned
            // 
            this.chckbxReturned.AutoSize = true;
            this.chckbxReturned.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chckbxReturned.Location = new System.Drawing.Point(718, 54);
            this.chckbxReturned.Name = "chckbxReturned";
            this.chckbxReturned.Size = new System.Drawing.Size(105, 22);
            this.chckbxReturned.TabIndex = 37;
            this.chckbxReturned.Text = "Возвращена";
            this.chckbxReturned.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 38;
            this.label4.Text = "ID записи";
            // 
            // tbEntryID
            // 
            this.tbEntryID.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEntryID.Location = new System.Drawing.Point(12, 55);
            this.tbEntryID.Name = "tbEntryID";
            this.tbEntryID.ReadOnly = true;
            this.tbEntryID.Size = new System.Drawing.Size(95, 25);
            this.tbEntryID.TabIndex = 39;
            // 
            // FormJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 620);
            this.Controls.Add(this.tbEntryID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chckbxReturned);
            this.Controls.Add(this.btnSaveEntry);
            this.Controls.Add(this.btnResetData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimerEnd);
            this.Controls.Add(this.dateTimerStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbReaderID);
            this.Controls.Add(this.btnAddEntry);
            this.Controls.Add(this.labelTagName);
            this.Controls.Add(this.tbBookID);
            this.Controls.Add(this.dataGridJournalEntries);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormJournal";
            this.Text = "Журнал";
            this.Load += new System.EventHandler(this.FormJournal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJournalEntries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTagName;
        private System.Windows.Forms.TextBox tbBookID;
        private System.Windows.Forms.DataGridView dataGridJournalEntries;
        private System.Windows.Forms.Button btnAddEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbReaderID;
        private System.Windows.Forms.DateTimePicker dateTimerStart;
        private System.Windows.Forms.DateTimePicker dateTimerEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnResetData;
        private System.Windows.Forms.Button btnSaveEntry;
        private System.Windows.Forms.CheckBox chckbxReturned;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEntryID;
    }
}