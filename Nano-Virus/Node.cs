using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nano_Virus
{
    public class Node
    {
        private List<Node> ancestors;
        private int rBCLeft;
        private int wBCLeft;
        private int nVPresent;
        private int tcPresent;
        private int lifeCycle;

        public Node()
        {

        }

        public Node(int rBCLeftParam, int wBCLeftParam, int nVPresentParam, int tcPresentParam, int lifeCycleParam)
        {
            this.rBCLeft = rBCLeftParam;
            this.wBCLeft = wBCLeftParam;
            this.nVPresent = nVPresentParam;
            this.tcPresent = tcPresentParam;
            this.lifeCycle = lifeCycleParam;
        }

        public int LifeCycle
        {
            get { return lifeCycle; }
            set { lifeCycle = value; }
        }

        public int TCPresent
        {
            get { return tcPresent; }
            set { tcPresent = value; }
        }


        public int NVPresent
        {
            get { return nVPresent; }
            set { nVPresent = value; }
        }


        public int WBCLeft
        {
            get { return wBCLeft; }
            set { wBCLeft = value; }
        }


        public int RBCLeft
        {
            get { return rBCLeft; }
            set { rBCLeft = value; }
        }


        public List<Node> Ancestors
        {
            get { return ancestors; }
            set { ancestors = value; }
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
