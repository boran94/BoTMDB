using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Tv
{
    /// <summary>
    /// 
    /// </summary>
    public class TvSummary:MediaItem
    {

        /// <summary>
        /// Ilk Yayin Tarihi
        /// </summary>

        [JsonPropertyName("first_air_date")]
        public string? ReleaseDate { get; set; }

        /// <summary>
        /// </summary>

        [JsonPropertyName("origin_country")]
        public List<string> OriginCountry { get; set; } = new();


        /// <summary>
        /// Baslik
        /// </summary>

        [JsonPropertyName("name")]
        public string? NameOrTitle { get; set; }

    }
}
