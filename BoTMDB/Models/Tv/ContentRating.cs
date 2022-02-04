using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Tv
{
    /// <summary>
    /// 
    /// </summary>
    public class ContentRating
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("results")]
        public List<ContentRatingItem> Results { get; set; } = new();
}
    /// <summary>
    /// 
    /// </summary>
    public class ContentRatingItem
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("iso_3166_1")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("rating")]
        public string? Rating { get; set; }
    }

}
