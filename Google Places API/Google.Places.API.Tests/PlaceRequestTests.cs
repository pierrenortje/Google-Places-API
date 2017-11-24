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

        [TestMethod]
        public async Task Get_Places_By_Text_Search()
        {
            var result = await API.PlaceRequest.GetPlacesByTextSearch("123 main street", 42.3675294, -71.186966, 10000);
        }

        [TestMethod]
        public async Task Get_Place_Details_By_PlaceID()
        {
            var result = await API.PlaceRequest.GetPlaceDetailsByPlaceID("ChIJfWJEl3FnzB0RMKNBSt7LYZQ");
        }

        [TestMethod]
        public async Task Get_Place_Details_By_Reference()
        {
            var result = await API.PlaceRequest.GetPlaceDetailsByReference("CmRRAAAAerGqXHcbhCbdDQ0EWvC971S8mxqm110DeU1K6M43mkBpKftLIkrKtCAuKsl1YMB5u-Ig7vwhfyMZ2AhwGJbGDdvm-dV9d8rXUIP6awwsSfvupTpIflOCNENHNeUxKwtmEhBZXFLWCP9uvNpTnE_U1Db2GhQEnff6Tniko-AQbFP1urOw4y_FNg");
        }

        [TestMethod]
        public async Task Get_Place_Photo()
        {
            var result = await API.PlaceRequest.GetPlacePhoto("CmRaAAAAPsrIptUXRDhm5eha7WvuLK0jbDBXXW9siyA_drI-Y6tRJ-i7tNLEvAPxVqIfDNiBqv2pvBLypFWg9KM20aJaVrl_OPuVdkwfwqS948f1Xo8DlYsYSW8f6lZU_FGB2IUYEhCSNJXupLpRrrLtyfuaOF4dGhQMOZEn7DEY59k8uVzy9iVNFSY5pA");
        }
    }
}
