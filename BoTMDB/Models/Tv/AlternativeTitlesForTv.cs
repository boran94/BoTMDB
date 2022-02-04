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
    public class AlternativeTitlesForTv:AlternativeTitlesForMedia
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("results")]
        public List<TitleItem> Titles { get; set; } = new();
    }
}
