using RestSharp.Deserializers;

namespace Google.Places.API.Models
{
    public class Viewport
    {
        [DeserializeAs(Name = "northeast")]
        public Location NorthEast { get; set; }

        [DeserializeAs(Name = "southwest")]
        public Location SouthWest { get; set; }
    }
}
