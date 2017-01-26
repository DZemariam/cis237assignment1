using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    /* Name: Dawit Zemariam
  Class: cis237
  Date: 1/25/2017
  */

    class CSVProcessor
    {
        public bool ImportCsv(string pathtoCSVfile, WineItemCollection WIC)
            {
                //Declare the streamReader
                StreamReader streamReader = null;


            try
            {
                //Declare a string for the line
                string line;

                //Intanciate the stream reader
                streamReader = new StreamReader(pathtoCSVfile);

                int counter = 0;


                //While we are still reading a line from the file 
                while ((line = streamReader.ReadLine()) !=null)
                {
                    //Process the line
                    processLine(line, WIC, counter++);
                }

                //Read through the whole file, so we can terurn true.
                return true;
            }
            catch (Exception e)
            {
                //Output the exception and the stacktrace for the exception
                Console.WriteLine(e.ToString());
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);

                //return false because it didn't work
                return false;
            }
            finally
            {
                //close Streamreader
                if (streamReader !=null )
                {
                    streamReader.Close();
                }
            }

       private void processLine(string line, WineItem[] wineitems, int index)
        {
            //declare array of parts that will contain the results of slpitting 
            //the read in string 
            string[] parts = line.Split(',');

            //Assign each part to a variable
            decimal id = decimal.Parse(parts[2]);
            string description = parts[0];
            string pack = parts[1];

            //Add a new employee into the array that was passed in.
            wineitems[index] = new WineItem(id, description, pack)
        }

    }
}
