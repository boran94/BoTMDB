using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NameItem
    {
        /// <summary>
        /// Dil Adi
        /// </summary>

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Dil ingilizce adi
        /// </summary>

        [JsonPropertyName("english_name")]
        public string? EnglishName { get; set; }
    }
}
