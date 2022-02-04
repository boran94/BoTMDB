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
    public class MediaTranslationContainer : TranslationContainer<MediaTranslationData>
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public class MediaTranslationData
    {

        /// <summary>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("overview")]
        public string? Overview { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("homepage")]
        public string? Homepage { get; set; }
        

    }
}
