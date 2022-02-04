using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Movies
{
    /// <summary>
    /// 
    /// </summary>
    public class ReleaseDateContainer
    {

        /// <summary>
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("results")]
        public List<ReleaseDate> Results { get; set; } = new();
    }

    /// <summary>
    /// </summary>
    public class ReleaseDate
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("iso_3166_1")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("release_dates")]
        public List<ReleaseDateItem> ReleaseDates { get; set; } = new();
    }
    /// <summary>
    /// 
    /// </summary>
    public class ReleaseDateItem
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("certification")]
        public string? Certification { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("iso_639_1")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("release_date")]
        public string? ReleaseDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("type")]
        public int? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("note")]
        public string? Note { get; set; }

    }
}
