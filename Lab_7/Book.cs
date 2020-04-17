﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6
{
    class Book: Item
    {
        public string Author { get; set; }  // автор  
        public string Title { get; set; }    // название      
        
        //public string Publisher { get; set; }   // издательство  
        public Publisher Publ { get; set; }
        public int Pages { get; set; }  // кол-во страниц  
        public int Year { get; set; }   // год издания  

        private static double price;

        public static double Price 
        { 
            get { return price; } 
            set { if (value > 9) price = value; } 
        }

        public void SetBook(string author, string title, Publisher publisher, int pages, int year) 
        { 
            this.Author = author; 
            this.Title = title; 
            this.Publ = publisher; 
            this.Pages = pages; 
            this.Year = year; 
        }
        static Book()
        {
            price = 9;
        }
        public static void SetPrice(double price) 
        { 
            Book.Price = price; 
        }
        public override string ToString() 
        { 
            string bs = String.Format("\nКнига:\n Автор: {0}\n Название: {1}\n Год издания: {2}\n {3} стр.\n " +
                "Стоимость аренды: {4}\n Издательство{5}", Author, Title, Year, Pages, Book.price, Publ.ToString()); 
            return bs; 
        }

        public override void Print() 
        { 
            Console.WriteLine(this);
            base.Print();
        }
        public double PriceBook(int s) 
        { 
            double cust = s * price; 
            return cust; 
        }

        public Book(string author, string title, Publisher publisher, int pages, int year)
        {   
            this.Author = author;   
            this.Title = title;  
            this.Publ = publisher;  
            this.Pages = pages;
            this.Year = year;
        }
        public Book() 
        { }
        public Book(string author, string title) 
        { 
            this.Author = author; 
            this.Title = title; 
        }
        public override void TakeItem() 
        { 
            if (this.IsAvailable()) 
                this.Take(); 
        }
        public Book(string author, string title, Publisher publisher, 
            int pages, int year, long invNumber, bool taken) 
            : base(invNumber, taken) 
        { 
            this.Author = author; 
            this.Title = title; 
            this.Publ = publisher;
            this.Pages = pages; 
            this.Year = year; 
        }
        public bool returnSrok { get; private set; }
        public void ReturnSrok() 
        {
            returnSrok = true; 
        }
        public override void Return() 
        {      
            if (returnSrok == true)           
                taken = true;       
            else           
                taken = false; 
        }
    }
}
