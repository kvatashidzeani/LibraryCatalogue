namespace LibraryCatalogue
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblSearch = new Label();
            txtSearch = new TextBox();
            cmbGenre = new ComboBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnExport = new Button();
            dgvBooks = new DataGridView();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(16, 18);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(53, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(75, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(220, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cmbGenre
            // 
            cmbGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenre.FormattingEnabled = true;
            cmbGenre.Location = new Point(310, 15);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(150, 28);
            cmbGenre.TabIndex = 2;
            cmbGenre.SelectedIndexChanged += cmbGenre_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(560, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 32);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Location = new Point(646, 12);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(80, 32);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(732, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 32);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExport.Location = new Point(818, 12);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(80, 32);
            btnExport.TabIndex = 6;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(16, 56);
            dgvBooks.MultiSelect = false;
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.RowTemplate.Height = 28;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(882, 420);
            dgvBooks.TabIndex = 7;
            dgvBooks.CellDoubleClick += dgvBooks_CellDoubleClick;
            dgvBooks.CellFormatting += dgvBooks_CellFormatting;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.BackColor = Color.FromArgb(200, 230, 201);
            lblStatus.Location = new Point(16, 486);
            lblStatus.Name = "lblStatus";
            lblStatus.Padding = new Padding(8, 0, 0, 0);
            lblStatus.Size = new Size(882, 32);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Ready";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 531);
            Controls.Add(lblStatus);
            Controls.Add(dgvBooks);
            Controls.Add(btnExport);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(cmbGenre);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            MinimumSize = new Size(700, 400);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Catalogue";
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSearch;
        private TextBox txtSearch;
        private ComboBox cmbGenre;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnExport;
        private DataGridView dgvBooks;
        private Label lblStatus;
    }
}
