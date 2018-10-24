using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nano_Virus.src.Backend.Entities
{
    public class Nano_Virus : Cell
    {
        private bool isReplicated;
        private string color;

        public Nano_Virus()
        {

        }

        public Nano_Virus(string xCoordinateParam, string yCoordinateParam, string zCoordinateParam, bool isReplicatedParam, string colorParam)
            : base(xCoordinateParam, yCoordinateParam, zCoordinateParam)
        {
            this.isReplicated = isReplicatedParam;
            this.Color = colorParam;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public bool IsReplicated
        {
            get { return isReplicated; }
            set { isReplicated = value; }
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
