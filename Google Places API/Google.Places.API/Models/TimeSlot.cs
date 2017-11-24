using RestSharp.Deserializers;

namespace Google.Places.API.Models
{
    public class TimeSlot
    {
        /// <summary>
        /// A number from 0–6, corresponding to the days of the week, starting on Sunday. For example, 2 means Tuesday.
        /// </summary>
        [DeserializeAs(Name = "day")]
        public int Day { get; set; }

        /// <summary>
        /// May contain a time of day in 24-hour hhmm format. Values are in the range 0000–2359. The time will be
        /// reported in the place’s time zone.
        /// </summary>
        [DeserializeAs(Name = "time")]
        public string Time { get; set; }
    }
}
