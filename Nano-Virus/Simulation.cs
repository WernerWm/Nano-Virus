using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nano_Virus
{
    public class Simulation
    {
        private Tree tree;
        private Node rootNode;
        private FileHandler fileHandler;
        private Random rand;
        private NanoVirus nanoVirus;
        private Session session;
        private List<Tumourus> tumourusCells;
        private List<Cell> redBloodCells;
        private List<Cell> whiteBloodCells;
        private List<NanoVirus> nanoVirusCells;
        private bool isDone;

        public Simulation(Tree treeParam, FileHandler fileHandlerParam, NanoVirus nanoVirusParam)
        {
            this.tree = treeParam;
            this.fileHandler = fileHandlerParam;
            this.rand = new Random();
            this.nanoVirus = nanoVirusParam;
            this.tumourusCells = new List<Tumourus>();
            this.redBloodCells = new List<Cell>();
            this.whiteBloodCells = new List<Cell>();
            this.nanoVirusCells = new List<NanoVirus>();
        }

        public void Start()
        {
            GenerateCells();
            BuildBranches();
        }

        public void NVCChoice(Session session)
        {
            int choice = rand.Next(1, 3);
            if (choice == 1)
            {
                session = nanoVirus.Move(session, nanoVirus);
            }
            else if (choice == 2)
            {
                session = nanoVirus.KillCell(session, nanoVirus);
            }
            else
            {
                session = nanoVirus.Duplicate(session, nanoVirus);
            }
        }

        public void TCTurn(Session session)
        {
            List<Tumourus> holder = new List<Tumourus>();

            foreach (Tumourus item in tumourusCells)
            {
                session = item.KillCell(session, item);
                //holder.Add(tumourus);
            }

            //tumourusCells.AddRange(holder);
        }

        public bool CheckValidLocation(Location location, List<Location> locationsTaken)
        {
            bool isValid = true;
            foreach (Location item in locationsTaken)
            {
                if (location.XCoordinate == "" && location.YCoordinate == "" && location.ZCoordinate == "")
                {
                    isValid = false;
                }
                else
                {
                    isValid = true;
                }
            }
            return isValid;
        }

        public void GenerateCells()
        {
            bool isValid = false;
            int probablity = 0, totalRBC = 0, totalWBC = 0, totalTC = 0, totalNV = 1, lifeCycles = 0;
            List<Location> locationsTaken = new List<Location>();
            Location location;
            string xCoordinate, yCoordinate, zCoordinate;

            for (int i = 0; i < 100; i++)
            {
                probablity = rand.Next(1, 100);
                xCoordinate = rand.Next(1, 5000).ToString();
                yCoordinate = rand.Next(1, 5000).ToString();
                zCoordinate = rand.Next(1, 5000).ToString();
                location = new Location(xCoordinate, yCoordinate, zCoordinate);
                isValid = CheckValidLocation(location, locationsTaken);
                if (isValid)
                {
                    locationsTaken.Add(location);
                    if (probablity > 0 || probablity <= 5)
                    {
                        totalTC++;
                        Tumourus tumourus = new Tumourus
                        {
                            ID = rand.Next(1, 5000).ToString(),
                            Name = "Tumorous"
                        };
                        tumourus.Location.XCoordinate = location.XCoordinate;
                        tumourus.Location.YCoordinate = location.YCoordinate;
                        tumourus.Location.ZCoordinate = location.ZCoordinate;
                        tumourusCells.Add(tumourus);
                    }
                    else if (Convert.ToInt32(probablity) > 5 || Convert.ToInt32(probablity) <= 25)
                    {
                        totalWBC++;
                        Cell cell = new Cell
                        {
                            ID = rand.Next(1, 5000).ToString(),
                            Type = "White Blood"
                        };
                        cell.Location.XCoordinate = location.XCoordinate;
                        cell.Location.YCoordinate = location.YCoordinate;
                        cell.Location.ZCoordinate = location.ZCoordinate;
                        whiteBloodCells.Add(cell);
                    }
                    else
                    {
                        totalRBC++;
                        Cell cell = new Cell
                        {
                            ID = rand.Next(1, 5000).ToString(),
                            Type = "Red Blood"
                        };
                        cell.Location.XCoordinate = location.XCoordinate;
                        cell.Location.YCoordinate = location.YCoordinate;
                        cell.Location.ZCoordinate = location.ZCoordinate;
                        redBloodCells.Add(cell);
                    }
                }
            }
            session = new Session(totalRBC, totalWBC, totalNV, totalTC, lifeCycles, tumourusCells, redBloodCells, whiteBloodCells, nanoVirusCells);
            rootNode = new Node(totalRBC, totalWBC, totalNV, totalTC, lifeCycles);
        }

        public bool BuildBranches()
        {
            isDone = false;
            Node node = new Node();
            NVCChoice(session);
            node.LifeCycle = session.LifeCycle;
            node.NVPresent = session.NVPresent;
            node.TCPresent = session.TCPresent;
            node.RBCLeft = session.RBCLeft;
            node.WBCLeft = session.WBCLeft;
            if (node.TCPresent == 0 || node.WBCLeft == 0)
            {
                node.Ancestors.Add(node);
                tree.AddBranch();
            }
            else
            {
                node.Ancestors.Add(node);
                BuildBranches();
            }
            return isDone;
        }

        public void Restart()
        {
            GenerateCells();
        }

        public void DepthFirstSearch()
        {

        }

        public void WriteBestMovesDown()
        {
            fileHandler.FileWriter(session);
        }
    }
}
