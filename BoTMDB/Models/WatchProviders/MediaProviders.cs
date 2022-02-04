using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.WatchProviders
{
    /// <summary>
    /// Film ve Tv Sovlari icin izleme saglayicilarinin tutuldugu sinif
    /// </summary>
    public class MediaProviders
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("results")]
        public List<ProviderItem> Results { get; set; } = new();
    }
}
