namespace LibraryCatalogue
{
    partial class BookForm
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
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblAuthor = new Label();
            txtAuthor = new TextBox();
            lblGenre = new Label();
            cmbGenre = new ComboBox();
            lblYear = new Label();
            numYear = new NumericUpDown();
            lblPrice = new Label();
            numPrice = new NumericUpDown();
            chkAvailable = new CheckBox();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(24, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(140, 25);
            txtTitle.MaxLength = 150;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(280, 27);
            txtTitle.TabIndex = 1;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(24, 68);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(54, 20);
            lblAuthor.TabIndex = 2;
            lblAuthor.Text = "Author";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(140, 65);
            txtAuthor.MaxLength = 100;
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(280, 27);
            txtAuthor.TabIndex = 3;
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(24, 108);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(48, 20);
            lblGenre.TabIndex = 4;
            lblGenre.Text = "Genre";
            // 
            // cmbGenre
            // 
            cmbGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenre.FormattingEnabled = true;
            cmbGenre.Location = new Point(140, 105);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(280, 28);
            cmbGenre.TabIndex = 5;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(24, 148);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(38, 20);
            lblYear.TabIndex = 6;
            lblYear.Text = "Year";
            // 
            // numYear
            // 
            numYear.Location = new Point(140, 145);
            numYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numYear.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(120, 27);
            numYear.TabIndex = 7;
            numYear.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(24, 188);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price";
            // 
            // numPrice
            // 
            numPrice.DecimalPlaces = 2;
            numPrice.Location = new Point(140, 185);
            numPrice.Maximum = new decimal(new int[] { 9999, 0, 0, 131072 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(120, 27);
            numPrice.TabIndex = 9;
            // 
            // chkAvailable
            // 
            chkAvailable.AutoSize = true;
            chkAvailable.Location = new Point(140, 228);
            chkAvailable.Name = "chkAvailable";
            chkAvailable.Size = new Size(93, 24);
            chkAvailable.TabIndex = 10;
            chkAvailable.Text = "Available";
            chkAvailable.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(220, 280);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 32);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(326, 280);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 32);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // BookForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(444, 336);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(chkAvailable);
            Controls.Add(numPrice);
            Controls.Add(lblPrice);
            Controls.Add(numYear);
            Controls.Add(lblYear);
            Controls.Add(cmbGenre);
            Controls.Add(lblGenre);
            Controls.Add(txtAuthor);
            Controls.Add(lblAuthor);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BookForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Book";
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtTitle;
        private Label lblAuthor;
        private TextBox txtAuthor;
        private Label lblGenre;
        private ComboBox cmbGenre;
        private Label lblYear;
        private NumericUpDown numYear;
        private Label lblPrice;
        private NumericUpDown numPrice;
        private CheckBox chkAvailable;
        private Button btnSave;
        private Button btnCancel;
    }
}
