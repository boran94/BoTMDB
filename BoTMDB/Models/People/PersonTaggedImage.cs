using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.People
{
    /// <summary>
    /// </summary>
    public class PersonTaggedImage :ImageItem
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("image_type")]
        public string? ImageType { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("media_type")]
        public string? MediaType { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("media")]
        public TaggedMediaItem? Media { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class TaggedMediaItem:MediaItem
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("adult")]
        public bool? Adult { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("first_air_date")]
        public string? FirstAirDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("original_name")]
        public string? OriginalName { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("video")]
        public bool? Video { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("origin_country")]
        public List<string> OriginCountry { get; set; } = new();
        

    }
}
