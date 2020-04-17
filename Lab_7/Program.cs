using System;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Book b1 = new Book();
            //b1.SetBook("Пушкин А.С.", "Капитанская дочка", "Вильямс", 123, 2018);
            //b1.Print();
            //Console.WriteLine("\n Итоговая стоимость аренды: {0} p.", b1.PriceBook(3));
            Publisher publ = new Publisher("Наука и жизнь", "nauka@mail.ru", 1234,
                new DateTime(2014, 12, 14));

            Book b2 = new Book("Толстой Л.Н.", "Война и мир", publ, 1234, 2013, 101, true);
            //b2.TakeItem();
            //b2.Print();

            b2.ReturnSrok(); 
            Item it; 
            it = b2; 
            it.TakeItem(); 
            it.Return(); 
            it.Print(); 
            

            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, true);
            //mag1.TakeItem(); 
            //mag1.Print();

            it = mag1;
            it.TakeItem();
            it.Return();
            it.Print();

            //Item item1 = new Item(); 
            //item1.Print();


            //Console.WriteLine("\n Тестирование полиморфизма"); 
            //Item it;
            //it = b2; 
            //it.Return();
            //it.Print();

            //it = mag1; 
            //it.Return();
            //it.Print();

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
