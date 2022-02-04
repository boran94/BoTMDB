using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Configuration
{
    /// <summary>
    /// Ulke ve ulkeye ait zaman dilimlerinin tutuldugu liste
    /// </summary>
    public class Timezone
    {

        /// <summary>
        /// ISO 3166-1 ulke kodu
        /// </summary>
        [JsonPropertyName("iso_3166_1")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// Zaman dilimlerinin tutuldugu liste
        /// </summary>
        [JsonPropertyName("zones")]
        public List<string> Zones { get; set; } = new();
    }
}
