namespace TestTask.Forms
{
    partial class FormBooks
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
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSaveEdits = new System.Windows.Forms.Button();
            this.btnClearSelectedImage = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictbxBookImage = new System.Windows.Forms.PictureBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.tbNameBook = new System.Windows.Forms.TextBox();
            this.dataGridBooks = new System.Windows.Forms.DataGridView();
            this.cmbxAuthors = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbxShelves = new System.Windows.Forms.ComboBox();
            this.lstbxPickedCategies = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbxCategories = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteTag = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnCreateTag = new System.Windows.Forms.Button();
            this.btnCreateCategory = new System.Windows.Forms.Button();
            this.cmbxTags = new System.Windows.Forms.ComboBox();
            this.lstbxPickedTags = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFilterByID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbFilterReader = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictbxBookImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBooks)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.btnDeleteBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteBook.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteBook.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeleteBook.Location = new System.Drawing.Point(1177, 241);
            this.btnDeleteBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(203, 28);
            this.btnDeleteBook.TabIndex = 29;
            this.btnDeleteBook.Text = "Удалить книгу";
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnReset.Location = new System.Drawing.Point(1177, 206);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(203, 28);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Сбросить";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSaveEdits
            // 
            this.btnSaveEdits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(213)))));
            this.btnSaveEdits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveEdits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveEdits.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveEdits.Location = new System.Drawing.Point(1177, 128);
            this.btnSaveEdits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveEdits.Name = "btnSaveEdits";
            this.btnSaveEdits.Size = new System.Drawing.Size(203, 28);
            this.btnSaveEdits.TabIndex = 27;
            this.btnSaveEdits.Text = "Сохранить изменения";
            this.btnSaveEdits.UseVisualStyleBackColor = false;
            this.btnSaveEdits.Click += new System.EventHandler(this.btnSaveEdits_Click);
            // 
            // btnClearSelectedImage
            // 
            this.btnClearSelectedImage.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearSelectedImage.Location = new System.Drawing.Point(927, 290);
            this.btnClearSelectedImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearSelectedImage.Name = "btnClearSelectedImage";
            this.btnClearSelectedImage.Size = new System.Drawing.Size(200, 28);
            this.btnClearSelectedImage.TabIndex = 26;
            this.btnClearSelectedImage.Text = "Очистить";
            this.btnClearSelectedImage.UseVisualStyleBackColor = true;
            this.btnClearSelectedImage.Click += new System.EventHandler(this.btnClearSelectedImage_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(213)))));
            this.btnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddBook.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddBook.Location = new System.Drawing.Point(1177, 92);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(203, 28);
            this.btnAddBook.TabIndex = 25;
            this.btnAddBook.Text = "Добавить книгу";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Название книги";
            // 
            // pictbxBookImage
            // 
            this.pictbxBookImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictbxBookImage.Location = new System.Drawing.Point(959, 46);
            this.pictbxBookImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictbxBookImage.Name = "pictbxBookImage";
            this.pictbxBookImage.Size = new System.Drawing.Size(127, 200);
            this.pictbxBookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbxBookImage.TabIndex = 22;
            this.pictbxBookImage.TabStop = false;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectImage.Location = new System.Drawing.Point(927, 254);
            this.btnSelectImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(200, 28);
            this.btnSelectImage.TabIndex = 21;
            this.btnSelectImage.Text = "Выбрать изображение";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // tbNameBook
            // 
            this.tbNameBook.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNameBook.Location = new System.Drawing.Point(11, 63);
            this.tbNameBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNameBook.Name = "tbNameBook";
            this.tbNameBook.Size = new System.Drawing.Size(336, 29);
            this.tbNameBook.TabIndex = 20;
            // 
            // dataGridBooks
            // 
            this.dataGridBooks.AllowUserToAddRows = false;
            this.dataGridBooks.AllowUserToDeleteRows = false;
            this.dataGridBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBooks.Location = new System.Drawing.Point(19, 450);
            this.dataGridBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridBooks.MultiSelect = false;
            this.dataGridBooks.Name = "dataGridBooks";
            this.dataGridBooks.ReadOnly = true;
            this.dataGridBooks.RowHeadersWidth = 51;
            this.dataGridBooks.Size = new System.Drawing.Size(1474, 291);
            this.dataGridBooks.TabIndex = 18;
            this.dataGridBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBooks_CellClick);
            // 
            // cmbxAuthors
            // 
            this.cmbxAuthors.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxAuthors.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxAuthors.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbxAuthors.FormattingEnabled = true;
            this.cmbxAuthors.Location = new System.Drawing.Point(11, 167);
            this.cmbxAuthors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxAuthors.Name = "cmbxAuthors";
            this.cmbxAuthors.Size = new System.Drawing.Size(336, 30);
            this.cmbxAuthors.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 31;
            this.label2.Text = "Автор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 33;
            this.label3.Text = "Полка";
            // 
            // cmbxShelves
            // 
            this.cmbxShelves.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxShelves.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxShelves.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbxShelves.FormattingEnabled = true;
            this.cmbxShelves.Location = new System.Drawing.Point(11, 268);
            this.cmbxShelves.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxShelves.Name = "cmbxShelves";
            this.cmbxShelves.Size = new System.Drawing.Size(337, 30);
            this.cmbxShelves.TabIndex = 32;
            // 
            // lstbxPickedCategies
            // 
            this.lstbxPickedCategies.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstbxPickedCategies.FormattingEnabled = true;
            this.lstbxPickedCategies.ItemHeight = 22;
            this.lstbxPickedCategies.Location = new System.Drawing.Point(16, 126);
            this.lstbxPickedCategies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstbxPickedCategies.Name = "lstbxPickedCategies";
            this.lstbxPickedCategies.Size = new System.Drawing.Size(212, 158);
            this.lstbxPickedCategies.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 35;
            this.label4.Text = "Категории";
            // 
            // cmbxCategories
            // 
            this.cmbxCategories.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxCategories.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxCategories.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbxCategories.FormattingEnabled = true;
            this.cmbxCategories.Location = new System.Drawing.Point(16, 39);
            this.cmbxCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxCategories.Name = "cmbxCategories";
            this.cmbxCategories.Size = new System.Drawing.Size(212, 30);
            this.cmbxCategories.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(166)))), ((int)(((byte)(157)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbxShelves);
            this.panel1.Controls.Add(this.tbNameBook);
            this.panel1.Controls.Add(this.cmbxAuthors);
            this.panel1.Location = new System.Drawing.Point(12, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 359);
            this.panel1.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.panel2.Controls.Add(this.btnDeleteTag);
            this.panel2.Controls.Add(this.btnDeleteCategory);
            this.panel2.Controls.Add(this.btnCreateTag);
            this.panel2.Controls.Add(this.btnCreateCategory);
            this.panel2.Controls.Add(this.cmbxTags);
            this.panel2.Controls.Add(this.lstbxPickedTags);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmbxCategories);
            this.panel2.Controls.Add(this.lstbxPickedCategies);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(412, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 359);
            this.panel2.TabIndex = 38;
            // 
            // btnDeleteTag
            // 
            this.btnDeleteTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(96)))), ((int)(((byte)(73)))));
            this.btnDeleteTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteTag.Enabled = false;
            this.btnDeleteTag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteTag.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteTag.Location = new System.Drawing.Point(261, 313);
            this.btnDeleteTag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteTag.Name = "btnDeleteTag";
            this.btnDeleteTag.Size = new System.Drawing.Size(212, 28);
            this.btnDeleteTag.TabIndex = 42;
            this.btnDeleteTag.Text = "Убрать тэг";
            this.btnDeleteTag.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(96)))), ((int)(((byte)(73)))));
            this.btnDeleteCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCategory.Enabled = false;
            this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteCategory.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteCategory.Location = new System.Drawing.Point(16, 313);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(212, 28);
            this.btnDeleteCategory.TabIndex = 41;
            this.btnDeleteCategory.Text = "Убрать категорию";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            // 
            // btnCreateTag
            // 
            this.btnCreateTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(213)))));
            this.btnCreateTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateTag.Enabled = false;
            this.btnCreateTag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateTag.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateTag.Location = new System.Drawing.Point(261, 76);
            this.btnCreateTag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateTag.Name = "btnCreateTag";
            this.btnCreateTag.Size = new System.Drawing.Size(212, 28);
            this.btnCreateTag.TabIndex = 40;
            this.btnCreateTag.Text = "Создать тэг";
            this.btnCreateTag.UseVisualStyleBackColor = false;
            this.btnCreateTag.Click += new System.EventHandler(this.btnCreateTag_Click);
            // 
            // btnCreateCategory
            // 
            this.btnCreateCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(213)))));
            this.btnCreateCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateCategory.Enabled = false;
            this.btnCreateCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateCategory.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateCategory.Location = new System.Drawing.Point(16, 76);
            this.btnCreateCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateCategory.Name = "btnCreateCategory";
            this.btnCreateCategory.Size = new System.Drawing.Size(212, 28);
            this.btnCreateCategory.TabIndex = 39;
            this.btnCreateCategory.Text = "Создать категорию";
            this.btnCreateCategory.UseVisualStyleBackColor = false;
            this.btnCreateCategory.Click += new System.EventHandler(this.btnCreateCategory_Click);
            // 
            // cmbxTags
            // 
            this.cmbxTags.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxTags.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxTags.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbxTags.FormattingEnabled = true;
            this.cmbxTags.Location = new System.Drawing.Point(261, 39);
            this.cmbxTags.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxTags.Name = "cmbxTags";
            this.cmbxTags.Size = new System.Drawing.Size(212, 30);
            this.cmbxTags.TabIndex = 39;
            // 
            // lstbxPickedTags
            // 
            this.lstbxPickedTags.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstbxPickedTags.FormattingEnabled = true;
            this.lstbxPickedTags.ItemHeight = 22;
            this.lstbxPickedTags.Location = new System.Drawing.Point(261, 126);
            this.lstbxPickedTags.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstbxPickedTags.Name = "lstbxPickedTags";
            this.lstbxPickedTags.Size = new System.Drawing.Size(212, 158);
            this.lstbxPickedTags.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(259, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 22);
            this.label5.TabIndex = 38;
            this.label5.Text = "Тэг";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(19, 388);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 22);
            this.label6.TabIndex = 42;
            this.label6.Text = "Фильтр по ID";
            // 
            // tbFilterByID
            // 
            this.tbFilterByID.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFilterByID.Location = new System.Drawing.Point(23, 414);
            this.tbFilterByID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFilterByID.MaxLength = 5;
            this.tbFilterByID.Name = "tbFilterByID";
            this.tbFilterByID.Size = new System.Drawing.Size(104, 29);
            this.tbFilterByID.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(159, 388);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 22);
            this.label7.TabIndex = 40;
            this.label7.Text = "Фильтр по названию";
            // 
            // tbFilterReader
            // 
            this.tbFilterReader.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFilterReader.Location = new System.Drawing.Point(163, 414);
            this.tbFilterReader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFilterReader.Name = "tbFilterReader";
            this.tbFilterReader.Size = new System.Drawing.Size(381, 29);
            this.tbFilterReader.TabIndex = 39;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Файлы изображений (*.jpeg, *.jpg, *.png)|*.jpeg;*.jpg;*.png";
            // 
            // FormBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 763);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbFilterByID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbFilterReader);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSaveEdits);
            this.Controls.Add(this.btnClearSelectedImage);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.pictbxBookImage);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.dataGridBooks);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormBooks";
            this.Text = "Книги";
            this.Load += new System.EventHandler(this.FormBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictbxBookImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBooks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSaveEdits;
        private System.Windows.Forms.Button btnClearSelectedImage;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictbxBookImage;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.TextBox tbNameBook;
        private System.Windows.Forms.DataGridView dataGridBooks;
        private System.Windows.Forms.ComboBox cmbxAuthors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbxShelves;
        private System.Windows.Forms.ListBox lstbxPickedCategies;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbxCategories;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbxTags;
        private System.Windows.Forms.ListBox lstbxPickedTags;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteTag;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnCreateTag;
        private System.Windows.Forms.Button btnCreateCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFilterByID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbFilterReader;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}