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
    public class EpisodeSeason
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("episode_number")]
        public int EpisodeNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("season_number")]
        public int SeasonNumber { get; set; }
    }
}
