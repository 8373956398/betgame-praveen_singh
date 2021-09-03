using System;

namespace betgame
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            double odds = 0.75;
            Console.WriteLine("Welcome to the casino.the odds are: "+ odds);
            guy player = new guy() { cash = 100, name = "The player" };
            player.writeMyInfo();
            while (player.cash>0)
            {
                Console.Write("How much do you want to bet or press \"Enter\" to exit the casino:");
                string howmuch = Console.ReadLine();
                if (howmuch == "")
                {
                    Console.WriteLine("Thanks for Coming, Good Bie!");
                    return;
                }
                if (int.TryParse(howmuch, out int amount))
                {
                    double number = random.NextDouble();
                    if (number > odds)
                    {
                        amount *= 2;
                        player.ReceiveCash(amount);
                        Console.WriteLine("You Win: " + amount);
                        player.writeMyInfo();
                    }
                    else
                    {
                        Console.WriteLine("Bad luck, You Loss!");
                        player.GiveCash(amount);
                        player.writeMyInfo();
                    }
                }
                else
                {
                    Console.WriteLine("invalid input please enter a integer");
                }
            }
            Console.WriteLine("You have no cash to play, Good bie!");
        }
    }
}
