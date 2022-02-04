using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.WatchProviders
{
    /// <summary>
    /// Bolgelerin tutuldugu sinif
    /// </summary>
    public class Regions:CountryItem
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("native_name")]
        public string? Name { get; set; }
    }
}
