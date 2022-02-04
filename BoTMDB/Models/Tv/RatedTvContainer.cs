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
    public class RatedTvContainer : ResultContainer<RatedTvItem>
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public class RatedTvItem:TvSummary
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("rating")]
        public decimal Rating { get; set; }
    }
}
