using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Credits
{
    /// <summary>
    /// 
    /// </summary>
    public class PersonCastForTv: CastBase
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("title")]
        public string? NameOrTitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("original_title")]
        public string? OriginalNameOrTitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("backdrop_path")]
        public string? BackdropPath { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("genre_ids")]
        public List<int> GenreIds { get; set; } = new();

        /// <summary>
        /// </summary>
        [JsonPropertyName("original_language")]
        public string? OriginalLanguage { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("overview")]
        public string? Overview { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("poster_path")]
        public string? PosterPath { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("first_air_date")]
        public string? FirstAirDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("vote_average")]
        public decimal? VoteAverage { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("vote_count")]
        public int VoteCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("episode_count")]
        public int EpisodeCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("origin_country")]
        public List<string> OriginCountry { get; set; }=new();
    }
}
