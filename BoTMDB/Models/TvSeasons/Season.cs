using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.TvSeasons
{
    /// <summary>
    /// 
    /// </summary>
    public class Season
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("air_date")]
        public string? AirDate { get; set; }

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
        [JsonPropertyName("poster_path")]
        public string? PosterPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("season_number")]
        public int SeasonNumber { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("episode_count")]
        public int EpisodeCount { get; set; }
        
    }
}
