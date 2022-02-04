using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Collections
{
    /// <summary>
    /// Ceviri bilgilerinin tutuldugu sinif
    /// </summary>
    public class TranslationItem:LanguageItem
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("iso_3166_1")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("data")]
        public TranslationData? Data { get; set; }
    }
    /// <summary>
    /// Ceviri icerisinde bulunan veriyi tutmak icin olusturulan sinif
    /// </summary>
    public class TranslationData
    {

        /// <summary>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("overview")]
        public string? Overview { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("homepage")]
        public string? Homepage { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("biography")]
        public string? Biography { get; set; }
    }
}
