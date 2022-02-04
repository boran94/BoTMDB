using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Credits
{
    /// <summary>
    /// Cast verilerinin tutuldugu temel sinif
    /// </summary>
    public class CastBase
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("adult")]
        public bool Adult { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("name")]
        public string? NameOrTitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("original_name")]
        public string? OriginalNameOrTitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("popularity")]
        public decimal Popularity { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("character")]
        public string? Character { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("credit_id")]
        public string? CreditId { get; set; }

    }
}
