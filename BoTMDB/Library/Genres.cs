using BoTMDB.Models.Genres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Library
{
    /// <summary>
    /// Film ve Tv Sovlari icin Tur listelerini almak icin kullanilan metodlarin bulundugu sinif
    /// Bu sinif icerisinde bulunan metodlar
    /// <list type="bullet">
    /// <item><see cref="GetMovieList(string?)"/></item>
    /// <item><see cref="GetTVList(string?)"/></item>
    /// </list>
    /// <see href="https://developers.themoviedb.org/3/genres"/>
    /// </summary>
    public class Genres
    {
        private string ApiKey { get; set; }
        private string GetMovieListLink { get; set; }
        private string GetTVListLink { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey">Api Key Degeri</param>
        public Genres(string apiKey)
        {
            ApiKey = apiKey;
            GetMovieListLink = ApiLinks.Genres.GetMovieList.Replace("<<api_key>>", ApiKey);
            GetTVListLink = ApiLinks.Genres.GetTVList.Replace("<<api_key>>", ApiKey);

        }

        private Response<GenreList> GetGenres(string link,string? language)
        {
            StringBuilder sb = new(link);
            if (!string.IsNullOrEmpty(language))
            {
                sb.Append("&language=");
                sb.Append(language);
            }
            Response<GenreList> response = Api.Get<GenreList>(sb.ToString());
            //if (genres.Data is not null)
            //    response.Data.Genres.AddRange(genres.Data);
            return response;
        }

        #region Get Movie List
        /// <summary>
        /// Filmlere ait tur listesini donduren metod
        /// </summary>
        /// <param name="language">ISO 639-1 Dil kodu</param>
        /// <returns></returns>
        public Response<GenreList> GetMovieList(string? language = null)
        {
            
            return GetGenres(GetMovieListLink,language);
        }
        #endregion

        #region Get TV List
        /// <summary>
        /// Tv sovlarina ait tur listesini donduren metod
        /// </summary>
        /// <param name="language">ISO 639-1 Dil kodu</param>
        /// <returns></returns>
        public Response<GenreList> GetTVList(string? language = null)
        {
            return GetGenres(GetTVListLink, language);
        }
        #endregion


    }
}
