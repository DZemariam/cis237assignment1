using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a new instance of the User Interface class
            UserInterface ui = new UserInterface();

            //Here is a new employee being created using the default
            //constructor that we wrote in the WineItem class
            WineItem myWineItem = new WineItem();

            //Let's make an array to hold a bunch of instances of the Employee class
            WineItem[] wineitem = new WineItem[4000];
        }
    }
}
