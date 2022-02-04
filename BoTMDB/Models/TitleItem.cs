using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models
{
    /// <summary>
    /// </summary>
    public class TitleItem
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("iso_3166_1")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }
}
