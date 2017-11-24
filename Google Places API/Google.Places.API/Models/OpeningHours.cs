using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Google.Places.API.Models
{
    public class OpeningHours
    {
        /// <summary>
        /// A boolean value indicating if the place is open at the current time.
        /// </summary>
        [DeserializeAs(Name = "open_now")]
        public bool OpenNow { get; set; }

        /// <summary>
        /// A list of seven strings representing the formatted opening hours for each day of the week.
        /// If a language parameter was specified in the Place Details request, the Places Service will
        /// format and localize the opening hours appropriately for that language. The ordering of the
        /// elements in this array depends on the language parameter. Some languages start the week on
        /// Monday while others start on Sunday.
        /// </summary>
        [DeserializeAs(Name = "weekday_text")]
        public List<object> Weekday { get; set; }

        /// <summary>
        /// A list of opening periods covering seven days, starting from Sunday, in chronological order. 
        /// </summary>
        [DeserializeAs(Name = "periods")]
        public List<Period> Periods { get; set; }
    }
}
