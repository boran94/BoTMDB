using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Collections
{
    /// <summary>
    /// Cevirilerin tutuldugu sinif
    /// </summary>
    public class TranslationContainer
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Cevirilerin tutuldugu liste
        /// </summary>

        [JsonPropertyName("translations")]
        public List<TranslationItem> Translations { get; set; } =new List<TranslationItem>();
    }
}
