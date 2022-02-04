using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Networks
{
    /// <summary>
    /// Yayin saglayici verilerinin tutuldugu sinif
    /// </summary>
    public class NetworkItem
    {
        /// <summary>
        /// Sirketin merkez ussu
        /// </summary>
        [JsonPropertyName("headquarters")]
        public string? Headquarters { get; set; }

        /// <summary>
        /// Sirketin anasayfa linki
        /// </summary>

        [JsonPropertyName("homepage")]
        public string? Homepage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }


        /// <summary>
        /// Logo Resmi
        /// </summary>
        [JsonPropertyName("logo_path")]
        public string? LogoPath { get; set; }

        /// <summary>
        /// Sirket adi
        /// </summary>

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Merkez sehri
        /// </summary>

        [JsonPropertyName("origin_country")]
        public string? OriginCountry { get; set; }

    }
}
