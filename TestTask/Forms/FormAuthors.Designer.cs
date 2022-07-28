namespace TestTask.Forms
{
    partial class FormAuthors
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
            this.btnDeleteAuthor = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.labelTagName = new System.Windows.Forms.Label();
            this.tbNameAuthor = new System.Windows.Forms.TextBox();
            this.dataGridAuthor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteAuthor
            // 
            this.btnDeleteAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.btnDeleteAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteAuthor.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteAuthor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeleteAuthor.Location = new System.Drawing.Point(700, 64);
            this.btnDeleteAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteAuthor.Name = "btnDeleteAuthor";
            this.btnDeleteAuthor.Size = new System.Drawing.Size(203, 28);
            this.btnDeleteAuthor.TabIndex = 23;
            this.btnDeleteAuthor.Text = "Удалить запись";
            this.btnDeleteAuthor.UseVisualStyleBackColor = false;
            this.btnDeleteAuthor.Click += new System.EventHandler(this.btnDeleteAuthor_Click);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(213)))));
            this.btnAddAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddAuthor.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddAuthor.Location = new System.Drawing.Point(463, 64);
            this.btnAddAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(203, 28);
            this.btnAddAuthor.TabIndex = 22;
            this.btnAddAuthor.Text = "Добавить автора";
            this.btnAddAuthor.UseVisualStyleBackColor = false;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // labelTagName
            // 
            this.labelTagName.AutoSize = true;
            this.labelTagName.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTagName.Location = new System.Drawing.Point(24, 37);
            this.labelTagName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTagName.Name = "labelTagName";
            this.labelTagName.Size = new System.Drawing.Size(55, 22);
            this.labelTagName.TabIndex = 21;
            this.labelTagName.Text = "Автор";
            // 
            // tbNameAuthor
            // 
            this.tbNameAuthor.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNameAuthor.Location = new System.Drawing.Point(28, 64);
            this.tbNameAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.tbNameAuthor.Name = "tbNameAuthor";
            this.tbNameAuthor.Size = new System.Drawing.Size(381, 29);
            this.tbNameAuthor.TabIndex = 20;
            // 
            // dataGridAuthor
            // 
            this.dataGridAuthor.AllowUserToAddRows = false;
            this.dataGridAuthor.AllowUserToDeleteRows = false;
            this.dataGridAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridAuthor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAuthor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAuthor.Location = new System.Drawing.Point(16, 127);
            this.dataGridAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridAuthor.MultiSelect = false;
            this.dataGridAuthor.Name = "dataGridAuthor";
            this.dataGridAuthor.ReadOnly = true;
            this.dataGridAuthor.RowHeadersWidth = 51;
            this.dataGridAuthor.Size = new System.Drawing.Size(1474, 599);
            this.dataGridAuthor.TabIndex = 19;
            this.dataGridAuthor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAuthor_CellClick);
            // 
            // FormAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 763);
            this.Controls.Add(this.btnDeleteAuthor);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.labelTagName);
            this.Controls.Add(this.tbNameAuthor);
            this.Controls.Add(this.dataGridAuthor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAuthors";
            this.Text = "Авторы";
            this.Load += new System.EventHandler(this.FormTags_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteAuthor;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Label labelTagName;
        private System.Windows.Forms.TextBox tbNameAuthor;
        private System.Windows.Forms.DataGridView dataGridAuthor;
    }
}