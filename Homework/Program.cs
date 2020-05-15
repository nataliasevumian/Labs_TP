using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("ИКТ", "K3121", "Севумян", "Наталья", "Ренатовна", new DateTime(2001, 10, 17));

            Teacher tc1 = new Teacher("ИКТ", "Преподаватель информатики", 30, new DateTime(2010, 01, 01), 
                "Иванов", "Никита", "Владимирович", new DateTime(1980, 05, 19));

            Manager m1 = new Manager("ФТМИ", "Менеджер по успеваемости студентов", 25, new DateTime(2012, 09, 01), 
                "Тувыкин", "Дмитрий", "Анатольевич", new DateTime(1985, 09, 13));

            Administrator ad1 = new Administrator("Лаборатория квантовой информатики", 40, new DateTime(2017, 09, 01), 
                "Ковалев", "Игорь", "Витальевич", new DateTime(1970, 12, 16));

            List<Person> itlist = new List<Person>();
            itlist.AddRange(new Person[] { st1, tc1, m1, ad1 });
            itlist.Sort();
            Console.WriteLine("Сортировка по возрасту:\n");
            foreach (Person x in itlist)
            {
                x.Print();
            }

            foreach (Person x in itlist)
            {
                x.Equal(x, 15, 40);
            }

            tc1.NotAtWork();
            m1.AtWork();

            List<IEmployee> employees = new List<IEmployee>();
            employees.AddRange(new IEmployee[] { tc1, m1, ad1 });
            foreach (IEmployee e in employees)
            {
                if (e.Place == true)
                    Console.WriteLine("{0} на рабочем месте", e.GetFullName());
                else
                    Console.WriteLine("{0} не на рабочем месте", e.GetFullName());
            }

        }
    }
}
