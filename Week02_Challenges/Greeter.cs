using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week02_Challenges
{
    public class Greeter
    {
        public void HelloThere(string[] args)
        {
            Console.WriteLine("What's your name?");
             
            string name = Console.ReadLine();

            Console.WriteLine("Hello there, " + name);

            Console.ReadLine();
        }


    }
}
