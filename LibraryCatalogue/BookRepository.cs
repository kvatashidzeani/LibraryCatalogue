using Microsoft.Data.SqlClient;

namespace LibraryCatalogue
{
    public class BookRepository
    {
        private readonly string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryDb;" +
            "Integrated Security=True;TrustServerCertificate=True";

        public List<Book> Search(string text, string genre)
        {
            List<Book> books = new List<Book>();
            string sql =
                "SELECT Id, Title, Author, Genre, PublishedYear, Price, IsAvailable " +
                "FROM Books " +
                "WHERE (@text = N'' OR Title LIKE @pattern OR Author LIKE @pattern) " +
                "  AND (@genre = N'' OR Genre = @genre) " +
                "ORDER BY Title";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@text", text);
                command.Parameters.AddWithValue("@pattern", "%" + text + "%");
                command.Parameters.AddWithValue("@genre", genre);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Book book = new Book();
                        book.Id = (int)reader["Id"];
                        book.Title = (string)reader["Title"];
                        book.Author = (string)reader["Author"];
                        book.Genre = (string)reader["Genre"];
                        book.PublishedYear = (int)reader["PublishedYear"];
                        book.Price = (decimal)reader["Price"];
                        book.IsAvailable = (bool)reader["IsAvailable"];
                        books.Add(book);
                    }
                }
            }
            return books;
        }

        public int CountAll()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Books", connection))
            {
                connection.Open();
                return (int)command.ExecuteScalar();
            }
        }

        public void Add(Book book)
        {
            string sql =
                "INSERT INTO Books (Title, Author, Genre, PublishedYear, Price, IsAvailable) " +
                "VALUES (@title, @author, @genre, @year, @price, @available)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@title", book.Title);
                command.Parameters.AddWithValue("@author", book.Author);
                command.Parameters.AddWithValue("@genre", book.Genre);
                command.Parameters.AddWithValue("@year", book.PublishedYear);
                command.Parameters.AddWithValue("@price", book.Price);
                command.Parameters.AddWithValue("@available", book.IsAvailable);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Update(Book book)
        {
            string sql =
                "UPDATE Books SET Title = @title, Author = @author, Genre = @genre, " +
                "PublishedYear = @year, Price = @price, IsAvailable = @available " +
                "WHERE Id = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@title", book.Title);
                command.Parameters.AddWithValue("@author", book.Author);
                command.Parameters.AddWithValue("@genre", book.Genre);
                command.Parameters.AddWithValue("@year", book.PublishedYear);
                command.Parameters.AddWithValue("@price", book.Price);
                command.Parameters.AddWithValue("@available", book.IsAvailable);
                command.Parameters.AddWithValue("@id", book.Id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            string sql = "DELETE FROM Books WHERE Id = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
