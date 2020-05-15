using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public interface IEmployee
    {
        string GetFullName();
        int Experience();
        double GetSalary();
        bool Place { get; set; }
        void AtWork();
        void NotAtWork();
    }
}
