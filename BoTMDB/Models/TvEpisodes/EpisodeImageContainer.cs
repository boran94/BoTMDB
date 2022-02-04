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
    public class EpisodeImageContainer
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// </summary>

        [JsonPropertyName("stills")]
        public List<ImageItem> Stills { get; set; } = new List<ImageItem>();
    }
}
