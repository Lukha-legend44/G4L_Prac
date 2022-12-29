namespace Rover.Models
{
    public class RoverDom
    {

        public int XLoc { get; set; }
        public int YLoc { get; set; }
        public string Direction { get; set; }
        public int PlatX { get; set; }
        public int PlatY { get; set; }

        public RoverDom()
        {
            XLoc = 0;
            YLoc = 0;
            Direction = string.Empty;
            PlatX = 0;
            PlatY = 0;
        }

        // (post) Rover/plateau/  (To set the plateau or get the current plateau)
        // This method returns an empty list in the event that rover lies outside of the plateau.
        public List<int> Plateau(int x, int y)
        {
            List<int> result = new List<int>();
            if (x < XLoc || y < YLoc)
            {
                return result;
            }

            else
            {
                PlatX = x;
                PlatY = y;
                result.Add(PlatX);
                result.Add(PlatY);
                return result;
            }
        }

        public List<int> Plateau()
        {
            List<int> result = new List<int>();
            result.Add(PlatX);
            result.Add(PlatY);
            return result;
        }

        // (get) Rover/location/
        public List<string> GetLocation()
        {
            List<string> result = new List<string>();
            result.Add(XLoc.ToString());
            result.Add(YLoc.ToString());
            result.Add(Direction);
            return result;
        }

        // (put) Rover/
        public List<string> MoveRover(int x, int y)
        {
            if (PlatX > XLoc + x && PlatY > YLoc + y)
            {
                XLoc += x;
                YLoc += y;

                if (y > 0)
                {
                    if (x > 0)
                    {
                        Direction = "North East";
                    }

                    else if (x < 0)
                        Direction = "North West";

                    else
                    {
                        Direction = "North";
                    }
                }

                else if (y == 0)
                {
                    if (x > 0)
                    {
                        Direction = "East";
                    }

                    else if (x < 0)
                    {
                        Direction = "West";
                    }
                }

                else
                {
                    if (x > 0)
                    {
                        Direction = "South East";
                    }

                    else if (x < 0)
                        Direction = "South West";

                    else
                    {
                        Direction = "South";
                    }
                }

                return GetLocation();
            }

            else
            {
                return GetLocation();
            }
        }
    }
}
