using RestSharp.Deserializers;

namespace Google.Places.API.Models
{
    public class Period
    {
        /// <summary>
        /// May contain a pair of day and time objects describing when the place closes. Note: If a place is always
        /// open, the close section will be missing from the response. Clients can rely on always-open being
        /// represented as an open period containing day with value 0 and time with value 0000, and no close.
        /// </summary>
        [DeserializeAs(Name = "close")]
        public TimeSlot Close { get; set; }

        /// <summary>
        /// Contains a pair of day and time objects describing when the place opens.
        /// </summary>
        [DeserializeAs(Name = "open")]
        public TimeSlot Open { get; set; }
    }
}
