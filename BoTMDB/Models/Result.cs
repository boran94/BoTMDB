using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models
{
    /// <summary>
    /// Sonuclarin tutuldugu sinif
    /// </summary>
    /// <typeparam name="T">Generic sinif</typeparam>
    public class Result<T>
    {
        /// <summary>
        /// Sonuclarin tutuldugu property
        /// </summary>
        [JsonPropertyName("results")]
        public List<T> Results { get; set; } = new();

        /// <summary>
        /// Sayfa numarasi
        /// </summary>
        [JsonPropertyName("page")]
        public int Page { get; set; }

        /// <summary>
        /// Toplam sayfa sayisi
        /// </summary>
        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        /// <summary>
        /// Toplam Sonuc sayisi
        /// </summary>

        [JsonPropertyName("total_results")]
        public int TotalResults { get; set; }
    }
}
