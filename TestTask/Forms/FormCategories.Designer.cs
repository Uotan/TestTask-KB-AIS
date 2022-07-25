namespace TestTask.Forms
{
    partial class FormCategories
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
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSaveEdits = new System.Windows.Forms.Button();
            this.btnAddCAtegory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNameCategory = new System.Windows.Forms.TextBox();
            this.dataGridCategories = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFilterByID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFilterName = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.btnDeleteCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteCategory.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteCategory.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeleteCategory.Location = new System.Drawing.Point(682, 97);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(203, 28);
            this.btnDeleteCategory.TabIndex = 18;
            this.btnDeleteCategory.Text = "Удалить запись";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnReset.Location = new System.Drawing.Point(682, 61);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(203, 28);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Сбросить";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnSaveEdits
            // 
            this.btnSaveEdits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(213)))));
            this.btnSaveEdits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveEdits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveEdits.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveEdits.Location = new System.Drawing.Point(451, 97);
            this.btnSaveEdits.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveEdits.Name = "btnSaveEdits";
            this.btnSaveEdits.Size = new System.Drawing.Size(203, 28);
            this.btnSaveEdits.TabIndex = 16;
            this.btnSaveEdits.Text = "Сохранить изменения";
            this.btnSaveEdits.UseVisualStyleBackColor = false;
            // 
            // btnAddCAtegory
            // 
            this.btnAddCAtegory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(213)))));
            this.btnAddCAtegory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCAtegory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCAtegory.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddCAtegory.Location = new System.Drawing.Point(451, 61);
            this.btnAddCAtegory.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCAtegory.Name = "btnAddCAtegory";
            this.btnAddCAtegory.Size = new System.Drawing.Size(203, 28);
            this.btnAddCAtegory.TabIndex = 15;
            this.btnAddCAtegory.Text = "Добавить категорию";
            this.btnAddCAtegory.UseVisualStyleBackColor = false;
            this.btnAddCAtegory.Click += new System.EventHandler(this.btnAddCAtegory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Название категории";
            // 
            // tbNameCategory
            // 
            this.tbNameCategory.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNameCategory.Location = new System.Drawing.Point(28, 77);
            this.tbNameCategory.Margin = new System.Windows.Forms.Padding(4);
            this.tbNameCategory.Name = "tbNameCategory";
            this.tbNameCategory.Size = new System.Drawing.Size(381, 29);
            this.tbNameCategory.TabIndex = 13;
            // 
            // dataGridCategories
            // 
            this.dataGridCategories.AllowUserToAddRows = false;
            this.dataGridCategories.AllowUserToDeleteRows = false;
            this.dataGridCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCategories.Location = new System.Drawing.Point(16, 370);
            this.dataGridCategories.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridCategories.MultiSelect = false;
            this.dataGridCategories.Name = "dataGridCategories";
            this.dataGridCategories.ReadOnly = true;
            this.dataGridCategories.RowHeadersWidth = 51;
            this.dataGridCategories.Size = new System.Drawing.Size(1280, 373);
            this.dataGridCategories.TabIndex = 12;
            this.dataGridCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCategories_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(24, 306);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Фильтр по ID";
            // 
            // tbFilterByID
            // 
            this.tbFilterByID.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFilterByID.Location = new System.Drawing.Point(28, 332);
            this.tbFilterByID.Margin = new System.Windows.Forms.Padding(4);
            this.tbFilterByID.MaxLength = 5;
            this.tbFilterByID.Name = "tbFilterByID";
            this.tbFilterByID.Size = new System.Drawing.Size(164, 29);
            this.tbFilterByID.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(216, 306);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Фильтр по названию";
            // 
            // tbFilterName
            // 
            this.tbFilterName.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFilterName.Location = new System.Drawing.Point(220, 332);
            this.tbFilterName.Margin = new System.Windows.Forms.Padding(4);
            this.tbFilterName.Name = "tbFilterName";
            this.tbFilterName.Size = new System.Drawing.Size(381, 29);
            this.tbFilterName.TabIndex = 19;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelID.Location = new System.Drawing.Point(25, 23);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 22);
            this.labelID.TabIndex = 23;
            // 
            // FormCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 767);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbFilterByID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFilterName);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSaveEdits);
            this.Controls.Add(this.btnAddCAtegory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNameCategory);
            this.Controls.Add(this.dataGridCategories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCategories";
            this.Text = "Категории";
            this.Load += new System.EventHandler(this.FormCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSaveEdits;
        private System.Windows.Forms.Button btnAddCAtegory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNameCategory;
        private System.Windows.Forms.DataGridView dataGridCategories;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFilterByID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFilterName;
        private System.Windows.Forms.Label labelID;
    }
}