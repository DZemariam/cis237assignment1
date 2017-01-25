using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {
        //Methods   
        public int GetUserInput()
        {
            this.PrintList();

            //Get input from user
            String input = Console.ReadLine();

            //While the input is not valid re-get the input
            while (input != "1" && input != "2" && input != "3" && input != "4" && input != "5")
            {
                //Load WIC
                this.loadcsv();

                //Print Message
                this.PrintErrorMessage();

                //Reprint WineList
                this.PrintMenu();

                //Get the input from the console again. 
                input = Console.ReadLine();
            }

            //input is 1-5

            return Int32.Parse(input);
        }

        public void Output(string outputString);
        {
            Console.WritelLine(outputString);

        }

    private void PrintErrorMessage()
    {
        Console.WriteLine("That is not valid")
        Console.WriteLine("Please make a valid choice")
        Console.WriteLine();

      }
    }
}
