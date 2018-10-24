using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nano_Virus.src.Backend.Operations
{
    public interface ICalculations
    {
        // calculates the distance between tumourus cell and blood cell 
        void CalculateBCDistance();

        // calcualtes distance between nano-virus cell and tumours cell
        void CalculateTCNearestTC();

        // find closest distance between blood cell and tumourus cell
        void FindNearestBC();

        //find the closes distance between tumourus cell and nano-virus cell
        void FindNearestTC();

        // calculate the total number of tumourus cell that are left
        void CalculateTotalTC();

        // calculate the total number of nano-virus cell that are present 
        void CalculateTotalNC();

        // calculate the total number of red blood cells left
        void CalculateTotalRBC();

        // calculate the total number of white blood cells left
        void CalculateTotalWBC();

        // calculate how many life-cycles it would take for all the red blood cells and white bool cells
        // to be killed by the tumourus cells
        void CalculateTCKillTime();
    }
}
