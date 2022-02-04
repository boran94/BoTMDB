﻿using BoTMDB.Models.Tv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.TvSeasons
{
    /// <summary>
    /// 
    /// </summary>
    public class TvSeasonWithAppend:TvSeason
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("changes")]
        public MediaChangeContainer? Changes { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("credits")]
        public TvCredits? Credits { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("external_ids")]
        public ExternalIdForSeasons? ExternalIds { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("images")]
        public ImageContainer? Images { get; set; }




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
