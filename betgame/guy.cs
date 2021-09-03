using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace betgame
{
    class guy
    {
        public string name;
        public int cash;
       // methods will start from here       
        public void writeMyInfo()
        {
            Console.WriteLine(name + " has " + cash + " rupees");
        }
        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(name + " says the money is not valid");
            }
            if (amount > cash)
            {
                Console.WriteLine(name + "says i don't have enough money");
            }
            cash -= amount;
            return amount;
        }

        public void ReceiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("the amount is invalid");
            }
            else
            {
                cash += amount;
            }
        }
    }
}
