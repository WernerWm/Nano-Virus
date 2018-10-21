using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nano_Virus.src.Backend.Entities
{
    public class Tumorous : Cell
    {
        private int total;
        private string color;

        public Tumorous()
        {
        }

        public Tumorous(string xCoordinateParam, string yCoordinateParam, string zCoordinateParam, int totalParam, string colorParam) : base(xCoordinateParam, yCoordinateParam, zCoordinateParam)
        {
            this.Total = totalParam;
            this.Color = colorParam;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Total
        {
            get { return total; }
            set { total = value; }
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
