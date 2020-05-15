using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework
{
    public abstract class Person : IComparable
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public DateTime Birthday { get; protected set; }

        public Person(string Surname, string Name, string Patronymic, DateTime birth)
        {
            this.Surname = Surname;
            this.Name = Name;
            this.Patronymic = Patronymic;
            this.Birthday = birth;
        }
        public string GetFullName()
        {
            string fullname = Surname + " " + Name + " " + Patronymic;
            return fullname;
        }
        public int GetAge()
        {
            int age = DateTime.Now.Year - Birthday.Year;
            if (DateTime.Now.Month - Birthday.Month < 0)
                age -= 1;
            if (DateTime.Now.Month - Birthday.Month == 0)
            {
                if (DateTime.Now.Day - Birthday.Day < 0)
                    age -= 1;
            }
            return age;
        }
        public virtual void Print()
        {
            Console.WriteLine("Полное имя: {0}\nВозраст: {1}\n", this.GetFullName(), this.GetAge());
        }
        int IComparable.CompareTo(object obj)
        {
            Person it = (Person)obj;
            if (this.GetAge() == it.GetAge())
                return 0;
            else if (this.GetAge() > it.GetAge())
                return 1;
            else
                return -1;
        }
        public void Equal(Person person, int age1, int age2)
        {
            if (person.GetAge() >= age1 && person.GetAge() <= age2)
                Console.WriteLine("{0} попадает в возрастной диапазон от {1} до {2}", person.GetFullName(), age1, age2);
            else
                Console.WriteLine("{0} не попадает в возрастной диапазон от {1} до {2}", person.GetFullName(), age1, age2);
        }
        public void Visit()
        {
            try
            {
                StreamWriter sw = new StreamWriter("attendance.txt", true);
                sw.WriteLine(this.GetFullName());
                sw.WriteLine("Пришел на работу {0} в {1}\n", DateTime.Now.ToLongDateString(), DateTime.Now.ToShortTimeString());
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Leave()
        {
            try
            {
                StreamWriter sw = new StreamWriter("attendance.txt", true);
                sw.WriteLine(this.GetFullName());
                sw.WriteLine("Ушел с работы {0} в {1}\n", DateTime.Now.ToLongDateString(), DateTime.Now.ToShortTimeString());
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
        
