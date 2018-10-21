using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nano_Virus.src.Backend.Entities
{
    public class White_Blood : Blood_Cell
    {
        private string color;
        private int total;

        public White_Blood()
        {
        }

        public White_Blood(string xCoordinateParam, string yCoordinateParam, string zCoordinateParam, bool hasNucleusParam, bool hasHemoglobinParam, bool isCarryingOxygenParam, bool isInfectedParam, string colorParam, int totalParam)
            : base(xCoordinateParam, yCoordinateParam, zCoordinateParam, hasNucleusParam, hasHemoglobinParam, isCarryingOxygenParam, isInfectedParam)
        {
            this.Color = colorParam;
            this.Total = total;
        }

        public int Total
        {
            get { return total; }
            set { total = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
