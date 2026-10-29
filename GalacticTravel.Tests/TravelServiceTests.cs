using GalacticTravel.Services;

namespace GalacticTravel.Tests;

public class TravelServiceTests
{
    [Fact]
    public void Cooper_ShouldTravelToGargantua()
    {
        var service = new TravelService();

        var result = service.GetDestination("Cooper");

        Assert.Equal("Gargantua", result);
    }

    [Fact]
    public void Frodo_ShouldTravelToMountDoom()
    {
        var service = new TravelService();

        var result = service.GetDestination("Frodo");

        Assert.Equal("Mount Doom", result);
    }

    [Fact]
    public void Frodo_ShouldBeAllowedToCarryTheOneRing()
    {
        var service = new TravelService();

        var result = service.CanCarryTheOneRing("Frodo");

        Assert.True(result);
    }

    [Fact]
    public void Sauron_ShouldNotBeAllowedToCarryTheOneRing()
    {
        var service = new TravelService();

        var result = service.CanCarryTheOneRing("Sauron");

        Assert.False(result);
    }
}