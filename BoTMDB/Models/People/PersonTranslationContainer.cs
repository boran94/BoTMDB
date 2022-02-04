using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.People
{
    /// <summary>
    /// </summary>
    public class PersonTranslationContainer:TranslationContainer<BiographyItem>
    {
    }
    /// <summary>
    /// </summary>
    public class BiographyItem
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("biography")]
        public string? Biography { get; set; }
    }
}
