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
    public class PersonCastForCombined
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("original_language")]
        public string? OriginalLanguage { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("episode_count")]
        public int EpisodeCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("overview")]
        public string? Overview { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("origin_country")]
        public List<string?> OriginCountry { get; set; } = new();

        /// <summary>
        /// </summary>
        [JsonPropertyName("original_name")]
        public string? OriginalName { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("genre_ids")]
        public List<int> GenreIds { get; set; } = new();

        /// <summary>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("media_type")]
        public string? MediaType { get; set; }

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
        public decimal VoteAverage { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("vote_count")]
        public int VoteCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("character")]
        public string? Character { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("backdrop_path")]
        public string? BackdropPath { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("popularity")]
        public decimal Popularity { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("credit_id")]
        public string? CreditId { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("original_title")]
        public string? OriginalTitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("video")]
        public bool Video { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("release_date")]
        public string? ReleaseDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("adult")]
        public bool Adult { get; set; }
    }
}
