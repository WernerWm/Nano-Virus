using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nano_Virus.src.Backend.Entities
{
    public class Board
    {
        private int[,,] dimension;

        public Board(int[,,] dimensionParam)
        {
            this.Dimension = dimensionParam;
        }

        public Board()
        {

        }
        public int[,,] Dimension
        {
            get { return dimension; }
            set { dimension = value; }
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
