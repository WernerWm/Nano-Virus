using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nano_Virus.src.Backend.Entities
{
    public class Blood_Cell : Cell
    {
        private string color;
        private string type;

        public Blood_Cell()
        {
        }

        public Blood_Cell(string xCoordinateParam, string yCoordinateParam, string zCoordinateParam, string colorParam, string typeParam) : base(xCoordinateParam, yCoordinateParam, zCoordinateParam)
        {
            this.Color = colorParam;
            this.Type = typeParam;
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
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
