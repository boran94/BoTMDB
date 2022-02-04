using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Movies
{
    /// <summary>
    /// </summary>
    public class MovieWithAppend:Movie
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("alternative_titles")]
        public AlternativeTitlesForMedia? AlternativeTitles { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("changes")]
        public MediaChangeContainer? Changes { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("credits")]
        public MovieCredits? Credits { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("keywords")]
        public MovieKeywords? Keywords { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("external_ids")]
        public ExternalItem? ExternalIds { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("images")]
        public ImageContainer? Images { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("lists")]
        public MovieListContainer? Lists { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("releases")]
        public ReleaseDateContainer? Releases { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("reviews")]
        public MediaReview? Reviews { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("similar")]
        public MovieContainer? Similar { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("translations")]
        public MediaTranslationContainer? Translations { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("videos")]
        public VideoContainer? Videos { get; set; }
        
    }
}
