using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models
{

    /// <summary>
    /// ISO 3166-1 Ulke kodu
    /// </summary>
    public class CountryItem: NameItem
    {
        /// <summary>
        /// Ulke Kodu
        /// </summary>
        [JsonPropertyName("iso_3166_1")]
        public string? CountryCode { get; set; }

       
    }
}
