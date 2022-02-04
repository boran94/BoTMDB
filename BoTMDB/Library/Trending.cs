using BoTMDB.Models.Movies;
using BoTMDB.Models.People;
using BoTMDB.Models.Trending;
using BoTMDB.Models.Tv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Library
{
    /// <summary>
    /// Trend olan film,kisi ve Tv Sovlari icin kullanilan sinif
    /// Bu sinif icerisinde bulunan metodlar
    /// <list type="bullet">
    /// <item><see cref="GetTrendingForMovie(TimeWindow, int?, string?)"/></item>
    /// <item><see cref="GetTrendingForPerson(TimeWindow, int?, string?)"/></item>
    /// <item><see cref="GetTrendingForTv(TimeWindow, int?, string?)"/></item>
    /// </list>
    /// Detaylı Bilgi için : <see href="https://developers.themoviedb.org/3/trending"/>
    /// </summary>
    public class Trending
    {
        private string ApiKey { get; set; }
        private string GetTrendingLink { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey">Api Key Degeri</param>
        public Trending(string apiKey)
        {
            ApiKey = apiKey;
            GetTrendingLink = ApiLinks.Trending.GetTrending.Replace("<<api_key>>", ApiKey);

        }

        #region Get Trending
        /// <summary>
        /// Trend olan filmleri donduren metod
        /// </summary>
        /// <param name="timeWindow">Zaman Araligi</param>
        /// <param name="page">Sayfa Sayisi</param>
        /// <param name="language">IS0 639-1 Dil Kodu</param>
        /// <returns></returns>

        public Response<MovieContainer> GetTrendingForMovie(TimeWindow timeWindow=TimeWindow.Day,int? page=null, string? language = null)
        {
            StringBuilder sb=new(GetTrendingLink);
            sb.Replace("<<media_type>>", "movie");
            if (timeWindow.Equals(TimeWindow.Day))
                sb.Replace("<<time_window>>", "day");
            else
                sb.Replace("<<time_window>>", "week");
            if (page.HasValue)
            {
                sb.Append("&page=");
                sb.Append(page);
            }
            if (!string.IsNullOrEmpty(language))
            {
                sb.Append("&language=");
                sb.Append(language);
            }
            return Api.Get<MovieContainer>(sb.ToString());
        }
        /// <summary>
        /// Trend olan Tv Sovlari donduren metod
        /// </summary>
        /// <param name="timeWindow">Zaman Araligi</param>
        /// <param name="page">Sayfa Sayisi</param>
        /// <param name="language">IS0 639-1 Dil Kodu</param>
        /// <returns></returns>

        public Response<TvContainer> GetTrendingForTv(TimeWindow timeWindow = TimeWindow.Day, int? page = null, string? language = null)
        {
            StringBuilder sb = new(GetTrendingLink);
            sb.Replace("<<media_type>>", "tv");
            if (timeWindow.Equals(TimeWindow.Day))
                sb.Replace("<<time_window>>", "day");
            else
                sb.Replace("<<time_window>>", "week");
            if (page.HasValue)
            {
                sb.Append("&page=");
                sb.Append(page);
            }
            if (!string.IsNullOrEmpty(language))
            {
                sb.Append("&language=");
                sb.Append(language);
            }
            return Api.Get<TvContainer>(sb.ToString());
        }
        /// <summary>
        /// Trend olan kisileri donduren metod
        /// </summary>
        /// <param name="timeWindow">Zaman Araligi</param>
        /// <param name="page">Sayfa Sayisi</param>
        /// <param name="language">IS0 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<ObjectContainer> GetTrendingForPerson(TimeWindow timeWindow = TimeWindow.Day, int? page = null,string? language=null)
        {
            StringBuilder sb = new(GetTrendingLink);
            sb.Replace("<<media_type>>", "person");
            if (timeWindow.Equals(TimeWindow.Day))
                sb.Replace("<<time_window>>", "day");
            else
                sb.Replace("<<time_window>>", "week");
            if (page.HasValue)
            {
                sb.Append("&page=");
                sb.Append(page);
            }
            if (!string.IsNullOrEmpty(language))
            {
                sb.Append("&language=");
                sb.Append(language);
            }
            return Api.Get<ObjectContainer>(sb.ToString());
        }
        #endregion
    }
}
