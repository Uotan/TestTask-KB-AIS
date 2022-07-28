namespace TestTask.Forms
{
    partial class FormReaders
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
            this.dataGridReaders = new System.Windows.Forms.DataGridView();
            this.dateBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.tbNameReader = new System.Windows.Forms.TextBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.pictBoxNewReaderImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAddReader = new System.Windows.Forms.Button();
            this.btnClearSelectedImage = new System.Windows.Forms.Button();
            this.btnSaveEdits = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDeleteReader = new System.Windows.Forms.Button();
            this.labelReaderId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFilterReader = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFilterByID = new System.Windows.Forms.TextBox();
            this.labelNumberOfYears = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReaders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxNewReaderImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridReaders
            // 
            this.dataGridReaders.AllowUserToAddRows = false;
            this.dataGridReaders.AllowUserToDeleteRows = false;
            this.dataGridReaders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridReaders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridReaders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridReaders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridReaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReaders.Location = new System.Drawing.Point(16, 379);
            this.dataGridReaders.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridReaders.MultiSelect = false;
            this.dataGridReaders.Name = "dataGridReaders";
            this.dataGridReaders.ReadOnly = true;
            this.dataGridReaders.RowHeadersWidth = 51;
            this.dataGridReaders.Size = new System.Drawing.Size(1474, 369);
            this.dataGridReaders.TabIndex = 0;
            this.dataGridReaders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridReaders_CellClick);
            // 
            // dateBirthPicker
            // 
            this.dateBirthPicker.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateBirthPicker.Location = new System.Drawing.Point(28, 158);
            this.dateBirthPicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateBirthPicker.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dateBirthPicker.Name = "dateBirthPicker";
            this.dateBirthPicker.Size = new System.Drawing.Size(381, 29);
            this.dateBirthPicker.TabIndex = 1;
            // 
            // tbNameReader
            // 
            this.tbNameReader.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNameReader.Location = new System.Drawing.Point(28, 86);
            this.tbNameReader.Margin = new System.Windows.Forms.Padding(4);
            this.tbNameReader.Name = "tbNameReader";
            this.tbNameReader.Size = new System.Drawing.Size(381, 29);
            this.tbNameReader.TabIndex = 2;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectImage.Location = new System.Drawing.Point(464, 220);
            this.btnSelectImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(200, 28);
            this.btnSelectImage.TabIndex = 3;
            this.btnSelectImage.Text = "Выбрать изображение";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // pictBoxNewReaderImage
            // 
            this.pictBoxNewReaderImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictBoxNewReaderImage.Location = new System.Drawing.Point(464, 28);
            this.pictBoxNewReaderImage.Margin = new System.Windows.Forms.Padding(4);
            this.pictBoxNewReaderImage.Name = "pictBoxNewReaderImage";
            this.pictBoxNewReaderImage.Size = new System.Drawing.Size(199, 184);
            this.pictBoxNewReaderImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictBoxNewReaderImage.TabIndex = 4;
            this.pictBoxNewReaderImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Полное имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дата рождения";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Файлы изображений (*.jpeg, *.jpg, *.png)|*.jpeg;*.jpg;*.png";
            // 
            // btnAddReader
            // 
            this.btnAddReader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(213)))));
            this.btnAddReader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddReader.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddReader.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddReader.Location = new System.Drawing.Point(699, 33);
            this.btnAddReader.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddReader.Name = "btnAddReader";
            this.btnAddReader.Size = new System.Drawing.Size(203, 28);
            this.btnAddReader.TabIndex = 7;
            this.btnAddReader.Text = "Добавить читателя";
            this.btnAddReader.UseVisualStyleBackColor = false;
            this.btnAddReader.Click += new System.EventHandler(this.btnAddReader_Click);
            // 
            // btnClearSelectedImage
            // 
            this.btnClearSelectedImage.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearSelectedImage.Location = new System.Drawing.Point(464, 256);
            this.btnClearSelectedImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearSelectedImage.Name = "btnClearSelectedImage";
            this.btnClearSelectedImage.Size = new System.Drawing.Size(200, 28);
            this.btnClearSelectedImage.TabIndex = 8;
            this.btnClearSelectedImage.Text = "Очистить";
            this.btnClearSelectedImage.UseVisualStyleBackColor = true;
            this.btnClearSelectedImage.Click += new System.EventHandler(this.btnClearSelectedImage_Click);
            // 
            // btnSaveEdits
            // 
            this.btnSaveEdits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(213)))));
            this.btnSaveEdits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveEdits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveEdits.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveEdits.Location = new System.Drawing.Point(699, 69);
            this.btnSaveEdits.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveEdits.Name = "btnSaveEdits";
            this.btnSaveEdits.Size = new System.Drawing.Size(203, 28);
            this.btnSaveEdits.TabIndex = 9;
            this.btnSaveEdits.Text = "Сохранить изменения";
            this.btnSaveEdits.UseVisualStyleBackColor = false;
            this.btnSaveEdits.Click += new System.EventHandler(this.btnSaveEdits_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(699, 146);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "Сбросить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDeleteReader
            // 
            this.btnDeleteReader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.btnDeleteReader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteReader.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteReader.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteReader.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeleteReader.Location = new System.Drawing.Point(699, 182);
            this.btnDeleteReader.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteReader.Name = "btnDeleteReader";
            this.btnDeleteReader.Size = new System.Drawing.Size(203, 28);
            this.btnDeleteReader.TabIndex = 11;
            this.btnDeleteReader.Text = "Удалить запись";
            this.btnDeleteReader.UseVisualStyleBackColor = false;
            this.btnDeleteReader.Click += new System.EventHandler(this.btnDeleteReader_Click);
            // 
            // labelReaderId
            // 
            this.labelReaderId.AutoSize = true;
            this.labelReaderId.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReaderId.Location = new System.Drawing.Point(27, 28);
            this.labelReaderId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReaderId.Name = "labelReaderId";
            this.labelReaderId.Size = new System.Drawing.Size(0, 22);
            this.labelReaderId.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(205, 313);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Фильтр по имени";
            // 
            // tbFilterReader
            // 
            this.tbFilterReader.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFilterReader.Location = new System.Drawing.Point(209, 338);
            this.tbFilterReader.Margin = new System.Windows.Forms.Padding(4);
            this.tbFilterReader.Name = "tbFilterReader";
            this.tbFilterReader.Size = new System.Drawing.Size(381, 29);
            this.tbFilterReader.TabIndex = 13;
            this.tbFilterReader.TextChanged += new System.EventHandler(this.tbFilterReader_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 313);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Фильтр по ID";
            // 
            // tbFilterByID
            // 
            this.tbFilterByID.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFilterByID.Location = new System.Drawing.Point(17, 338);
            this.tbFilterByID.Margin = new System.Windows.Forms.Padding(4);
            this.tbFilterByID.MaxLength = 5;
            this.tbFilterByID.Name = "tbFilterByID";
            this.tbFilterByID.Size = new System.Drawing.Size(164, 29);
            this.tbFilterByID.TabIndex = 15;
            this.tbFilterByID.TextChanged += new System.EventHandler(this.tbFilterByID_TextChanged);
            this.tbFilterByID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterByID_KeyPress);
            // 
            // labelNumberOfYears
            // 
            this.labelNumberOfYears.AutoSize = true;
            this.labelNumberOfYears.Location = new System.Drawing.Point(27, 197);
            this.labelNumberOfYears.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumberOfYears.Name = "labelNumberOfYears";
            this.labelNumberOfYears.Size = new System.Drawing.Size(0, 16);
            this.labelNumberOfYears.TabIndex = 17;
            // 
            // FormReaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 763);
            this.Controls.Add(this.labelNumberOfYears);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbFilterByID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFilterReader);
            this.Controls.Add(this.labelReaderId);
            this.Controls.Add(this.btnDeleteReader);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSaveEdits);
            this.Controls.Add(this.btnClearSelectedImage);
            this.Controls.Add(this.btnAddReader);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictBoxNewReaderImage);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.tbNameReader);
            this.Controls.Add(this.dateBirthPicker);
            this.Controls.Add(this.dataGridReaders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormReaders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Читатели";
            this.Load += new System.EventHandler(this.FormReaders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReaders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxNewReaderImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridReaders;
        private System.Windows.Forms.DateTimePicker dateBirthPicker;
        private System.Windows.Forms.TextBox tbNameReader;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.PictureBox pictBoxNewReaderImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAddReader;
        private System.Windows.Forms.Button btnClearSelectedImage;
        private System.Windows.Forms.Button btnSaveEdits;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDeleteReader;
        private System.Windows.Forms.Label labelReaderId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFilterReader;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFilterByID;
        private System.Windows.Forms.Label labelNumberOfYears;
    }
}