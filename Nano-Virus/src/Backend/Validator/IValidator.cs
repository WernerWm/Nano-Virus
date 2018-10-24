using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nano_Virus.src.Backend.Validator
{
    public interface IValidator
    {
        // Runs a bunch of validation methods to check whether the rules 
        // are being met
        void CheckRuleCompliance();

        // Check whether the simultion can move on to a new life-cycle or stop
        // and provide final results
        void CheckGameState();

        // validates whether the move of a tumourus or nao-virus cell conforms
        // to the rules within the rule engin
        bool ValidateMove();

        // validate that the correct number of cells are generated
        bool ValidateNumberOfCells();

        // validates that the tumourus cell first kills all the red blood cells
        // before it starts killing all the white blood cells
        bool ValidateKillingProcess();

        bool ValidateInitNVCReplicaPosition();
    }
}
