namespace GalacticTravel.Services;

public class TravelService
{
    public string GetDestination(string traveler)
    {
        return traveler.ToLower() switch
        {
            "cooper" => "Gargantua",
            "frodo" => "Mount Doom",
            "gandalf" => "Valinor",
            _ => "Unknown destination"
        };
    }

    public bool CanCarryTheOneRing(string traveler)
    {
        return traveler.Equals(
            "Frodo",
            StringComparison.OrdinalIgnoreCase);
    }
}