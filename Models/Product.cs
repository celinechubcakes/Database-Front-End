﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UNFBooks.Models
{
    public class Product
<<<<<<< Updated upstream
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
=======
    {   
        public long Id { get; set; }
        public int ISBNNumber { get; set; }
        public string BookTitle { get; set; }
        public string PublicationDate { get; set; }
        public string BookGenre { get; set; }
        public int ReadingLevel { get; set; }
        public int UserRating { get; set; }
        public string UserComments { get; set; }
        public string BookSummary { get; set; }
        public decimal RentalPrice { get; set; }
        public decimal PurchasePrice { get; set; }
        public string BookType { get; set; }
        public decimal BookLengthPages { get; set; }
        public decimal BookLengthAudio { get; set; }
        public int AmountInStock { get; set; }
        public string BookSeries { get; set; }
        public int PublishedEdition { get; set; }
        public string BookNewOrUsed { get; set; }
>>>>>>> Stashed changes
    }
}