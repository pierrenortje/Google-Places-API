using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Google.Places.API.Models
{
    public class Photo
    {
        /// <summary>
        /// The maximum height of the image.
        /// </summary>
        [DeserializeAs(Name = "height")]
        public int Height { get; set; }

        /// <summary>
        /// Contains any required attributions. This field will always be present, but may be empty.
        /// </summary>
        [DeserializeAs(Name = "html_attributions")]
        public List<string> HtmlAttributions { get; set; }

        /// <summary>
        /// A string used to identify the photo when you perform a Photo request.
        /// </summary>
        [DeserializeAs(Name = "photo_reference")]
        public string PhotoReference { get; set; }

        /// <summary>
        /// The maximum width of the image.
        /// </summary>
        [DeserializeAs(Name = "width")]
        public int Width { get; set; }
    }
}
