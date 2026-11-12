namespace LibraryCatalogue
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public int PublishedYear { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }

        // Calculated: not a column, worked out from IsAvailable
        public string Availability
        {
            get { return IsAvailable ? "Available" : "On loan"; }
        }
    }
}
