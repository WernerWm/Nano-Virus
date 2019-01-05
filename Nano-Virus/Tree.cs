using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nano_Virus
{
    public class Tree
    {
        private List<Node> branches;

        public List<Node> Branches
        {
            get { return branches; }
            set { branches = value; }
        }

        public Node DepthFirstSeach()
        {
            Node bestPath = new Node();

            return bestPath;
        }

        public void AddBranch()
        {

        }

        public void FindBestMove()
        {

        }

        public void RemoveBranch()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
