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
    public class PersonCrewForMovie:CrewBase
    {

        /// <summary>
        /// </summary>
        [JsonPropertyName("original_language")]
        public string? OriginalLanguage { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("original_title")]
        public string? OriginalTitle { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("overview")]
        public string? Overview { get; set; }



        /// <summary>
        /// </summary>
        [JsonPropertyName("vote_count")]
        public int VoteCount { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("video")]
        public bool Video { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("poster_path")]
        public string? PosterOrProfilePath { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("backdrop_path")]
        public string? BackdropPath { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("title")]
        public string? TitleOrName { get; set; }



        /// <summary>
        /// </summary>
        [JsonPropertyName("genre_ids")]
        public List<int> GenreIds { get; set; } = new();

        /// <summary>
        /// </summary>
        [JsonPropertyName("vote_average")]
        public decimal? VoteAverage { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("release_date")]
        public string? ReleaseDate { get; set; }
    }
}
