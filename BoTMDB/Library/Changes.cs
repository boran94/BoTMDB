using BoTMDB.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Library
{
    /// <summary>
    /// TMDB'de Film,Tv Sovlari ve Kisiler hakkinda yapilan degisiklikleri almak icin kullanilan metodlarin bulundugu sinif
    /// Bu sinif icerisinde bulunan metodlar
    /// <list type="bullet">
    /// <item><see cref="GetMovieChangeList(DateTime?, DateTime?, int?)"/></item>
    /// <item><see cref="GetTVChangeList(DateTime?, DateTime?, int?)"/></item>
    /// <item><see cref="GetPersonChangeList(DateTime?, DateTime?, int?)"/></item>
    /// </list>
    /// <see href="https://developers.themoviedb.org/3/certifications"/>
    /// </summary>
    public class Changes
    {
        private string ApiKey { get; set; }
        private string GetMovieChangeListLink { get; set; }
        private string GetTVChangeListLink { get; set; }
        private string GetPersonChangeListLink { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey">Api Key Degeri</param>
        public Changes(string apiKey)
        {
            ApiKey = apiKey;
            GetMovieChangeListLink = ApiLinks.Changes.GetMovieChangeList.Replace("<<api_key>>", ApiKey);
            GetTVChangeListLink = ApiLinks.Changes.GetTVChangeList.Replace("<<api_key>>", ApiKey);
            GetPersonChangeListLink = ApiLinks.Changes.GetPersonChangeList.Replace("<<api_key>>", ApiKey);

        }

        /// <summary>
        /// Degisiklileri almak icin kullanilan ana metod
        /// </summary>
        /// <param name="apilink"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        private Response<ChangeContainer> GetChangeList(string apilink,DateTime? startDate = null, DateTime? endDate = null, int? page = null)
        {
            StringBuilder sb = new(apilink);
            if (startDate.HasValue)
            {
                sb.Append("&start_date=");
                sb.Append(Uri.EscapeDataString(startDate.Value.ToString("yyyy-MM-dd HH:mm:ss")));
            }
            if (endDate.HasValue)
            {
                sb.Append("&end_date=");
                sb.Append(Uri.EscapeDataString(endDate.Value.ToString("yyyy-MM-dd HH:mm:ss")));
            }
            if (page.HasValue)
            {
                sb.Append("&page=");
                sb.Append(page);
            }
            return Api.Get<ChangeContainer>(sb.ToString());
        }

        #region Get Movie Change List

        /// <summary>
        /// Filmlerde yapilmis olan degisiklikleri dondurmek icin kullanilan metod.
        /// Baslangic ve bitis tarihi arasinda maksimum 14 gunluk verileri dondurur
        /// </summary>
        /// <param name="startDate">Baslangic Tarihi</param>
        /// <param name="endDate">Bitis Tarihi</param>
        /// <param name="page">Sayfa Sayisi</param>
        /// <returns></returns>
        public Response<ChangeContainer> GetMovieChangeList(DateTime? startDate=null,DateTime? endDate = null, int? page = null)
        {
            return GetChangeList(GetMovieChangeListLink, startDate, endDate, page);
        }

        #endregion

        #region Get TV  Change List
        /// <summary>
        /// Tv Sovlarinda yapilmis olan degisiklikleri dondurmek icin kullanilan metod.
        /// Baslangic ve bitis tarihi arasinda maksimum 14 gunluk verileri dondurur
        /// </summary>
        /// <param name="startDate">Baslangic Tarihi</param>
        /// <param name="endDate">Bitis Tarihi</param>
        /// <param name="page">Sayfa Sayisi</param>
        /// <returns></returns>
        public Response<ChangeContainer> GetTVChangeList(DateTime? startDate = null, DateTime? endDate = null, int? page = null)
        {
            return GetChangeList(GetTVChangeListLink, startDate, endDate, page);
        }

        #endregion

        #region Get Person Change List
        /// <summary>
        /// Kisilerde yapilmis olan degisiklikleri dondurmek icin kullanilan metod.
        /// Baslangic ve bitis tarihi arasinda maksimum 14 gunluk verileri dondurur
        /// </summary>
        /// <param name="startDate">Baslangic Tarihi</param>
        /// <param name="endDate">Bitis Tarihi</param>
        /// <param name="page">Sayfa Sayisi</param>
        /// <returns></returns>
        public Response<ChangeContainer> GetPersonChangeList(DateTime? startDate = null, DateTime? endDate = null, int? page = null)
        {
            return GetChangeList(GetPersonChangeListLink, startDate, endDate, page);
        }

        #endregion

    }
}
