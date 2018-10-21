using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nano_Virus.src.Backend.Entities
{
    public class Blood_Cell : Cell
    {
        private bool hasNucleus;
        private bool hasHemoglobin;
        private bool isCarryingOxygen;
        private bool isInfected;

        public Blood_Cell(string xCoordinateParam, string yCoordinateParam, string zCoordinateParam, bool hasNucleusParam, bool hasHemoglobinParam, bool isCarryingOxygenParam, bool isInfectedParam) 
            : base(xCoordinateParam, yCoordinateParam, zCoordinateParam)
        {
            this.HasNucleus = hasNucleusParam;
            this.HasHemoglobin = hasNucleusParam;
            this.IsCarryingOxygen = isInfectedParam;
            this.IsInfected = isInfectedParam;
        }
        public Blood_Cell()
        {

        }

        public bool HasNucleus
        {
            get { return hasNucleus; }
            set { hasNucleus = value; }
        }
        public bool HasHemoglobin
        {
            get { return hasHemoglobin; }
            set { hasHemoglobin = value; }
        }
        public bool IsCarryingOxygen
        {
            get { return isCarryingOxygen; }
            set { isCarryingOxygen = value; }
        }

        public bool IsInfected
        {
            get { return isInfected; }
            set { isInfected = value; }
        }

    }
}
