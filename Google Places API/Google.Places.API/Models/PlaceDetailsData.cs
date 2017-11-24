using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Google.Places.API.Models
{
    public class PlaceDetailsData
    {
        [DeserializeAs(Name = "html_attributions")]
        public List<object> HtmlAttributions { get; set; }

        [DeserializeAs(Name = "result")]
        public PlaceDetails Result { get; set; }

        /// <summary>
        /// The <see cref="Status"/> field may contain the following values:
        /// OK indicates that no errors occurred; the place was successfully detected and at least one result was returned.
        /// UNKNOWN_ERROR indicates a server-side error; trying again may be successful.
        /// ZERO_RESULTS indicates that the reference was valid but no longer refers to a valid result.This may occur if the establishment is no longer in business.
        /// OVER_QUERY_LIMIT indicates that you are over your quota.
        /// REQUEST_DENIED indicates that your request was denied, generally because of lack of an invalid key parameter.
        /// INVALID_REQUEST generally indicates that the query (reference) is missing.
        /// NOT_FOUND indicates that the referenced location was not found in the Places database.
        /// </summary>
        [DeserializeAs(Name = "status")]
        public string Status { get; set; }
    }
}
