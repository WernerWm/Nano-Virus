using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nano_Virus
{
    public class Tumourus
    {
        string id;
        string name;
        Location location;

        public Tumourus()
        {

        }

        public Tumourus(string idParam, string nameParam, Location locationParam)
        {
            this.id = idParam;
            this.name = nameParam;
            this.location = locationParam;
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Location Location
        {
            get { return location; }
            set { location = value; }
        }

        public Dictionary<string, string> CalculateDistance(Session session, Tumourus specificCell)
        {
            double xDiff = 0, yDiff = 0, zDiff = 0;
            Dictionary<string, string> distances = new Dictionary<string, string>();
            if (session.RedBloodCells.Any())
            {
                foreach (Cell item in session.RedBloodCells) // calculates the distance between the tumourus cell and the red blood cell
                {
                    xDiff = Math.Pow(int.Parse(item.Location.XCoordinate) - int.Parse(specificCell.Location.XCoordinate), 2);
                    yDiff = Math.Pow(int.Parse(item.Location.YCoordinate) - int.Parse(specificCell.Location.YCoordinate), 2);
                    zDiff = Math.Pow(int.Parse(item.Location.ZCoordinate) - int.Parse(specificCell.Location.ZCoordinate), 2);
                    distances.Add(item.ID, xDiff.ToString() + " " + yDiff.ToString() + " " + zDiff.ToString());
                }
                distances = distances.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value); // sort the dictonary to put the shortest distance first
                return distances;
            }
            else if (session.WhiteBloodCells.Any())
            {
                foreach (Cell item in session.WhiteBloodCells)
                {
                    xDiff = Math.Pow(int.Parse(item.Location.XCoordinate) - int.Parse(specificCell.Location.XCoordinate), 2);
                    yDiff = Math.Pow(int.Parse(item.Location.YCoordinate) - int.Parse(specificCell.Location.YCoordinate), 2);
                    zDiff = Math.Pow(int.Parse(item.Location.ZCoordinate) - int.Parse(specificCell.Location.ZCoordinate), 2);
                    distances.Add(item.ID, xDiff.ToString() + " " + yDiff.ToString() + " " + zDiff.ToString());
                }
                distances = distances.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value); // sort the dictonary to put the shortest distance first
                return distances;
            }
            else
            {
                return null;
            }
        }

        public Session KillCell(Session session, Tumourus tumourus)
        {
            Dictionary<string, string> distances = new Dictionary<string, string>();
            distances = CalculateDistance(session, tumourus);
            try
            {
                var firstElement = distances.FirstOrDefault();
                try
                {
                    if (session.RedBloodCells.Any())
                    {
                        foreach (Cell item in session.RedBloodCells)
                        {
                            if (firstElement.Key == item.ID)
                            {
                                session.RedBloodCells.Remove(item);
                                session.TumourusCells.Add(new Tumourus(item.ID, "Tumourus", item.Location));
                            }
                        }
                    }
                    else
                    {
                        foreach (Cell item in session.WhiteBloodCells)
                        {
                            if (firstElement.Key == item.ID)
                            {
                                session.WhiteBloodCells.Remove(item);
                                session.TumourusCells.Add(new Tumourus(item.ID, "Tumourus", item.Location));
                            }
                        }
                    }

                    return session;
                }
                catch (Exception e)
                {
                    return session;
                }
            }
            catch (Exception e)
            {
                return session;
            }

        }
    }
}
