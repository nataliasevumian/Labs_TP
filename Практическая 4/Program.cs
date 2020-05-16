using System;

namespace Практическая_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = null;
            int money = 0;
            Gamer gamer = new Gamer(name, money);
            Game game = new Game(gamer);
            game.PlayGame();
        }
    }
}
