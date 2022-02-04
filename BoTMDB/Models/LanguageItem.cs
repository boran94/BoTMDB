using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models
{
    /// <summary>
    /// ISO 639-1 Dil Kodu
    /// </summary>
    public class LanguageItem:NameItem
    {
        /// <summary>
        /// Dil Kodu
        /// </summary>
        [JsonPropertyName("iso_639_1")]
        public string? LanguageCode { get; set; }

       
    }
}
