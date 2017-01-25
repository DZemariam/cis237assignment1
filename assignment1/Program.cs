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

    class Program
    {
        static void Main(string[] args)
        {
            //Make a new instance of the User Interface class
            UserInterface ui = new UserInterface();

            //Here is a new employee being created using the default
            //constructor that we wrote in the WineItem class
            WineItem myWineItem = new WineItem();

            

            //Instanciate the csvProcessor
            CSVProcessor csvProcessor = new CSVProcessor();

            //Call the ImportCSV method sending path and array to store the records.
            csvProcessor.ImportCsv(pathToCsv, wineitems);

            //Get some input from user
            int choice = ui.GetUserInput();

            int option;

            while (choice !=5)
            {
                //Make a decision
                switch (option)
                {
                    case 1;
                     //Make string for path
            string pathToCsv = "../WineList.csv";
                        break;
                    case 2;
                        if (choice == 2)
                        //String to be concatedto
                        string outputString = "";

                    //Printout WineItem list
                    foreach (WineItem wineitems in wineitems)
                        if (wineitems != null)
                        {
                            //concat to outputString
                            outputString += wineitems.ToString() +
                                Environment.NewLine;
                        }
                        break;

                    case 3;
                        //Link to WineItemCollection Class
                        break;

                    case 4;
                        //link to WineItemCollection Class
                        break;

                     case 5;


                }

                //Use the UI class to print out the string
                ui.Output(outputString);
            }
        }
    }
}
