using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{

    /* Name: Dawit Zemariam
  Class: cis237
  Date: 1/25/2017
  */

    class UserInterface
    {
        //Methods   
        public int GetUserInput()
        {
    

            //Get input from user
            String input = Console.ReadLine();

            //While the input is not valid re-get the input
            while (input != "1" && input != "2" && input != "3" && input != "4" && input != "5")
            {

                //Print Message
                this.PrintErrorMessage();

                //Reprint WineList
                this.PrintMenu();

                //Get the input from the console again. 
                input = Console.ReadLine();
            }

            return Int32.Parse(input);
        }

        //print wines
        public void Output(string outputString)
        {
            Console.WriteLine(outputString);

        }

        //Ask for direction
        private void PrintMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1.Load data list");
            Console.WriteLine("2.Pint List");
            Console.WriteLine("3.Add to WineItemCollection");
            Console.WriteLine("4.Seach WineItemCollection");
            Console.WriteLine("5.Exit");
        }


        private void PrintErrorMessage()
        {
            Console.WriteLine("That is not valid");
            Console.WriteLine("Please make a valid choice");
            Console.WriteLine();

        }
    }
}
