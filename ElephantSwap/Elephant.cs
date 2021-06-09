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

        public void HearMessage(string message, Elephant whoSaidIt)
        {
            Console.WriteLine(Name + " heard a message");
            Console.WriteLine(whoSaidIt.Name + " said this: " + message);
        }

        public void SpeakTo(Elephant whoToTalkTo, string message)
        {
            whoToTalkTo.HearMessage(message, this);
        }
    }
}
