using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nano_Virus.src.Backend.Operations
{
    public interface IComparer
    {
        // checks whether the current state of the application has changes against the previous state
        void CompareStates();

        // compare the optimal soltion of each branch(path) taken
        void CompareOptimalSolutions();
    }
}
