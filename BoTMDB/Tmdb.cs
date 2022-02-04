using BoTMDB.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB
{
    /// <summary>
    /// Tmdb apisi icerisindeki tum bolumlerin bulundugu ana sinif
    /// </summary>
    public class Tmdb
    {
        private string ApiKey { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public Account Account { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Authentication Authentication { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Certifications Certifications { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Changes Changes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Collections Collections { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Companies Companies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Credits Credits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Discover Discover { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Find Find { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Genres Genres { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public GuestSessions GuestSessions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Keywords Keywords { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Lists Lists { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Movies Movies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Networks Networks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public People People { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Review Review { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Search Search { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Trending Trending { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Tv Tv { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public TvEpisodeGroups TvEpisodeGroups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public TvEpisodes TvEpisodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public TvSeasons TvSeasons { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public WatchProviders WatchProviders { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey">Api Key Degeri</param>
        public Tmdb(string apiKey)
        {
            ApiKey = apiKey;
            Account = new Account(ApiKey);
            Authentication = new Authentication(ApiKey);
            Certifications = new Certifications(ApiKey);
            Changes = new Changes(ApiKey);
            Collections = new Collections(ApiKey);
            Companies = new Companies(ApiKey);
            Configuration = new Configuration(ApiKey);
            Credits = new Credits(ApiKey);
            Discover = new Discover(ApiKey);
            Find = new Find(ApiKey);
            Genres = new Genres(ApiKey);
            GuestSessions = new GuestSessions(ApiKey);
            Keywords = new Keywords(ApiKey);
            Lists = new Lists(ApiKey);
            Movies = new Movies(ApiKey);
            Networks = new Networks(ApiKey);
            People = new People(ApiKey);
            Review = new Review(ApiKey);
            Search = new Search(ApiKey);
            Trending = new Trending(ApiKey);
            Tv = new Tv(ApiKey);
            TvEpisodeGroups = new TvEpisodeGroups(ApiKey);
            TvEpisodes = new TvEpisodes(ApiKey);
            TvSeasons = new TvSeasons(ApiKey);
            WatchProviders = new WatchProviders(ApiKey);

        }


        
    }
}
