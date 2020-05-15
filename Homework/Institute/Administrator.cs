using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Administrator: Person, IEmployee
    {
        public string Laboratory { get; protected set; }
        public DateTime StartOfWork { get; private set; }
        public double Salary { get; private set; }
        public Administrator(string Laboratory, double Salary, DateTime StartOfWork, string Surname,
            string Name, string Patronymic, DateTime birth)
            : base(Surname, Name, Patronymic, birth)
        {
            this.Laboratory = Laboratory;
            this.Salary = Salary;
            this.StartOfWork = StartOfWork;
        }
        public int Experience()
        {
            int e = DateTime.Now.Year - StartOfWork.Year;
            if (DateTime.Now.Month - StartOfWork.Month < 0)
                e -= 1;
            return e;
        }
        public double GetSalary()
        {
            double premium = 0;
            if (this.Experience() > 1 && this.Experience() < 5)
                premium = 0.1 * Salary;
            else if (this.Experience() > 5 && this.Experience() < 10)
                premium = 0.15 * Salary;
            else if (this.Experience() > 10 && this.Experience() < 15)
                premium = 0.2 * Salary;
            else if (this.Experience() > 15)
                premium = 0.3 * Salary;
            return (Salary + premium);
        }
        public bool Place { get; set; }
        public void AtWork()
        {
            Place = true;
            this.Visit();
        }
        public void NotAtWork()
        {
            Place = false;
            this.Leave();
        }
        public override string ToString()
        {
            string bs = String.Format("Лаборатория: {0}\nСтаж работы: {1}\n" +
                "Заработная плата: {2} тыс.руб.", Laboratory, this.Experience(), this.GetSalary());
            return bs;
        }

        public override void Print()
        {
            Console.WriteLine("-----Администратор-----");
            Console.WriteLine(this);
            base.Print();
        }
    }
}
