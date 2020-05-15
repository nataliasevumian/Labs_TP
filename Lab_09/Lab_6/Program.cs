using System;
using System.Collections.Generic;
using Lab_6;

namespace MyClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publ1 = new Publisher("Издательство 1", "nauka@mail.ru", 123, new DateTime(2015, 10, 17));
            Book b1 = new Book("Пушкин А.С.", "Капитанская дочка", publ1, 123, 2018, 567, true);
           
            Publisher publ2 = new Publisher("Наука и жизнь", "nauka@mail.ru", 1234, new DateTime(2014, 12, 14));
            Book b2 = new Book("Толстой Л.Н.", "Война и мир", publ2, 1234, 2013, 101, true);

            Publisher publ3 = new Publisher("Издательство 3", "nauka@mail.ru", 12345, new DateTime(2016, 09, 13));
            Book b3 = new Book("Ф.М.Достоевский", "Преступление и наказание", publ3, 400, 2012, 444, false);

            Audit.RunAudit();
            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, true);
            //mag1.TakeItem(); 
            //mag1.Print();
            mag1.Subs();
            //mag1.Print();
            Magazine mag2 = new Magazine("О науке", 7, "Под микроскопом", 2012, 3000, true);
            Audit.StopAudit();
            mag2.Subs();

            List<Item> itlist = new List<Item>();
            itlist.AddRange(new Item[] { b1, b2, b3, mag1, mag2 });
            itlist.Sort();
            Console.WriteLine("\nСортировка по инвентарному номеру"); 
            foreach (Item x in itlist) 
            { 
                x.Print(); 
            }
            //it = mag1;
            //it.TakeItem();
            //it.Return();
            //it.Print();

            //Item item1 = new Item(); 
            //item1.Print();


            Console.WriteLine("Вычисление элемента прогрессий:\n");
            ArithmeticProgression ap = new ArithmeticProgression(5, 10);
            GeometricProgression gp = new GeometricProgression(2, 2);
            Console.WriteLine("Введите индекс:");
            int k = int.Parse(Console.ReadLine());
            double ap1 = ap.GetElement(k);
            double gp1 = gp.GetElement(k);
            Console.WriteLine("Элемент арифметической прогрессии с индексом {0} равен {1}\n" +
                "Элемент геометрической прогрессии с индексом {2} равен {3}",k, ap1,k, gp1);
        }
    }
}
