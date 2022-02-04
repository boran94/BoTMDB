using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models
{
    /// <summary>
    /// </summary>
    public class TranslationContainer<T>
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("translations")]
        public List<TranslationItem<T>> Translations { get; set; } = new();
    }
    /// <summary>
    /// </summary>
    public class TranslationItem<T>:LanguageItem
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("iso_3166_1")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("data")]
        public T? Data { get; set; }
    }
}
