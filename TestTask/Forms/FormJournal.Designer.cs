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
            this.label5 = new System.Windows.Forms.Label();
            this.tbFilterByReaderId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFilterByBookId = new System.Windows.Forms.TextBox();
            this.checkBoxOnlyMissing = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJournalEntries)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTagName
            // 
            this.labelTagName.AutoSize = true;
            this.labelTagName.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTagName.Location = new System.Drawing.Point(169, 39);
            this.labelTagName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTagName.Name = "labelTagName";
            this.labelTagName.Size = new System.Drawing.Size(74, 22);
            this.labelTagName.TabIndex = 26;
            this.labelTagName.Text = "ID книги";
            // 
            // tbBookID
            // 
            this.tbBookID.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBookID.Location = new System.Drawing.Point(173, 66);
            this.tbBookID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBookID.Name = "tbBookID";
            this.tbBookID.Size = new System.Drawing.Size(125, 29);
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
            this.dataGridJournalEntries.Location = new System.Drawing.Point(16, 217);
            this.dataGridJournalEntries.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridJournalEntries.MultiSelect = false;
            this.dataGridJournalEntries.Name = "dataGridJournalEntries";
            this.dataGridJournalEntries.ReadOnly = true;
            this.dataGridJournalEntries.RowHeadersWidth = 51;
            this.dataGridJournalEntries.Size = new System.Drawing.Size(1475, 510);
            this.dataGridJournalEntries.TabIndex = 24;
            this.dataGridJournalEntries.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridJournalEntries_CellClick);
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(213)))));
            this.btnAddEntry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEntry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddEntry.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddEntry.Location = new System.Drawing.Point(1157, 15);
            this.btnAddEntry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(203, 57);
            this.btnAddEntry.TabIndex = 27;
            this.btnAddEntry.Text = "Добавить запись в журнал";
            this.btnAddEntry.UseVisualStyleBackColor = false;
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(321, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "ID читателя";
            // 
            // tbReaderID
            // 
            this.tbReaderID.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbReaderID.Location = new System.Drawing.Point(325, 66);
            this.tbReaderID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbReaderID.Name = "tbReaderID";
            this.tbReaderID.Size = new System.Drawing.Size(125, 29);
            this.tbReaderID.TabIndex = 28;
            this.tbReaderID.TextChanged += new System.EventHandler(this.tbReaderID_TextChanged);
            this.tbReaderID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbReaderID_KeyPress);
            // 
            // dateTimerStart
            // 
            this.dateTimerStart.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimerStart.Location = new System.Drawing.Point(484, 66);
            this.dateTimerStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimerStart.Name = "dateTimerStart";
            this.dateTimerStart.Size = new System.Drawing.Size(200, 29);
            this.dateTimerStart.TabIndex = 30;
            // 
            // dateTimerEnd
            // 
            this.dateTimerEnd.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimerEnd.Location = new System.Drawing.Point(719, 66);
            this.dateTimerEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimerEnd.Name = "dateTimerEnd";
            this.dateTimerEnd.Size = new System.Drawing.Size(200, 29);
            this.dateTimerEnd.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(480, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "Дата ВРУЧЕНИЯ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(715, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 22);
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
            this.btnResetData.Location = new System.Drawing.Point(1157, 126);
            this.btnResetData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResetData.Name = "btnResetData";
            this.btnResetData.Size = new System.Drawing.Size(203, 28);
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
            this.btnSaveEntry.Location = new System.Drawing.Point(1157, 80);
            this.btnSaveEntry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveEntry.Name = "btnSaveEntry";
            this.btnSaveEntry.Size = new System.Drawing.Size(203, 36);
            this.btnSaveEntry.TabIndex = 36;
            this.btnSaveEntry.Text = "Сохранить изменения";
            this.btnSaveEntry.UseVisualStyleBackColor = false;
            this.btnSaveEntry.Click += new System.EventHandler(this.btnSaveEntry_Click);
            // 
            // chckbxReturned
            // 
            this.chckbxReturned.AutoSize = true;
            this.chckbxReturned.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chckbxReturned.Location = new System.Drawing.Point(957, 66);
            this.chckbxReturned.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chckbxReturned.Name = "chckbxReturned";
            this.chckbxReturned.Size = new System.Drawing.Size(130, 27);
            this.chckbxReturned.TabIndex = 37;
            this.chckbxReturned.Text = "Возвращена";
            this.chckbxReturned.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 38;
            this.label4.Text = "ID записи";
            // 
            // tbEntryID
            // 
            this.tbEntryID.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEntryID.Location = new System.Drawing.Point(16, 68);
            this.tbEntryID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEntryID.Name = "tbEntryID";
            this.tbEntryID.ReadOnly = true;
            this.tbEntryID.Size = new System.Drawing.Size(125, 29);
            this.tbEntryID.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(219, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 22);
            this.label5.TabIndex = 43;
            this.label5.Text = "Поиск по ID читателя";
            // 
            // tbFilterByReaderId
            // 
            this.tbFilterByReaderId.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFilterByReaderId.Location = new System.Drawing.Point(223, 180);
            this.tbFilterByReaderId.Margin = new System.Windows.Forms.Padding(4);
            this.tbFilterByReaderId.Name = "tbFilterByReaderId";
            this.tbFilterByReaderId.Size = new System.Drawing.Size(196, 29);
            this.tbFilterByReaderId.TabIndex = 42;
            this.tbFilterByReaderId.TextChanged += new System.EventHandler(this.tbFilterByReaderId_TextChanged);
            this.tbFilterByReaderId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterByReaderId_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 153);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 22);
            this.label6.TabIndex = 41;
            this.label6.Text = "Поиск по ID книги";
            // 
            // tbFilterByBookId
            // 
            this.tbFilterByBookId.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFilterByBookId.Location = new System.Drawing.Point(16, 180);
            this.tbFilterByBookId.Margin = new System.Windows.Forms.Padding(4);
            this.tbFilterByBookId.Name = "tbFilterByBookId";
            this.tbFilterByBookId.Size = new System.Drawing.Size(171, 29);
            this.tbFilterByBookId.TabIndex = 40;
            this.tbFilterByBookId.TextChanged += new System.EventHandler(this.tbFilterByBookId_TextChanged);
            this.tbFilterByBookId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterByBookId_KeyPress);
            // 
            // checkBoxOnlyMissing
            // 
            this.checkBoxOnlyMissing.AutoSize = true;
            this.checkBoxOnlyMissing.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxOnlyMissing.Location = new System.Drawing.Point(482, 180);
            this.checkBoxOnlyMissing.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxOnlyMissing.Name = "checkBoxOnlyMissing";
            this.checkBoxOnlyMissing.Size = new System.Drawing.Size(289, 27);
            this.checkBoxOnlyMissing.TabIndex = 44;
            this.checkBoxOnlyMissing.Text = "Показать только отсутствующие";
            this.checkBoxOnlyMissing.UseVisualStyleBackColor = true;
            this.checkBoxOnlyMissing.Visible = false;
            // 
            // FormJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 763);
            this.Controls.Add(this.checkBoxOnlyMissing);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbFilterByReaderId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbFilterByBookId);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFilterByReaderId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFilterByBookId;
        private System.Windows.Forms.CheckBox checkBoxOnlyMissing;
    }
}