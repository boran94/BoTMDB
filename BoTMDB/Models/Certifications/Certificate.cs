using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Certifications
{
    /// <summary>
    /// Sertifaka bilgilerinin tutuldugu sinif
    /// </summary>
    public class Certificate
    {
        /// <summary>
        /// Sertifika Kodu
        /// </summary>
        [JsonPropertyName("certification")]
        public string Certification { get; set; } = "";

        /// <summary>
        /// Sertifika Aciklamasi
        /// </summary>
        [JsonPropertyName("meaning")]
        public string Meaning { get; set; } = "";

        /// <summary>
        /// Sertifika sira numarasi
        /// </summary>
        [JsonPropertyName("order")]
        public int Order { get; set; }
    }
}
