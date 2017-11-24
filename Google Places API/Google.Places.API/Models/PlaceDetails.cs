using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Google.Places.API.Models
{
    public class PlaceDetails
    {
        /// <summary>
        /// An list containing the separate components applicable to this address.
        /// </summary>
        [DeserializeAs(Name = "address_components")]
        public List<AddressComponent> AddressComponents { get; set; }

        /// <summary>
        /// A representation of the place's address in the adr microformat.
        /// </summary>
        [DeserializeAs(Name = "adr_address")]
        public string AdrAddress { get; set; }

        [DeserializeAs(Name = "formatted_address")]
        public string FormattedAddress { get; set; }

        /// <summary>
        /// contains the place's phone number in its local format.
        /// For example, the formatted_phone_number for Google's Sydney, Australia office is (02) 9374 4000.
        /// </summary>
        [DeserializeAs(Name = "formatted_phone_number")]
        public string FormattedPhoneNumber { get; set; }

        [DeserializeAs(Name = "geometry")]
        public Geometry Geometry { get; set; }

        /// <summary>
        /// The URL of a suggested icon which may be displayed to the user when indicating this result on a map.
        /// </summary>
        [DeserializeAs(Name = "icon")]
        public string Icon { get; set; }

        [DeserializeAs(Name = "id")]
        public string ID { get; set; }

        /// <summary>
        /// Contains the place's phone number in international format.
        /// International format includes the country code, and is prefixed with the plus (+) sign.
        /// For example, the international_phone_number for Google's Sydney, Australia office is +61 2 9374 4000
        /// </summary>
        [DeserializeAs(Name = "international_phone_number")]
        public string InternationalPhoneNumber { get; set; }

        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        [DeserializeAs(Name = "opening_hours")]
        public OpeningHours OpeningHours { get; set; }

        [DeserializeAs(Name = "photos")]
        public List<Photo> Photos { get; set; }

        /// <summary>
        /// A textual identifier that uniquely identifies a place.
        /// To retrieve information about the place, pass this identifier in the placeId field of a Places API request.
        /// </summary>
        [DeserializeAs(Name = "place_id")]
        public string PlaceID { get; set; }

        /// <summary>
        /// Contains the place's rating, from 1.0 to 5.0, based on aggregated user reviews.
        /// </summary>
        [DeserializeAs(Name = "rating")]
        public double Rating { get; set; }

        [DeserializeAs(Name = "reference")]
        public string Reference { get; set; }

        [DeserializeAs(Name = "reviews")]
        public List<Review> Reviews { get; set; }

        [DeserializeAs(Name = "scope")]
        public string Scope { get; set; }

        /// <summary>
        /// A list of feature types describing the given result.
        /// </summary>
        [DeserializeAs(Name = "types")]
        public List<string> Types { get; set; }

        /// <summary>
        /// The URL of the official Google page for this place. This will be the Google-owned page that contains the
        /// best available information about the place. Applications must link to or embed this page on any screen
        /// that shows detailed results about the place to the user.
        /// </summary>
        [DeserializeAs(Name = "url")]
        public string Url { get; set; }

        /// <summary>
        ///  contains the number of minutes this place’s current timezone is offset from UTC. For example, for places
        ///  in Sydney, Australia during daylight saving time this would be 660 (+11 hours from UTC), and for places
        ///  in California outside of daylight saving time this would be -480 (-8 hours from UTC).
        /// </summary>
        [DeserializeAs(Name = "utc_offset")]
        public int UtcOffset { get; set; }

        /// <summary>
        /// Lists a simplified address for the place, including the street name, street number, and locality,
        /// but not the province/state, postal code, or country. For example, Google's Sydney, Australia office
        /// has a vicinity value of 48 Pirrama Road, Pyrmont.
        /// </summary>
        [DeserializeAs(Name = "vicinity")]
        public string Vicinity { get; set; }

        /// <summary>
        /// The authoritative website for this place, such as a business' homepage.
        /// </summary>
        [DeserializeAs(Name = "website")]
        public string Website { get; set; }
    }
}
