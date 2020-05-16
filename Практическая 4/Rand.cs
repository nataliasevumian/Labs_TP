using System;
using System.Collections.Generic;
using System.Text;

namespace Практическая_4
{
    class Rand
    {
        public int random()
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 10);
            int i = value % 2;
            return i;
        }
    }
}
