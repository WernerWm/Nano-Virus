using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nano_Virus.src.Backend.Validator
{
    public class Validator : IValidator
    {
        public void CheckGameState()
        {
            throw new NotImplementedException();
        }

        public void CheckRuleCompliance()
        {
            throw new NotImplementedException();
        }

        public bool ValidateInitNVCReplicaPosition()
        {
            throw new NotImplementedException();
        }

        public bool ValidateKillingProcess()
        {
            throw new NotImplementedException();
        }

        public void ValidateMove()
        {
            throw new NotImplementedException();
        }

        public bool ValidateNumberOfCells()
        {
            throw new NotImplementedException();
        }

        bool IValidator.ValidateMove()
        {
            throw new NotImplementedException();
        }
    }
}
