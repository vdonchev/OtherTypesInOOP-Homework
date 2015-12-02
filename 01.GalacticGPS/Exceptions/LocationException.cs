namespace _01.GalacticGPS.Exceptions
{
    using System;

    public class LocationException : Exception
    {
        public LocationException(string message)
            : base(message)
        {
        }
    }
}