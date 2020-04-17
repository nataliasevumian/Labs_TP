using System;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.SetBook("Пушкин А.С.", "Капитанская дочка", "Вильямс", 123, 2018);
            b1.Print();
            Console.WriteLine("\n Итоговая стоимость аренды: {0} p.", b1.PriceBook(3));
            
            Book b2 = new Book("Толстой Л.Н.", "Война и мир", "Наука и жизнь", 1234, 2013);
            b2.Print();

            Book b3 = new Book("Лермонтов М.Ю.", "Мцыри");
            b3.Print();

            Triangle t1 = new Triangle(5, 4, 3);
            t1.Print();
            Console.WriteLine("Периметр треугольника равен {0}", t1.Perimetr());
            Console.WriteLine("Площадь треугольника равна {0}", t1.Square());

            Triangle t2 = new Triangle(7, 1, 1);
            t2.Print();
            Console.WriteLine("Периметр треугольника равен {0}", t2.Perimetr());
            Console.WriteLine("Площадь треугольника равна {0}", t2.Square());

        }
    }
}
