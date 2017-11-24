using RestSharp.Deserializers;

namespace Google.Places.API.Models
{
    public class Location
    {
        [DeserializeAs(Name = "lat")]
        public float Latitude { get; set; }

        [DeserializeAs(Name = "lng")]
        public float Longitude { get; set; }
    }
}
