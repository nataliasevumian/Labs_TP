using System;
using System.Collections.Generic;
using System.Text;

namespace Практическая_4
{
    class Gamer
    {
        public int Money { get; set; }
        public string Name { get; set; }
        public Gamer(string name, int money)
        {
            this.Name = name;
            this.Money = money;
        }
        public int Choice()
        {
            Console.WriteLine("{0}, сделайте выбор: четное(0) или нечетное(1)", Name);
            int i = Int32.Parse(Console.ReadLine());
            while (i != 0 && i != 1)
            {
                Console.WriteLine("Можно выбрать только 0 или 1. Попробуйте еще раз.");
                i = Int32.Parse(Console.ReadLine());
            }
            return i;
        }
        public bool Compare(int i)
        {
            Rand rand = new Rand();
            int rnd = rand.random();
            rnd %= 2;
            if (i == rnd)
                return true;
            else
                return false;
        }
        public int Makebet(int balance)
        { 
            Console.WriteLine("Сделайте вашу ставку: ");
            int bet = Int32.Parse(Console.ReadLine());
            while (bet >= balance)
            {
                Console.WriteLine("Ставка некорректна. Сделайте вашу ставку еще раз: ");
                bet = Int32.Parse(Console.ReadLine());
            }
            return bet;
        }
    }
}
