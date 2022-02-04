using BoTMDB.Models.Credits;
using BoTMDB.Models.TvEpisodes;
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
    public class TvSeason:Season
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("_id")]
        public string? _Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("episodes")]
        public List<TvSeasonEpisode> Episodes { get; set; } = new();
    }
    /// <summary>
    /// 
    /// </summary>
    public class TvSeasonEpisode:Episode
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("crew")]
        public List<CrewBase> Crew { get; set; } = new();

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("guest_stars")]
        public List<CrewBase> GuestStars { get; set; } = new();
    }
}
