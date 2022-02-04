using BoTMDB.Models.WatchProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Library
{
    /// <summary>
    /// Izleme saglayicilari ile ilgili metodlarin bulundugu sinif
    /// <list type="bullet">
    /// <item><see cref="GetAvailableRegions(string?)"/></item>
    /// <item><see cref="GetMovieProviders(string?, string?)"/></item>
    /// <item><see cref="GetTVProviders(string?, string?)"/></item>
    /// </list>
    /// <see href="https://developers.themoviedb.org/3/watch-providers"/>
    /// </summary>
    public class WatchProviders
    {
        private string ApiKey { get; set; }
        private string GetAvailableRegionsLink { get; set; }
        private string GetMovieProvidersLink { get; set; }
        private string GetTVProvidersLink { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey">Api Key Degeri</param>
        public WatchProviders(string apiKey)
        {
            ApiKey = apiKey;
            GetAvailableRegionsLink = ApiLinks.WatchProviders.GetAvailableRegions.Replace("<<api_key>>", ApiKey);
            GetMovieProvidersLink = ApiLinks.WatchProviders.GetMovieProviders.Replace("<<api_key>>", ApiKey);
            GetTVProvidersLink = ApiLinks.WatchProviders.GetTVProviders.Replace("<<api_key>>", ApiKey);

        }
        #region Get Available Regions
        /// <summary>
        /// Ulkelerin sahip oldugu izleme saglayicilarini dondurmek icin kullanilan metod
        /// </summary>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<RegionContainer> GetAvailableRegions(string? language=null)
        {
            StringBuilder sb = new(GetAvailableRegionsLink);
            if (!string.IsNullOrEmpty(language))
            {
                sb.Append("&language=");
                sb.Append(language);
            }
            return Api.Get<RegionContainer>(sb.ToString()); 

        }
        #endregion

        private Response<MediaProviders> GetProviders(string apiLink,string? language=null,string? watchRegion = null)
        {
            StringBuilder sb = new(apiLink);
            if (!string.IsNullOrEmpty(language))
            {
                sb.Append("&language=");
                sb.Append(language);
            }
            if (!string.IsNullOrEmpty(watchRegion))
            {
                sb.Append("&watch_region=");
                sb.Append(watchRegion);
            }

            return Api.Get<MediaProviders>(sb.ToString());
            
        }

        #region Get Movie Providers

        /// <summary>
        /// Film Saglayicilarini donduren metod
        /// </summary>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="watchRegion">ISO 3166-1 Ulke Kodu</param>
        /// <returns></returns>
        public Response<MediaProviders> GetMovieProviders(string? language = null,string? watchRegion = null)
        {
            return GetProviders(GetMovieProvidersLink,language,watchRegion);
        }

        #endregion

        #region Get TV Providers
        /// <summary>
        /// Tv Sov Saglayicilarini donduren metod
        /// </summary>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="watchRegion">ISO 3166-1 Ulke Kodu</param>
        /// <returns></returns>
        public Response<MediaProviders> GetTVProviders(string? language = null, string? watchRegion = null)
        {
            return GetProviders(GetTVProvidersLink, language, watchRegion);
        }
        #endregion
    }
}
