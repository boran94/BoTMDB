using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.WatchProviders
{
    /// <summary>
    /// 
    /// </summary>
    public class RegionContainer
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("results")]
        public List<Regions> Results { get; set; } = new();
    }
}
