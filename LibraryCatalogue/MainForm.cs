using System.Text;

namespace LibraryCatalogue
{
    public partial class MainForm : Form
    {
        private readonly BookRepository repository = new BookRepository();

        public MainForm()
        {
            InitializeComponent();
            LoadFilterGenres();
            SetupGrid();
            LoadBooks();
        }

        private void LoadFilterGenres()
        {
            cmbGenre.Items.Clear();
            cmbGenre.Items.Add("All");
            cmbGenre.Items.Add("Fiction");
            cmbGenre.Items.Add("Non-fiction");
            cmbGenre.Items.Add("Mystery");
            cmbGenre.Items.Add("Science");
            cmbGenre.SelectedIndex = 0;
        }

        private void SetupGrid()
        {
            dgvBooks.AutoGenerateColumns = false;
            dgvBooks.Columns.Clear();

            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                Name = "colId",
                HeaderText = "Id",
                Visible = false
            });
            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Title",
                Name = "colTitle",
                HeaderText = "Title",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Author",
                Name = "colAuthor",
                HeaderText = "Author",
                Width = 160
            });
            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Genre",
                Name = "colGenre",
                HeaderText = "Genre",
                Width = 110
            });
            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PublishedYear",
                Name = "colYear",
                HeaderText = "Year",
                Width = 70
            });
            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                Name = "colPrice",
                HeaderText = "Price",
                DefaultCellStyle = { Format = "N2" },
                Width = 80
            });
            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Availability",
                Name = "colAvailability",
                HeaderText = "Status",
                Width = 100
            });
        }

        private void LoadBooks(string? statusMessage = null)
        {
            string searchText = txtSearch.Text.Trim();
            string genre = cmbGenre.SelectedIndex <= 0
                ? string.Empty
                : cmbGenre.SelectedItem!.ToString()!;

            List<Book> books = repository.Search(searchText, genre);
            dgvBooks.DataSource = books;

            int total = repository.CountAll();
            if (!string.IsNullOrEmpty(statusMessage))
            {
                lblStatus.Text = statusMessage;
                lblStatus.BackColor = Color.FromArgb(200, 230, 201);
            }
            else if (books.Count == 0)
            {
                lblStatus.Text = "No books match your search.";
                lblStatus.BackColor = Color.FromArgb(252, 228, 226);
            }
            else
            {
                lblStatus.Text = $"Found {books.Count} of {total}";
                lblStatus.BackColor = Color.FromArgb(200, 230, 201);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void cmbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (BookForm form = new BookForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    repository.Add(form.CurrentBook);
                    LoadBooks("Book added.");
                    return;
                }
            }
            LoadBooks();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null)
            {
                MessageBox.Show("Please select a book to edit.", "Edit",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Book selected = (Book)dgvBooks.CurrentRow.DataBoundItem!;

            using (BookForm form = new BookForm(selected))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    repository.Update(form.CurrentBook);
                    LoadBooks("Book updated.");
                    return;
                }
            }
            LoadBooks();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null)
            {
                MessageBox.Show("Please select a book to delete.", "Delete",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Book selected = (Book)dgvBooks.CurrentRow.DataBoundItem!;
            DialogResult answer = MessageBox.Show(
                $"Delete \"{selected.Title}\" by {selected.Author}?",
                "Confirm delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer != DialogResult.Yes)
                return;

            repository.Delete(selected.Id);
            LoadBooks("Book deleted.");
        }

        private void dgvBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                btnEdit_Click(sender, e);
        }

        private void dgvBooks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            Book? book = dgvBooks.Rows[e.RowIndex].DataBoundItem as Book;
            if (book != null && !book.IsAvailable && e.CellStyle != null)
                e.CellStyle.BackColor = Color.FromArgb(252, 228, 226);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvBooks.DataSource is not List<Book> books || books.Count == 0)
            {
                MessageBox.Show("There are no rows to export.", "Export",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "CSV files (*.csv)|*.csv";
                dialog.FileName = "books.csv";
                dialog.Title = "Export books to CSV";

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                StringBuilder csv = new StringBuilder();
                csv.AppendLine("Title,Author,Genre,Year,Price,Status");

                foreach (Book book in books)
                {
                    csv.AppendLine(
                        EscapeCsv(book.Title) + "," +
                        EscapeCsv(book.Author) + "," +
                        EscapeCsv(book.Genre) + "," +
                        book.PublishedYear + "," +
                        book.Price.ToString("0.00") + "," +
                        EscapeCsv(book.Availability));
                }

                File.WriteAllText(dialog.FileName, csv.ToString(), Encoding.UTF8);
                lblStatus.Text = "Exported to CSV.";
                lblStatus.BackColor = Color.FromArgb(200, 230, 201);
            }
        }

        private static string EscapeCsv(string value)
        {
            if (value.Contains('"') || value.Contains(',') || value.Contains('\n'))
                return "\"" + value.Replace("\"", "\"\"") + "\"";
            return value;
        }
    }
}
