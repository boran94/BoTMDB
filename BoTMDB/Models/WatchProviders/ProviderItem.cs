using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.WatchProviders
{
    /// <summary>
    /// Izleme saglayicilarinin tutuldugu sinif
    /// </summary>
    public class ProviderItem
    {
        /// <summary>
        /// Oncelik sirasi
        /// </summary>
        [JsonPropertyName("display_priority")]
        public int DisplayPriority { get; set; }

        /// <summary>
        /// Logo goruntusunun yolu
        /// </summary>
        [JsonPropertyName("logo_path")]
        public string? LogoPath { get; set; }

        /// <summary>
        /// Saglayici adi
        /// </summary>
        [JsonPropertyName("provider_name")]
        public string? ProviderName { get; set; }

        /// <summary>
        /// Saglayici Id degeri
        /// </summary>
        [JsonPropertyName("provider_id")]
        public int ProviderId { get; set; }
    }
}
