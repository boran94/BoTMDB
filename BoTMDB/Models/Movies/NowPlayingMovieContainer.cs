using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Movies
{
    /// <summary>
    /// 
    /// </summary>
    public class NowPlayingMovieContainer:ResultContainer<MovieItem>
    {

        /// <summary>
        /// </summary>
        [JsonPropertyName("dates")]
        public DateItem? Dates { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class DateItem
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("minimum")]
        public string? Minimum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("maximum")]
        public string? Maximum { get; set; }
    }
}
