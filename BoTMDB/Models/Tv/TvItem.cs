using BoTMDB.Models.Companies;
using BoTMDB.Models.Networks;
using BoTMDB.Models.TvEpisodes;
using BoTMDB.Models.TvSeasons;
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
    public class TvItem:MediaItem
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("created_by")]
        public List<CreatedByItem> CreatedBy { get; set; } = new();

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("episode_run_time")]
        public List<int> EpisodeRunTime { get; set; } = new();


        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("first_air_date")]
        public string? ReleaseDate { get; set; }



        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("homepage")]
        public string? Homepage { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("in_production")]
        public bool InProduction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("languages")]
        public List<string> Languages { get; set; }=new();

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("last_air_date")]
        public string? LastAirDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("last_episode_to_air")]
        public Episode? LastEpisodeToAir { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("name")]
        public string? NameOrTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("networks")]
        public List<NetworkItem> Networks { get; set; } = new();

        /// <summary>
        /// </summary>
        [JsonPropertyName("number_of_episodes")]
        public int NumberOfEpisodes { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("number_of_seasons")]
        public int NumberOfSeasons { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("origin_country")]
        public List<string> OriginCountry { get; set; } = new();

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("original_name")]
        public string? OriginalNameOrTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("production_companies")]
        public List<CompanyItem> ProductionCompanies { get; set; } = new();


        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("production_countries")]
        public List<CountryItem> ProductionCountries { get; set; } = new();


        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("seasons")]
        public List<Season> Seasons { get; set; } = new();

        /// <summary>
        /// 
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


        /// <summary>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

    }
}
