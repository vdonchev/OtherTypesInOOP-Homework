namespace _01.GalacticGPS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;
    using Models;

    public static class GalacticGps
    {
        public static void Main()
        {
            ILocation location = new Location(18.037986, 28.870097, "Earth");
            Console.WriteLine(location);

            IList<ILocation> locations = new List<ILocation>
            {
                new Location(15.2223, 36.9999, "Saturn"),
                new Location(90, -3.979894, "Uranus"),
                new Location(-80.314564, 179.999999, "Mercury"),
                new Location(1.1111441, 15.645411, "Neptune"),
            };

            locations
                .OrderBy(l => l.Latitude)
                .ThenBy(l => l.Longitude)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
