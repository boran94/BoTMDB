using BoTMDB.Models.People;
using BoTMDB.Models.Tv;
using BoTMDB.Models.TvEpisodes;
using BoTMDB.Models.TvSeasons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Find
{
    /// <summary>
    /// 
    /// </summary>
    public class FindContainer
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("movie_results")]
        public List<MovieItem> MovieResults { get; set; } = new();

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("person_results")]
        public List<PersonWithKnownFor> PersonResults { get; set; } = new();

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("tv_results")]
        public List<MediaItem> TvResults { get; set; } = new();

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("tv_episode_results")]
        public List<Episode> TvEpisodeResults { get; set; } = new();

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("tv_season_results")]
        public List<Season> TvSeasonResults { get; set; } = new();
    }
}
