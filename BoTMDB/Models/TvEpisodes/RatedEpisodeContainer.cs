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
    public class RatedEpisodeContainer : ResultContainer<RatedEpisode>
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public class RatedEpisode:Episode
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("rating")]
        public decimal Rating { get; set; }
    }
}
