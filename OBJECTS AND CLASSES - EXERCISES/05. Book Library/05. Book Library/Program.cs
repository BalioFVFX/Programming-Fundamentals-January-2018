﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
namespace _05._Book_Library
{

    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        DateTime PublishDate;
        public string ISBNNumber { get; set; }
        public double Price { get; set; }

        public Book(string name, string author, string publisher, DateTime publishDate, string isbnNumber, double price)
        {
            Name = name;
            Author = author;
            Publisher = publisher;
            PublishDate = publishDate;
            ISBNNumber = isbnNumber;
            Price = price;
        }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
        public Library()
        {

            Books = new List<Book>();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBooks = int.Parse(Console.ReadLine());
            Library library = new Library();

            for (int i = 0; i < numberOfBooks; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string title = input[0];
                string author = input[1];
                string publisher = input[2];
                DateTime releaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                string isbnNumber = input[4];
                double price = double.Parse(input[5]);
                Book currentBook = new Book(title, author, publisher, releaseDate, isbnNumber, price);
                library.Books.Add(currentBook);
            }

            foreach (var book in library.Books.GroupBy(x => x.Author).OrderByDescending(x => x.Sum(y => y.Price)).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{book.Key} -> {book.Sum(x => x.Price):f2}");
            }
        }
    }
}
