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
            this.btnAddCAtegory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNameCategory = new System.Windows.Forms.TextBox();
            this.dataGridCategories = new System.Windows.Forms.DataGridView();
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
            this.btnDeleteCategory.Location = new System.Drawing.Point(700, 78);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(203, 28);
            this.btnDeleteCategory.TabIndex = 18;
            this.btnDeleteCategory.Text = "Удалить запись";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnAddCAtegory
            // 
            this.btnAddCAtegory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(213)))));
            this.btnAddCAtegory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCAtegory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCAtegory.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddCAtegory.Location = new System.Drawing.Point(463, 78);
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
            this.label2.Location = new System.Drawing.Point(24, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Название категории";
            // 
            // tbNameCategory
            // 
            this.tbNameCategory.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNameCategory.Location = new System.Drawing.Point(28, 78);
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
            this.dataGridCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCategories.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCategories.Location = new System.Drawing.Point(16, 140);
            this.dataGridCategories.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridCategories.MultiSelect = false;
            this.dataGridCategories.Name = "dataGridCategories";
            this.dataGridCategories.ReadOnly = true;
            this.dataGridCategories.RowHeadersWidth = 51;
            this.dataGridCategories.Size = new System.Drawing.Size(1474, 599);
            this.dataGridCategories.TabIndex = 12;
            this.dataGridCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCategories_CellClick);
            // 
            // FormCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 763);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnAddCAtegory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNameCategory);
            this.Controls.Add(this.dataGridCategories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCategories";
            this.Text = "Категории";
            this.Load += new System.EventHandler(this.FormCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnAddCAtegory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNameCategory;
        private System.Windows.Forms.DataGridView dataGridCategories;
    }
}