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
            this.btnDeleteShelf = new System.Windows.Forms.Button();
            this.btnAddShelf = new System.Windows.Forms.Button();
            this.labelTagName = new System.Windows.Forms.Label();
            this.tbNameShelf = new System.Windows.Forms.TextBox();
            this.dataGridShelves = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShelves)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteShelf
            // 
            this.btnDeleteShelf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.btnDeleteShelf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteShelf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteShelf.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteShelf.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeleteShelf.Location = new System.Drawing.Point(700, 64);
            this.btnDeleteShelf.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteShelf.Name = "btnDeleteShelf";
            this.btnDeleteShelf.Size = new System.Drawing.Size(203, 28);
            this.btnDeleteShelf.TabIndex = 28;
            this.btnDeleteShelf.Text = "Удалить запись";
            this.btnDeleteShelf.UseVisualStyleBackColor = false;
            // 
            // btnAddShelf
            // 
            this.btnAddShelf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(213)))));
            this.btnAddShelf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddShelf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddShelf.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddShelf.Location = new System.Drawing.Point(463, 64);
            this.btnAddShelf.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddShelf.Name = "btnAddShelf";
            this.btnAddShelf.Size = new System.Drawing.Size(203, 28);
            this.btnAddShelf.TabIndex = 27;
            this.btnAddShelf.Text = "Добавить полку";
            this.btnAddShelf.UseVisualStyleBackColor = false;
            // 
            // labelTagName
            // 
            this.labelTagName.AutoSize = true;
            this.labelTagName.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTagName.Location = new System.Drawing.Point(24, 37);
            this.labelTagName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTagName.Name = "labelTagName";
            this.labelTagName.Size = new System.Drawing.Size(57, 22);
            this.labelTagName.TabIndex = 26;
            this.labelTagName.Text = "Полка";
            // 
            // tbNameShelf
            // 
            this.tbNameShelf.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNameShelf.Location = new System.Drawing.Point(28, 64);
            this.tbNameShelf.Margin = new System.Windows.Forms.Padding(4);
            this.tbNameShelf.Name = "tbNameShelf";
            this.tbNameShelf.Size = new System.Drawing.Size(381, 29);
            this.tbNameShelf.TabIndex = 25;
            // 
            // dataGridShelves
            // 
            this.dataGridShelves.AllowUserToAddRows = false;
            this.dataGridShelves.AllowUserToDeleteRows = false;
            this.dataGridShelves.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridShelves.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridShelves.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridShelves.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridShelves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridShelves.Location = new System.Drawing.Point(16, 216);
            this.dataGridShelves.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridShelves.MultiSelect = false;
            this.dataGridShelves.Name = "dataGridShelves";
            this.dataGridShelves.ReadOnly = true;
            this.dataGridShelves.RowHeadersWidth = 51;
            this.dataGridShelves.Size = new System.Drawing.Size(1474, 510);
            this.dataGridShelves.TabIndex = 24;
            // 
            // FormJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 763);
            this.Controls.Add(this.btnDeleteShelf);
            this.Controls.Add(this.btnAddShelf);
            this.Controls.Add(this.labelTagName);
            this.Controls.Add(this.tbNameShelf);
            this.Controls.Add(this.dataGridShelves);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormJournal";
            this.Text = "Журнал";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShelves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteShelf;
        private System.Windows.Forms.Button btnAddShelf;
        private System.Windows.Forms.Label labelTagName;
        private System.Windows.Forms.TextBox tbNameShelf;
        private System.Windows.Forms.DataGridView dataGridShelves;
    }
}