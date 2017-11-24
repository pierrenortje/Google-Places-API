using Google.Places.API.Interfaces;
using Google.Places.API.Models;
using RestSharp;
using System.Threading.Tasks;

namespace Google.Places.API.Requests
{
    public class PlaceRequest : RequestBase, IPlaceRequest
    {
        public PlaceRequest(IRestClient restClient, string apiKey) : base(restClient, apiKey) { }

        public async Task<NearbySearchData> GetPlacesByNearbySearch(double latitude, double longitude, int? radius = null, string keyword = null, string name = null, RankBy rankBy = RankBy.Undefined, PlaceType placeType = PlaceType.Undefined, Language language = Language.Undefined, PriceLevel minPriceLevel = PriceLevel.Undefined, PriceLevel maxPriceLevel = PriceLevel.Undefined, bool? openNow = null, string pageToken = null, string region = null)
        {
            var request = new RestRequest("nearbysearch/json", Method.GET);

            request.AddParameter("key", this.apiKey);
            request.AddParameter("location", $"{latitude},{longitude}");

            if (!string.IsNullOrEmpty(keyword))
                request.AddParameter("keyword", keyword);

            if (!string.IsNullOrEmpty(name))
                request.AddParameter("name", name);

            if (rankBy != RankBy.Undefined)
                request.AddParameter("rankby", GetRankByValue(rankBy));

            if (radius.HasValue)
                request.AddParameter("radius", radius.Value);

            if (language != Language.Undefined)
                request.AddParameter("language", GetLanguageCode(language));

            if (minPriceLevel != PriceLevel.Undefined)
                request.AddParameter("minprice", (int)minPriceLevel);

            if (maxPriceLevel != PriceLevel.Undefined)
                request.AddParameter("maxprice", (int)maxPriceLevel);

            if (openNow.HasValue)
                request.AddParameter("opennow", openNow.Value.ToString().ToLower());

            if (placeType != PlaceType.Undefined)
                request.AddParameter("type", GetPlaceType(placeType));

            if (!string.IsNullOrEmpty(pageToken))
                request.AddParameter("pagetoken", pageToken);

            if (!string.IsNullOrEmpty(region))
                request.AddParameter("region", region);

            return await base.Execute<NearbySearchData>(request);
        }
    }
}
