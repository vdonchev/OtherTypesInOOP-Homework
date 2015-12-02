namespace _01.GalacticGPS.Contracts
{
    public interface ILocation
    {
        double Latitude { get; } 

        double Longitude { get; } 

        string PlanetName { get; } 
    }
}