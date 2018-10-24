using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nano_Virus.src.Backend.Operations
{
    public interface IMover
    {
        // move a nano-virus cell close to a tumours cell
        void MoveNVCCell();

        // move a nano-virus cell to kill the neatest tumorous cell
        void KillTC();

        // replicate a nano-virus cell
        void ReplicateNC();
    }
}
