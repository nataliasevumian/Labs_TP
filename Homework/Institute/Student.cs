using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Student: Person
    {
        public string Faculty { get; protected set; }
        public string Group { get; protected set; }
        public Student(string Faculty, string Group, string Surname, 
            string Name, string Patronymic, DateTime birth)
            : base(Surname,Name,Patronymic,birth)
        {
            this.Faculty = Faculty;
            this.Group = Group;
        }
        public override string ToString()
        {
            string bs = String.Format("Факультет: {0}\nГруппа: {1}", Faculty, Group);
            return bs;
        }

        public override void Print()
        {
            Console.WriteLine("-----Студент-----");
            Console.WriteLine(this);
            base.Print();
        }
    }
}
