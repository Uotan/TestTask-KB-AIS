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
            this.btnDeleteTag = new System.Windows.Forms.Button();
            this.btnAddTag = new System.Windows.Forms.Button();
            this.labelTagName = new System.Windows.Forms.Label();
            this.tbNameTag = new System.Windows.Forms.TextBox();
            this.dataGridTags = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTags)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteTag
            // 
            this.btnDeleteTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(76)))), ((int)(((byte)(98)))));
            this.btnDeleteTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteTag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteTag.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteTag.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeleteTag.Location = new System.Drawing.Point(700, 64);
            this.btnDeleteTag.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteTag.Name = "btnDeleteTag";
            this.btnDeleteTag.Size = new System.Drawing.Size(203, 28);
            this.btnDeleteTag.TabIndex = 23;
            this.btnDeleteTag.Text = "Удалить запись";
            this.btnDeleteTag.UseVisualStyleBackColor = false;
            this.btnDeleteTag.Click += new System.EventHandler(this.btnDeleteTag_Click);
            // 
            // btnAddTag
            // 
            this.btnAddTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(213)))));
            this.btnAddTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddTag.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddTag.Location = new System.Drawing.Point(463, 64);
            this.btnAddTag.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(203, 28);
            this.btnAddTag.TabIndex = 22;
            this.btnAddTag.Text = "Добавить тэг\r\n";
            this.btnAddTag.UseVisualStyleBackColor = false;
            this.btnAddTag.Click += new System.EventHandler(this.btnAddTag_Click);
            // 
            // labelTagName
            // 
            this.labelTagName.AutoSize = true;
            this.labelTagName.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTagName.Location = new System.Drawing.Point(24, 37);
            this.labelTagName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTagName.Name = "labelTagName";
            this.labelTagName.Size = new System.Drawing.Size(32, 22);
            this.labelTagName.TabIndex = 21;
            this.labelTagName.Text = "Тэг";
            // 
            // tbNameTag
            // 
            this.tbNameTag.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNameTag.Location = new System.Drawing.Point(28, 64);
            this.tbNameTag.Margin = new System.Windows.Forms.Padding(4);
            this.tbNameTag.Name = "tbNameTag";
            this.tbNameTag.Size = new System.Drawing.Size(381, 29);
            this.tbNameTag.TabIndex = 20;
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
            this.dataGridTags.Location = new System.Drawing.Point(16, 127);
            this.dataGridTags.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridTags.MultiSelect = false;
            this.dataGridTags.Name = "dataGridTags";
            this.dataGridTags.ReadOnly = true;
            this.dataGridTags.RowHeadersWidth = 51;
            this.dataGridTags.Size = new System.Drawing.Size(1280, 603);
            this.dataGridTags.TabIndex = 19;
            this.dataGridTags.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTags_CellClick);
            // 
            // FormTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 767);
            this.Controls.Add(this.btnDeleteTag);
            this.Controls.Add(this.btnAddTag);
            this.Controls.Add(this.labelTagName);
            this.Controls.Add(this.tbNameTag);
            this.Controls.Add(this.dataGridTags);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTags";
            this.Text = "Тэги";
            this.Load += new System.EventHandler(this.FormTags_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTags)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteTag;
        private System.Windows.Forms.Button btnAddTag;
        private System.Windows.Forms.Label labelTagName;
        private System.Windows.Forms.TextBox tbNameTag;
        private System.Windows.Forms.DataGridView dataGridTags;
    }
}