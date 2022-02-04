using BoTMDB.Models.TvEpisodeGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Tv
{
    /// <summary>
    /// 
    /// </summary>
    public class EpisodeGroupForTv
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("results")]
        public List<EpisodeGroup> Results { get; set; } = new();
        
    }
}
