using RestSharp.Deserializers;

namespace Google.Places.API.Models
{
    public class Geometry
    {
        [DeserializeAs(Name = "location")]
        public Location Location { get; set; }

        [DeserializeAs(Name = "viewport")]
        public Viewport Viewport { get; set; }
    }
}
