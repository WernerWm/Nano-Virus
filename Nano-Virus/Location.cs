using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nano_Virus
{
    public class Location
    {
        private string xCoordinate;
        private string yCoordinate;
        private string zCoordinate;

        public Location()
        {

        }

        public Location(string xCoordinateParam, string yCoordinateParam, string zCoordinateParam)
        {
            this.XCoordinate = xCoordinateParam;
            this.YCoordinate = yCoordinateParam;
            this.ZCoordinate = zCoordinateParam;
        }

        public string XCoordinate
        {
            get { return xCoordinate; }
            set { xCoordinate = value; }
        }

        public string YCoordinate
        {
            get { return yCoordinate; }
            set { yCoordinate = value; }
        }

        public string ZCoordinate
        {
            get { return zCoordinate; }
            set { zCoordinate = value; }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
