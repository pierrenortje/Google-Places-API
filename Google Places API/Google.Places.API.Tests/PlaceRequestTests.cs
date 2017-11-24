using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Google.Places.API.Tests
{
    [TestClass]
    public class PlaceRequestTests : TestBase
    {
        [TestMethod]
        public async Task Get_PlacesBy_Nearby_Search()
        {
            var result = await API.PlaceRequest.GetPlacesByNearbySearch(-33.9249, 18.4241, 10000, "burger");
        }
    }
}
