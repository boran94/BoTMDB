using BoTMDB.Models.Collections;
using BoTMDB.Models.Networks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Movies
{
    /// <summary>
    /// Film verilerinin tutmak icin kullanilan sinif
    /// </summary>
    public class Movie:MovieItem
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("belongs_to_collection")]
        public CollectionContainer? BelongsToCollection { get; set; }

        /// <summary>
        /// </summary>

        [JsonPropertyName("budget")]
        public decimal Budget { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("genres")]
        public List<IdName> Genres { get; set; } = new();

        /// <summary>
        /// </summary>
        [JsonPropertyName("homepage")]
        public string? Homepage { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("imdb_id")]
        public string? ImdbId { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("production_companies")]
        public List<NetworkItem> ProductionCompanies { get; set; } = new();

        /// <summary>
        /// </summary>
        [JsonPropertyName("production_countries")]
        public List<CountryItem> ProductionCountries { get; set; } = new();

        /// <summary>
        /// </summary>
        [JsonPropertyName("revenue")]
        public int? Revenue { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("runtime")]
        public int? Runtime { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("spoken_languages")]
        public List<LanguageItem> SpokenLanguages { get; set; } = new();

        /// <summary>
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }



        /// <summary>
        /// </summary>
        [JsonPropertyName("tagline")]
        public string? Tagline { get; set; }
        

    }
}
