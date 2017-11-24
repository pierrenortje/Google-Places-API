using Google.Places.API.Interfaces;
using Google.Places.API.Models;
using RestSharp;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Places.API.Requests
{
    public class PlaceRequest : RequestBase, IPlaceRequest
    {
        public PlaceRequest(IRestClient restClient, string apiKey) : base(restClient, apiKey) { }

        public async Task<SearchData> GetPlacesByNearbySearch(double latitude, double longitude, int? radius = null, string keyword = null, string name = null, RankBy rankBy = RankBy.Undefined, PlaceType placeType = PlaceType.Undefined, Language language = Language.Undefined, PriceLevel minPriceLevel = PriceLevel.Undefined, PriceLevel maxPriceLevel = PriceLevel.Undefined, bool? openNow = null, string pageToken = null, string region = null)
        {
            var request = new RestRequest("nearbysearch/json", Method.GET);

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

            return await base.Execute<SearchData>(request);
        }

        public async Task<SearchData> GetPlacesByTextSearch(string query, double? latitude = null, double? longitude = null, int? radius = null, Language language = Language.Undefined, PriceLevel minPriceLevel = PriceLevel.Undefined, PriceLevel maxPriceLevel = PriceLevel.Undefined, bool? openNow = null, string pageToken = null, PlaceType placeType = PlaceType.Undefined)
        {
            var request = new RestRequest("textsearch/json", Method.GET);

            request.AddParameter("query", query);

            if (latitude.HasValue && longitude.HasValue)
            {
                request.AddParameter("latitude", latitude.Value);
                request.AddParameter("longitude", longitude.Value);
            }

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

            if (!string.IsNullOrEmpty(pageToken))
                request.AddParameter("pagetoken", pageToken);

            if (placeType != PlaceType.Undefined)
                request.AddParameter("type", GetPlaceType(placeType));

            return await base.Execute<SearchData>(request);
        }

        public async Task<PlaceDetailsData> GetPlaceDetailsByPlaceID(string placeID, Language language = Language.Undefined, string region = null)
        {
            var request = new RestRequest("details/json", Method.GET);

            request.AddParameter("placeid", placeID);

            if (language != Language.Undefined)
                request.AddParameter("language", GetLanguageCode(language));

            if (!string.IsNullOrEmpty(region))
                request.AddParameter("region", region);

            return await base.Execute<PlaceDetailsData>(request);
        }

        public async Task<PlaceDetailsData> GetPlaceDetailsByReference(string reference, Language language = Language.Undefined, string region = null)
        {
            var request = new RestRequest("details/json", Method.GET);

            request.AddParameter("reference", reference);

            if (language != Language.Undefined)
                request.AddParameter("language", GetLanguageCode(language));

            if (!string.IsNullOrEmpty(region))
                request.AddParameter("region", region);

            return await base.Execute<PlaceDetailsData>(request);
        }

        public async Task<byte[]> GetPlacePhoto(string photoReference, int? maxHeight = null, int? maxWidth = null)
        {
            var request = new RestRequest("photo", Method.GET);
            var cancellationTokenSource = new CancellationTokenSource();

            request.AddParameter("key", base.apiKey);
            request.AddParameter("photoreference", photoReference);

            if (maxHeight.HasValue)
                request.AddParameter("maxheight", maxHeight.Value);

            if (maxWidth.HasValue)
                request.AddParameter("maxwidth", maxWidth.Value);

            var response = await this.restClient.ExecuteTaskAsync(request, cancellationTokenSource.Token);

            return response.RawBytes;
        }
    }
}
