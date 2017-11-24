using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Google.Places.API.Models
{
    public class Place
    {
        [DeserializeAs(Name = "id")]
        public string ID { get; set; }

        [DeserializeAs(Name = "geometry")]
        public Geometry Geometry { get; set; }

        /// <summary>
        /// Contains the URL of a recommended icon which may be displayed to the user when indicating this result.
        /// </summary>
        [DeserializeAs(Name = "icon")]
        public string Icon { get; set; }

        /// <summary>
        /// Contains the human-readable name for the returned result. For establishment results, this is usually the business name.
        /// </summary>
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        [DeserializeAs(Name = "opening_hours")]
        public OpeningHours OpeningHours { get; set; }

        /// <summary>
        /// An array of photo objects, each containing a reference to an image.
        /// A Place Search will return at most one photo object.
        /// Performing a Place Details request on the place may return up to ten photos.
        /// </summary>
        [DeserializeAs(Name = "photos")]
        public List<Photo> Photos { get; set; }

        [DeserializeAs(Name = "place_id")]
        public string PlaceID { get; set; }

        /// <summary>
        /// Contains the place's rating, from 1.0 to 5.0, based on aggregated user reviews.
        /// </summary>
        [DeserializeAs(Name = "rating")]
        public double Rating { get; set; }

        [DeserializeAs(Name = "reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Indicates the scope of the <see cref="PlaceID"/>. The possible values are:
        /// APP: The place ID is recognised by your application only.
        /// This is because your application added the place, and the place has not yet passed the moderation process.
        /// GOOGLE: The place ID is available to other applications and on Google Maps.
        /// </summary>
        [DeserializeAs(Name = "scope")]
        public string Scope { get; set; }

        [DeserializeAs(Name = "types")]
        public List<string> Types { get; set; }

        /// <summary>
        /// A string containing the human-readable address of this place.
        /// Often this address is equivalent to the "postal address".
        /// The <see cref="FormattedAddress"/>  property is only returned for a Text Search.
        /// </summary>
        [DeserializeAs(Name = "formatted_address")]
        public string FormattedAddress { get; set; }

        /// <summary>
        /// Contains a feature name of a nearby location.
        /// Often this feature refers to a street or neighborhood within the given results.
        /// The vicinity property is only returned for a Nearby Search.
        /// </summary>
        [DeserializeAs(Name = "vicinity")]
        public string Vicinity { get; set; }

        /// <summary>
        /// 0: Free.
        /// 1: Inexpensive.
        /// 2: Moderate.
        /// 3: Expensive.
        /// 4: Very Expensive.
        /// </summary>
        [DeserializeAs(Name = "price_level")]
        public int? PriceLevel { get; set; }
    }
}
