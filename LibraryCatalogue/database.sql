IF DB_ID(N'LibraryDb') IS NULL
    CREATE DATABASE LibraryDb;
GO

USE LibraryDb;
GO

IF OBJECT_ID(N'dbo.Books', N'U') IS NULL
CREATE TABLE Books
(
    Id            INT IDENTITY(1,1) PRIMARY KEY,
    Title         NVARCHAR(150) NOT NULL,
    Author        NVARCHAR(100) NOT NULL,
    Genre         NVARCHAR(50)  NOT NULL,
    PublishedYear INT           NOT NULL,
    Price         DECIMAL(6,2)  NOT NULL,
    IsAvailable   BIT           NOT NULL
);
GO

IF NOT EXISTS (SELECT 1 FROM Books)
BEGIN
    INSERT INTO Books (Title, Author, Genre, PublishedYear, Price, IsAvailable) VALUES
    (N'1984', N'George Orwell', N'Fiction', 1949, 22.50, 1),
    (N'Animal Farm', N'George Orwell', N'Fiction', 1945, 18.50, 0),
    (N'Homage to Catalonia', N'George Orwell', N'Non-fiction', 1938, 19.99, 1),
    (N'Pride and Prejudice', N'Jane Austen', N'Fiction', 1813, 16.00, 1),
    (N'Murder on the Orient Express', N'Agatha Christie', N'Mystery', 1934, 17.25, 0),
    (N'The Murder of Roger Ackroyd', N'Agatha Christie', N'Mystery', 1926, 15.90, 1),
    (N'A Brief History of Time', N'Stephen Hawking', N'Science', 1988, 24.00, 1),
    (N'Cosmos', N'Carl Sagan', N'Science', 1980, 21.50, 0),
    (N'The Great Gatsby', N'F. Scott Fitzgerald', N'Fiction', 1925, 14.75, 1),
    (N'To Kill a Mockingbird', N'Harper Lee', N'Fiction', 1960, 18.00, 1),
    (N'Data from the Unconscious', N'Dimitri Uznadze', N'Non-fiction', 1966, 20.00, 1),
    (N'Vazha-Pshavela: Selected Poems', N'Vazha-Pshavela', N'Fiction', 1961, 12.50, 0),
    (N'კაცია-ადამიანი?!', N'ილია ჭავჭავაძე', N'Fiction', 1859, 13.90, 1),
    (N'Sapiens', N'Yuval Noah Harari', N'Non-fiction', 2011, 26.50, 1),
    (N'The Silent Patient', N'Alex Michaelides', N'Mystery', 2019, 19.40, 0),
    (N'The Martian', N'Andy Weir', N'Science', 2011, 18.80, 1),
    (N'Educated', N'Tara Westover', N'Non-fiction', 2018, 23.10, 1);
END
GO