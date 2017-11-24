using RestSharp.Deserializers;

namespace Google.Places.API.Models
{
    public class Review
    {
        /// <summary>
        /// The name of the user who submitted the review. Anonymous reviews are attributed to "A Google user".
        /// </summary>
        [DeserializeAs(Name = "author_name")]
        public string AuthorName { get; set; }
        /// <summary>
        /// The URL to the user's Google Maps Local Guides profile, if available.
        /// </summary>
        [DeserializeAs(Name = "author_url")]
        public string AuthorUrl { get; set; }
        /// <summary>
        /// An IETF language code indicating the language used in the user's review.
        /// This field contains the main language tag only, and not the secondary tag indicating country or
        /// region. For example, all the English reviews are tagged as 'en', and not 'en-AU' or 'en-UK' and so on.
        /// </summary>
        [DeserializeAs(Name = "language")]
        public string Language { get; set; }

        [DeserializeAs(Name = "profile_photo_url")]
        public string ProfilePhotoUrl { get; set; }
        /// <summary>
        /// The user's overall rating for this place. This is a whole number, ranging from 1 to 5.
        /// </summary>
        [DeserializeAs(Name = "rating")]
        public int Rating { get; set; }

        [DeserializeAs(Name = "relative_time_description")]
        public string RelativeTimeDescription { get; set; }
        /// <summary>
        ///  the user's review. When reviewing a location with Google Places, text reviews are considered
        ///  optional. Therefore, this field may by empty. Note that this field may include simple HTML
        ///  markup. For example, the entity reference &amp; may represent an ampersand character.
        /// </summary>
        [DeserializeAs(Name = "text")]
        public string Text { get; set; }
        /// <summary>
        /// The time that the review was submitted, measured in the number of seconds since since midnight, January 1, 1970 UTC.
        /// </summary>
        [DeserializeAs(Name = "time")]
        public int Time { get; set; }
    }
}
