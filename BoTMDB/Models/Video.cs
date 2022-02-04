using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Video
    {

        /// <summary>
        /// </summary>
        [JsonPropertyName("iso_639_1")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("iso_3166_1")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("site")]
        public string? Site { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("size")]
        public int Size { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("official")]
        public bool? Official { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("published_at")]
        public string? PublishedAt { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }
    }
}
