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
    public class RatedMovieContainer : ResultContainer<MovieItem>
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public class RatedMovieItem:MovieItem
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("rating")]
        public decimal Rating { get; set; }
    }
}
