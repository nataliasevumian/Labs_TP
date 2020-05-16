using System;
using System.Collections.Generic;
using System.Text;

namespace Практическая_4
{
    class Game
    {
        public Gamer gamer { get; set; }
        public int Bet { get; set; }
        public Game(Gamer gamer)
        {
            this.gamer = gamer;
        }
        
        public void PlayGame()
        {
            Console.WriteLine("Добро пожаловать в игру \"Чет-нечет\"");
            Console.WriteLine("Введите свое имя: ");
            gamer.Name = Console.ReadLine();
            Console.WriteLine("Введите стартовый баланс: ");
            gamer.Money = Int32.Parse(Console.ReadLine());
            while (gamer.Money <= 0)
            {
                Console.WriteLine("Введеное значение недопустимо! Попробуйте еще раз.");
                gamer.Money = Int32.Parse(Console.ReadLine());
            }
            while (gamer.Money > 0)
            {
                Bet = gamer.Makebet(gamer.Money);
                int choice = gamer.Choice();
                bool comp = gamer.Compare(choice);
                if (comp == true)
                {
                    gamer.Money += Bet;
                    Console.WriteLine("Ваша ставка сыграла!\nВаш баланс: {0}", gamer.Money);
                }
                else
                {
                    gamer.Money -= Bet;
                    Console.WriteLine("Ваша ставка не сыграла.\nВаш баланс: {0}", gamer.Money);
                }
                    
                Console.WriteLine("Хотите продолжить игру? Да или нет");
                string n = Console.ReadLine();
                if (n == "Да" || n == "да")
                    continue;
                else
                    break;
            }
            Console.WriteLine("Игра окончена. Ваш итоговый баланс: {0}", gamer.Money);

        }
    }
}
