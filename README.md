# Library Catalogue

Author: Ani Kvatashidze

Keeps a catalogue of books. You can list them, search by title or
author, filter by genre, add, edit or delete a book, and export the
current list to a CSV file.

## Table: Books

Id, Title, Author, Genre, PublishedYear, Price, IsAvailable

## How to run it

1. Visual Studio → View → SQL Server Object Explorer
2. Right-click `(localdb)\MSSQLLocalDB` → New Query
3. Paste `LibraryCatalogue/database.sql` and press Execute
4. Open `LibraryCatalogue.sln`
5. Build → Rebuild Solution, then F5
