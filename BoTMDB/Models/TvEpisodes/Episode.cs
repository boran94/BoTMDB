using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.TvEpisodes
{
    /// <summary>
    /// 
    /// </summary>
    public class Episode
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("air_date")]
        public string? AirDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("episode_number")]
        public int EpisodeNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("overview")]
        public string? Overview { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("production_code")]
        public string? ProductionCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("season_number")]
        public int SeasonNumber { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("still_path")]
        public string? StillPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("vote_average")]
        public decimal VoteAverage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("vote_count")]
        public int VoteCount { get; set; }
    }
}
