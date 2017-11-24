using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Google.Places.API.Models
{
    public class AddressComponent
    {
        /// <summary>
        /// The full text description or name of the address component as returned by the Geocoder.
        /// </summary>
        [DeserializeAs(Name = "long_name")]
        public string LongName { get; set; }
        /// <summary>
        /// An abbreviated textual name for the address component, if available. For example,
        /// an address component for the state of Alaska may have a <see cref="LongName"/>  of "Alaska" and a
        /// <see cref="ShortName"/>  of "AK" using the 2-letter postal abbreviation.
        /// </summary>
        [DeserializeAs(Name = "short_name")]
        public string ShortName { get; set; }
        /// <summary>
        /// A list indicating the type of the address component.
        /// </summary>
        [DeserializeAs(Name = "types")]
        public List<string> Types { get; set; }
    }
}
