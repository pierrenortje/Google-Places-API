using Google.Places.API.Requests;
using RestSharp;
using System;

namespace Google.Places.API
{
    public class ApiRequest
    {
        #region Private Fields
        private readonly IRestClient restClient;
        private readonly string apiKey;
        #endregion

        #region Constructor
        public ApiRequest(string apiKey)
        {
            this.restClient = new RestClient
            {
                BaseUrl = new Uri("https://maps.googleapis.com/maps/api/place/")
            };

            this.apiKey = apiKey;
        }
        #endregion

        #region Public Properties
        public PlaceRequest PlaceRequest { get { return new PlaceRequest(this.restClient, this.apiKey); } }
        #endregion
    }
}
