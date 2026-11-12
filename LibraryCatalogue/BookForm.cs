namespace LibraryCatalogue
{
    public partial class BookForm : Form
    {
        public Book CurrentBook { get; private set; }

        public BookForm()
        {
            InitializeComponent();
            CurrentBook = new Book();
            Text = "Add book";
            LoadGenres();
            numYear.Value = DateTime.Now.Year;
            numPrice.Value = 10.00m;
            chkAvailable.Checked = true;
        }

        public BookForm(Book book) : this()
        {
            CurrentBook = book;
            Text = "Edit book";
            txtTitle.Text = book.Title;
            txtAuthor.Text = book.Author;
            cmbGenre.SelectedItem = book.Genre;
            numYear.Value = book.PublishedYear;
            numPrice.Value = book.Price;
            chkAvailable.Checked = book.IsAvailable;
        }

        private void LoadGenres()
        {
            cmbGenre.Items.Clear();
            cmbGenre.Items.Add("Fiction");
            cmbGenre.Items.Add("Non-fiction");
            cmbGenre.Items.Add("Mystery");
            cmbGenre.Items.Add("Science");
            cmbGenre.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Title is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Author is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAuthor.Focus();
                return;
            }

            if (cmbGenre.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a genre.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGenre.Focus();
                return;
            }

            // Subject-specific rule: published year cannot be in the future
            if ((int)numYear.Value > DateTime.Now.Year)
            {
                MessageBox.Show("Published year cannot be in the future.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numYear.Focus();
                return;
            }

            CurrentBook.Title = txtTitle.Text.Trim();
            CurrentBook.Author = txtAuthor.Text.Trim();
            CurrentBook.Genre = cmbGenre.SelectedItem!.ToString()!;
            CurrentBook.PublishedYear = (int)numYear.Value;
            CurrentBook.Price = numPrice.Value;
            CurrentBook.IsAvailable = chkAvailable.Checked;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
