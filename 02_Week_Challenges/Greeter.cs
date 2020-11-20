using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Week_Challenges
{
    class Greeter
    {
        public void HelloThere(string name)
        {
            Console.WriteLine("Hello there, " + name + ".");
        }

        public void ByeBye(string name)
        {
            Console.WriteLine("Adios " + name + ".");
        }

        public void TimeBased(string name)
        {
            if(DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 12)
            {
                Console.WriteLine("Good Morning " + name + ".");
            }
            
            else if(DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 18)
            {
                Console.WriteLine("Good Afternoon " + name + ".");
            }

            else if (DateTime.Now.Hour >= 18 && DateTime.Now.Hour < 24)
            {
                Console.WriteLine("Good Evening " + name + ".");
            }

            else 
            {
                Console.WriteLine("Good Night " + name + ".");
            }
        }
    }
}
