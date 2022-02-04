using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models
{
    /// <summary>
    /// </summary>
    public class ExternalItem
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("imdb_id")]
        public string? ImdbId { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("facebook_id")]
        public string? FacebookId { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("instagram_id")]
        public string? InstagramId { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("twitter_id")]
        public string? TwitterId { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

    }
}
