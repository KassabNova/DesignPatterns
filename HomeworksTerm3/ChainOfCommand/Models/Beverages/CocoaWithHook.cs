using System;
using System.IO;
namespace ChainOfCommandBeverages
{
    public class CocoaWithHook : BeverageWithHook
    {

        public override void brew()
        {
            Console.WriteLine("Adding crushed cocoa to brew");
        }

        public override void addCondiments()
        {
            Console.WriteLine("Adding marshmellows");
        }

        // here's where you override the hook and provide your own functionality
        public new bool customerWantsCondiments()
        {
            // get the user's input on the condiment decision and return true or false depending on the input
            string answer = getUserInput();

            if (answer.ToLower().StartsWith("y"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string getUserInput()
        {
            string answer = null;

            Console.WriteLine("Would you like marshmellows with your cocoa (y/n)?");

            try
            {
                answer = Console.ReadLine();
            }
            catch (IOException ioe)
            {
                Console.WriteLine("IO error trying to read your answer: ", ioe);
            }

            if (answer == null)
            {
                return "no";
            }
            return answer;
        }

    }
}