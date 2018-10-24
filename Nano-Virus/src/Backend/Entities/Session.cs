using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nano_Virus.src.Backend.Entities
{
    public class Session
    {
        private int lifeCycle;
        private string state;
        private int totalWhiteCells;
        private int totalRedCells;
        private int totalTumorousCells;

        public Session(int lifeCycleParam, string stateParam, int totalWhiteCellsParam, int totalRedCellsParam, int totalTumorousCellsParam)
        {
            this.LifeCycle = lifeCycleParam;
            this.State = stateParam;
            this.TotalWhiteCells = totalWhiteCellsParam;
            this.TotalRedCells = totalRedCellsParam;
            this.TotalTumorousCells = totalTumorousCellsParam;
        }

        public Session()
        {

        }

        public int TotalTumorousCells
        {
            get { return totalTumorousCells; }
            set { totalTumorousCells = value; }
        }

        public int TotalRedCells
        {
            get { return totalRedCells; }
            set { totalRedCells = value; }
        }


        public int TotalWhiteCells
        {
            get { return totalWhiteCells; }
            set { totalWhiteCells = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public int LifeCycle
        {
            get { return lifeCycle; }
            set { lifeCycle = value; }
        }

    }
}
