using GalacticTravel.Services;

var travelService = new TravelService();

Console.WriteLine(
    $"Cooper is travelling to {travelService.GetDestination("Cooper")}");

Console.WriteLine(
    $"Frodo is travelling to {travelService.GetDestination("Frodo")}");