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

    class WineItem
    {
        //Variable
        private decimal id;
        private string description;
        private string pack;


        //Properties
        public decimal id
        {
            get { return id; }
            set { id = value; }
        }

        public string description
        {
            get { return description; }
            set { description = value; }
        }

        public string pack
        {
            get { return pack; }
            set { pack = value; }
        }


        //Public Methods
        public string WineInfo()
        {
            return id + " " + description;
        }

        public override string ToString()
        {
            return id + " " + description + " " + pack.ToString("C");
        }

        //Constructors
        public WineItem(decimal id, string description, string pack)
        {
            this.id = Id;
            this.description = Description;
            this.pack = Pack;
        }

        public WineItem()
        {
            //Do Nothing
        }


    }
}
