using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nano_Virus
{
    public class Session
    {
        private int rbcLeft;
        private int wbcLeft;
        private int nvPresent;
        private int lifeCycle;
        private int tcPresent;
        private List<Tumourus> tumourusCells;
        private List<Cell> redBloodCells;
        private List<Cell> whiteBloodCells;
        private List<NanoVirus> nanoVirusCells;

        public Session()
        {

        }

        public Session(int rbcLeftParam, int wbcLeftParam, int nvPresentParam, int lifeCycleParam, int tcPresentParam, List<Tumourus> tumourusCellsParam,
            List<Cell> redBloodCellsParam, List<Cell> whiteBloodCellsParam, List<NanoVirus> nanoVirusCellsParam)
        {
            this.RBCLeft = rbcLeftParam;
            this.WBCLeft = wbcLeftParam;
            this.NVPresent = nvPresentParam;
            this.LifeCycle = lifeCycleParam;
            this.TCPresent = tcPresentParam;
            this.TumourusCells = tumourusCellsParam;
            this.RedBloodCells = redBloodCellsParam;
            this.WhiteBloodCells = whiteBloodCellsParam;
            this.NanoVirusCells = nanoVirusCellsParam;
        }
        public int RBCLeft
        {
            get { return rbcLeft; }
            set { rbcLeft = value; }
        }
        public int WBCLeft
        {
            get { return wbcLeft; }
            set { wbcLeft = value; }
        }

        public int NVPresent
        {
            get { return nvPresent; }
            set { nvPresent = value; }
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

        public List<Tumourus> TumourusCells
        {
            get { return tumourusCells; }
            set { tumourusCells = value; }
        }

        public List<Cell> RedBloodCells
        {
            get { return redBloodCells; }
            set { redBloodCells = value; }
        }

        public List<Cell> WhiteBloodCells
        {
            get { return whiteBloodCells; }
            set { whiteBloodCells = value; }
        }

        public List<NanoVirus> NanoVirusCells
        {
            get { return nanoVirusCells; }
            set { nanoVirusCells = value; }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
