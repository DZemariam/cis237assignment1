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
        private string id;
        private string description;
        private string pack;


        //Properties
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Pack
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
            return id + " " + description + " " + pack;
        }

        //Constructors
        public WineItem(string id, string description, string pack)
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
