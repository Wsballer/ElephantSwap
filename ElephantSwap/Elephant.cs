using System;
using System.Collections.Generic;
using System.Text;

namespace ElephantSwap
{
    class Elephant
    {
        public int EarSize;
        public string Name;

        public void WhoAmI()
        {
            Console.WriteLine("My name is {0}.", Name);
            Console.WriteLine("My ears are {0} inches tall.", EarSize);
        }
    }
}
