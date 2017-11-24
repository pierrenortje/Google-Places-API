using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Google.Places.API.Models
{
    public class SearchData
    {
        /// <summary>
        /// Contains any required attributions. This field will always be present, but may be empty.
        /// </summary>
        [DeserializeAs(Name = "html_attributions")]
        public List<object> HtmlAttributions { get; set; }

        [DeserializeAs(Name = "results")]
        public List<Place> Results { get; set; }

        /// <summary>
        /// The <see cref="Status"/>  field may contain the following values:
        /// OK indicates that no errors occurred; the place was successfully detected and at least one result was returned.
        /// ZERO_RESULTS indicates that the search was successful but returned no results. This may occur if the search was passed a <see cref="Latitude"/> and <see cref="Longitude"/> in a remote location.
        /// OVER_QUERY_LIMIT indicates that you are over your quota.
        /// REQUEST_DENIED indicates that your request was denied, generally because of lack of an invalid key parameter.
        /// INVALID_REQUEST generally indicates that a required query parameter (location or radius) is missing.
        /// </summary>
        [DeserializeAs(Name = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Contains a token that can be used to return up to 20 additional results.
        /// A <see cref="NextPageToken"/>  will not be returned if there are no additional results to display.
        /// The maximum number of results that can be returned is 60.
        /// There is a short delay between when a <see cref="NextPageToken"/> is issued, and when it will become valid.
        /// </summary>
        [DeserializeAs(Name = "next_page_token")]
        public string NextPageToken { get; set; }
    }
}
