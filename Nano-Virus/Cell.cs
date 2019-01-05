using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nano_Virus
{
    public class Cell
    {
        private string id;
        private string type;
        private Location location;

        public Cell()
        {

        }

        public Cell(string idParam, string nameParam, Location locationParam)
        {

        }

        public Location Location
        {
            get { return location; }
            set { location = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
