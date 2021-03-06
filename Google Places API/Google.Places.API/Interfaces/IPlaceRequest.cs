﻿using Google.Places.API.Models;
using System.Threading.Tasks;

namespace Google.Places.API.Interfaces
{
    public interface IPlaceRequest
    {
        /// <summary>
        /// Send a request to gather information from a location using coordinates.
        /// </summary>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        /// <param name="radius">
        /// In meters. Maximum allowed radius is 50 000 meters.
        /// Note that radius must not be included if rankby=distance is specified.
        /// </param>
        /// <param name="keyword">
        /// A term to be matched against all content that Google has indexed for this place,
        /// including but not limited to name, type, and address, as well as customer reviews
        /// and other third-party content.
        /// </param>
        /// <param name="name">
        /// A term to be matched against all content that Google has indexed for this place.
        /// Equivalent to keyword. The name field is no longer restricted to place names.
        /// Values in this field are combined with values in the keyword field and passed as
        /// part of the same search string.
        /// We recommend using only the keyword parameter for all search terms.
        /// </param>
        /// <param name="rankBy"></param>
        /// <param name="placeType">
        /// Restricts the results to places matching the specified type. Only one type may be
        /// specified.
        /// </param>
        /// <param name="language">
        /// The language code, indicating in which language the results should be returned,
        /// if possible.
        /// </param>
        /// <param name="minPriceLevel">
        /// Restricts results to only those places within the specified range.
        /// Valid values range between most affordable to most expensive.
        /// The exact amount indicated by a specific value will vary from region to region.
        /// </param>
        /// <param name="maxPriceLevel">
        /// Restricts results to only those places within the specified range.
        /// Valid values range between most affordable to most expensive.
        /// The exact amount indicated by a specific value will vary from region to region.
        /// </param>
        /// <param name="openNow">
        /// Returns only those places that are open for business at the time the query is sent.
        /// Places that do not specify opening hours in the Google Places database will not be
        /// returned if you include this parameter in your query.
        /// </param>
        /// <param name="region">
        /// The region code, specified as a ccTLD (country code top-level domain) two-character
        /// value. Most ccTLD codes are identical to ISO 3166-1 codes, with some exceptions.
        /// This parameter will only influence, not fully restrict, search results. If more
        /// relevant results exist outside of the specified region, they may be included. When
        /// this parameter is used, the country name is omitted from the resulting <see cref="FormattedAddress"/>
        /// for results in the specified region.
        /// </param>
        /// <returns>A list of places along with summary information about each place.</returns>
        Task<SearchData> GetPlacesByNearbySearch(double latitude, double longitude, int? radius = null, string keyword = null, string name = null, RankBy rankBy = RankBy.Undefined, PlaceType placeType = PlaceType.Undefined, Language language = Language.Undefined, PriceLevel minPriceLevel = PriceLevel.Undefined, PriceLevel maxPriceLevel = PriceLevel.Undefined, bool? openNow = null, string pageToken = null, string region = null);

        /// <summary>
        /// Send a request to gather information from a location using query text.
        /// </summary>
        /// <param name="query">
        /// The text string on which to search, for example: "restaurant" or "123 Main Street".
        /// The Google Places service will return candidate matches based on this string and order
        /// the results based on their perceived relevance. This parameter becomes optional if the
        /// type parameter is also used in the search request.
        /// </param>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        /// <param name="radius">
        /// In meters. Maximum allowed radius is 50 000 meters.
        /// Note that radius must not be included if rankby=distance is specified.
        /// </param>
        /// <param name="language">
        /// The language code, indicating in which language the results should be returned,
        /// if possible.
        /// </param>
        /// <param name="minPriceLevel">
        /// Restricts results to only those places within the specified range.
        /// Valid values range between most affordable to most expensive.
        /// The exact amount indicated by a specific value will vary from region to region.
        /// </param>
        /// <param name="maxPriceLevel">
        /// Restricts results to only those places within the specified range.
        /// Valid values range between most affordable to most expensive.
        /// The exact amount indicated by a specific value will vary from region to region.
        /// </param>
        /// <param name="openNow">
        /// Returns only those places that are open for business at the time the query is sent.
        /// Places that do not specify opening hours in the Google Places database will not be
        /// returned if you include this parameter in your query.
        /// </param>
        /// <param name="pageToken">
        /// Returns the next 20 results from a previously run search.
        /// Setting a pagetoken parameter will execute a search with the same parameters used previously — all parameters other than pagetoken will be ignored.
        /// </param>
        /// <param name="placeType"></param>
        /// <returns>A list of places along with summary information about each place.</returns>
        Task<SearchData> GetPlacesByTextSearch(string query, double? latitude = null, double? longitude = null, int? radius = null, Language language = Language.Undefined, PriceLevel minPriceLevel = PriceLevel.Undefined, PriceLevel maxPriceLevel = PriceLevel.Undefined, bool? openNow = null, string pageToken = null, PlaceType placeType = PlaceType.Undefined);

        /// <summary>
        /// Send a request to gather detailed information from a place.
        /// </summary>
        /// <param name="placeID">
        /// A textual identifier that uniquely identifies a place, returned from a Place Search.
        /// </param>
        /// <param name="language">
        /// The language code, indicating in which language the results should be returned,
        /// if possible.
        /// </param>
        /// <param name="region">
        /// The region code, specified as a ccTLD (country code top-level domain) two-character
        /// value. Most ccTLD codes are identical to ISO 3166-1 codes, with some exceptions.
        /// This parameter will only influence, not fully restrict, search results. If more
        /// relevant results exist outside of the specified region, they may be included. When
        /// this parameter is used, the country name is omitted from the resulting <see cref="FormattedAddress"/>
        /// for results in the specified region.
        /// </param>
        /// <returns></returns>
        Task<PlaceDetailsData> GetPlaceDetailsByPlaceID(string placeID, Language language = Language.Undefined, string region = null);

        /// <summary>
        /// Send a request to gather detailed information from a place.
        /// </summary>
        /// <param name="reference">
        /// A textual reference that uniquely identifies a place, returned from a Place Search.
        /// </param>
        /// <param name="language">
        /// The language code, indicating in which language the results should be returned,
        /// if possible.
        /// </param>
        /// <param name="region">
        /// The region code, specified as a ccTLD (country code top-level domain) two-character
        /// value. Most ccTLD codes are identical to ISO 3166-1 codes, with some exceptions.
        /// This parameter will only influence, not fully restrict, search results. If more
        /// relevant results exist outside of the specified region, they may be included. When
        /// this parameter is used, the country name is omitted from the resulting <see cref="FormattedAddress"/>
        /// for results in the specified region.
        /// </param>
        /// <returns></returns>
        Task<PlaceDetailsData> GetPlaceDetailsByReference(string reference, Language language = Language.Undefined, string region = null);

        /// <summary>
        /// Download photos for a place.
        /// </summary>
        /// <param name="photoReference"></param>
        /// <param name="maxHeight"></param>
        /// <param name="maxWidth"></param>
        /// <returns></returns>
        Task<byte[]> GetPlacePhoto(string photoReference, int? maxHeight = null, int? maxWidth = null);
    }
}
