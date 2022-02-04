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
    public class TvWithAppend:TvItem
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("alternative_titles")]
        public AlternativeTitlesForTv? AlternativeTitles { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("changes")]
        public MediaChangeContainer? Changes { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("content_ratings")]
        public ContentRating? ContentRatings { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("credits")]
        public TvCredits? Credits { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("keywords")]
        public TvKeywords? Keywords { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("external_ids")]
        public ExternalIdsForTv? ExternalIds { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("images")]
        public ImageContainer? Images { get; set; }



        /// <summary>
        /// </summary>
        [JsonPropertyName("reviews")]
        public MediaReview? Reviews { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("similar")]
        public TvContainer? Similar { get; set; }


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
