using BoTMDB.Models;
using BoTMDB.Models.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Library
{
    /// <summary>
    /// Anahtar kelimelerle ilgili metodlarin bulundugu sinif
    /// Bu sinif icerisinde bulunan metodlar
    /// <list type="bullet">
    /// <item><see cref="GetDetails(int)"/></item>
    /// <item><see cref="GetMovies(int, string?, bool?, int?)"/></item>
    /// </list>
    /// <see href="https://developers.themoviedb.org/3/keywords"/>
    /// </summary>
    public class Keywords
    {
        private string ApiKey { get; set; }
        private string GetDetailsLink { get; set; }
        private string GetMoviesLink { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey">Api Key Degeri</param>
        public Keywords(string apiKey)
        {
            ApiKey = apiKey;
            GetDetailsLink = ApiLinks.Keywords.GetDetails.Replace("<<api_key>>", ApiKey);
            GetMoviesLink = ApiLinks.Keywords.GetMovies.Replace("<<api_key>>", ApiKey);
        }

        #region Get Details
        /// <summary>
        /// Id degeri verilen anahtar kelimenin adini donduren metod
        /// </summary>
        /// <param name="keywordId">Anahtar kelime Id degeri</param>
        /// <returns></returns>
        public Response<IdName> GetDetails(int keywordId)
        {
            StringBuilder sb = new(GetDetailsLink);
            sb.Replace("{keyword_id}", keywordId.ToString());
            return Api.Get<IdName>(sb.ToString());
        }
        #endregion


        #region Get Movies


        /// <summary>
        /// 
        /// </summary>
        /// <param name="keywordId">Anahtar kelime Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="includeAdult">Yetiskin filmleri dahil olmasi icin true, olmamasi icin false degerini gonderebilirsiniz</param>
        /// <param name="page">Sayfa sayisi</param>
        /// <returns></returns>
        public Response<MovieContainer> GetMovies(int keywordId,string? language=null,bool? includeAdult = null,int? page=null)
        {
            StringBuilder sb = new(GetMoviesLink);
            sb.Replace("{keyword_id}", keywordId.ToString());
            sb.Append("&language=");
            sb.Append(language);
            if (page.HasValue)
            {
                sb.Append("&page=");
                sb.Append(page.Value);
            }
            if (includeAdult.HasValue)
            {
                sb.Append("&include_adult=");
                sb.Append(includeAdult.Value.ToString().ToLower());
            }
            return Api.Get<MovieContainer>(sb.ToString());
        }
        #endregion
    }
}
