namespace _01.GalacticGPS.Models
{
    using System;
    using Contracts;
    using Exceptions;

    public struct Location : ILocation
    {
        private const int LatitudeMin = -90;
        private const int LatitudeMax = 90;
        private const int LongitudeMin = -180;
        private const int LongitudeMax = 180;

        private double latitude;
        private double longitude;
        private Planet planetName;

        public Location(
            double latitude,
            double longitude,
            string planet)
            : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.PlanetName = planet;
        }

        public double Latitude
        {
            get
            {
                return this.latitude;
            }

            private set
            {
                if (value < LatitudeMin || value > LatitudeMax)
                {
                    throw new LocationException(
                        string.Format(
                            Messages.ValueShouldBeInRange,
                            nameof(this.latitude),
                            LatitudeMin,
                            LatitudeMax));
                }

                this.latitude = value;
            }
        }

        public double Longitude
        {
            get
            {
                return this.longitude;
            }

            private set
            {
                if (value < LongitudeMin || value > LongitudeMax)
                {
                    throw new LocationException(
                        string.Format(
                            Messages.ValueShouldBeInRange,
                            nameof(this.longitude),
                            LongitudeMin,
                            LongitudeMax));
                }
                
                this.longitude = value;
            }
        }

        public string PlanetName
        {
            get
            {
                return this.planetName.ToString();
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(
                        string.Format(
                            Messages.StringCantBeNullOrEmpty,
                            nameof(this.planetName)));
                }

                Planet planet;
                if (!Enum.TryParse(value, out planet))
                {
                    throw new LocationException(
                        string.Format(
                            Messages.PlanetNotFound,
                            value));
                }

                this.planetName = planet;
            }
        }

        public override string ToString()
        {
            return $"{this.latitude}, {this.longitude} - {this.PlanetName}";
        }
    }
}