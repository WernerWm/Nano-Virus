using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nano_Virus
{
    public class NanoVirus
    {
        private bool isActive;
        private string actionPerformed;
        string id;
        string name;
        Location location;

        public NanoVirus()
        {

        }

        public NanoVirus(string idParam, string nameParam, Location locationParam)
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

        public string ActionPerformed
        {
            get { return actionPerformed; }
            set { actionPerformed = value; }
        }

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        public Session Duplicate(Session session, NanoVirus nanoVirus)
        {
            Random random = new Random();
            if (isActive)
            {
                session.NanoVirusCells.Add(new NanoVirus(random.Next(1, 5000).ToString(), "", nanoVirus.Location));
                return session;
            }
            else
            {
                return session;
            }
        }

        public Session Move(Session session, NanoVirus nanoVirus)
        {
            Dictionary<string, string> distances = new Dictionary<string, string>();
            if (isActive)
            {
                distances = CalculateDistance(session, nanoVirus);
                var firstElement = distances.FirstOrDefault();
                if (int.Parse(firstElement.Value) <= int.Parse("2000"))
                {

                }
                else
                {

                }
                return session;
            }
            else
            {
                return session;
            }
        }

        public Dictionary<string, string> CalculateDistance(Session session, NanoVirus nanoVirus)
        {
            double xDiff = 0, yDiff = 0, zDiff = 0;
            Dictionary<string, string> distances = new Dictionary<string, string>();
            if (session.TumourusCells.Any())
            {
                foreach (Tumourus item in session.TumourusCells) // calculates the distance between the tumourus cell and the red blood cell
                {
                    xDiff = Math.Pow(int.Parse(item.Location.XCoordinate) - int.Parse(nanoVirus.Location.XCoordinate), 2);
                    yDiff = Math.Pow(int.Parse(item.Location.YCoordinate) - int.Parse(nanoVirus.Location.YCoordinate), 2);
                    zDiff = Math.Pow(int.Parse(item.Location.ZCoordinate) - int.Parse(nanoVirus.Location.ZCoordinate), 2);
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

        public Session KillCell(Session session, NanoVirus nanoVirus)
        {
            Dictionary<string, string> distances = new Dictionary<string, string>();
            distances = CalculateDistance(session, nanoVirus);
            try
            {
                var firstElement = distances.FirstOrDefault();
                foreach (Tumourus item in session.TumourusCells)
                {
                    if (firstElement.Key == item.ID)
                    {
                        session.TumourusCells.Remove(item);
                    }
                }
                return session;
            }
            catch (Exception e)
            {
                return session;
            }
        }
    }
}
