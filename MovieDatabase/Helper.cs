using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    class Helper
    {
        //Does this need properties, if so, what ones? - No, it'll all be in our methods.
        //Does this need a constructor? - No, it doesn't need any special setup or data.
        //Does this need a method? - Yes, this is the point of the class.

        public string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return input;
        }
        public bool RunAgain()
        {
            Console.WriteLine("Would you like to run the program again? Y/N");
            string answer = Console.ReadLine().ToLower().Trim();
            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                Console.WriteLine("\nGoodbye!");
                return false;
            }
            else
            {
                Console.WriteLine("\nI didn't understand, please input Y or N.");
                return RunAgain();
            }
        }
    }
}
