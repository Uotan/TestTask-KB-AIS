namespace TestTask.Forms
{
    partial class FormTags
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
            this.labelTagName = new System.Windows.Forms.Label();
            this.tbNameCategory = new System.Windows.Forms.TextBox();
            this.dataGridTags = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTags)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.btnDeleteCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteCategory.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteCategory.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeleteCategory.Location = new System.Drawing.Point(525, 52);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(152, 23);
            this.btnDeleteCategory.TabIndex = 23;
            this.btnDeleteCategory.Text = "Удалить запись";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            // 
            // btnAddCAtegory
            // 
            this.btnAddCAtegory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(213)))));
            this.btnAddCAtegory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCAtegory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCAtegory.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddCAtegory.Location = new System.Drawing.Point(347, 52);
            this.btnAddCAtegory.Name = "btnAddCAtegory";
            this.btnAddCAtegory.Size = new System.Drawing.Size(152, 23);
            this.btnAddCAtegory.TabIndex = 22;
            this.btnAddCAtegory.Text = "Добавить тэг\r\n";
            this.btnAddCAtegory.UseVisualStyleBackColor = false;
            // 
            // labelTagName
            // 
            this.labelTagName.AutoSize = true;
            this.labelTagName.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTagName.Location = new System.Drawing.Point(18, 30);
            this.labelTagName.Name = "labelTagName";
            this.labelTagName.Size = new System.Drawing.Size(26, 18);
            this.labelTagName.TabIndex = 21;
            this.labelTagName.Text = "Тэг";
            // 
            // tbNameCategory
            // 
            this.tbNameCategory.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNameCategory.Location = new System.Drawing.Point(21, 52);
            this.tbNameCategory.Name = "tbNameCategory";
            this.tbNameCategory.Size = new System.Drawing.Size(287, 25);
            this.tbNameCategory.TabIndex = 20;
            // 
            // dataGridTags
            // 
            this.dataGridTags.AllowUserToAddRows = false;
            this.dataGridTags.AllowUserToDeleteRows = false;
            this.dataGridTags.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridTags.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTags.Location = new System.Drawing.Point(12, 103);
            this.dataGridTags.MultiSelect = false;
            this.dataGridTags.Name = "dataGridTags";
            this.dataGridTags.ReadOnly = true;
            this.dataGridTags.RowHeadersWidth = 51;
            this.dataGridTags.Size = new System.Drawing.Size(960, 490);
            this.dataGridTags.TabIndex = 19;
            // 
            // FormTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 623);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnAddCAtegory);
            this.Controls.Add(this.labelTagName);
            this.Controls.Add(this.tbNameCategory);
            this.Controls.Add(this.dataGridTags);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTags";
            this.Text = "FormTags";
            this.Load += new System.EventHandler(this.FormTags_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTags)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnAddCAtegory;
        private System.Windows.Forms.Label labelTagName;
        private System.Windows.Forms.TextBox tbNameCategory;
        private System.Windows.Forms.DataGridView dataGridTags;
    }
}