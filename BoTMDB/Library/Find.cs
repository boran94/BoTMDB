using BoTMDB.Models.Find;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Library
{
    /// <summary>
    /// Arama yapmak icin kullanilan sinif
    /// Bu sinif icerisinde bulunan metodlar
    /// <list type="bullet">
    /// <item><see cref="FindById(string, ExternalSourceIds, string?)"/></item>
    /// </list>
    /// <see href="https://developers.themoviedb.org/3/find"/>
    /// </summary>
    public class Find
    {
        private string ApiKey { get; set; }
        private string FindByIDLink { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey"></param>
        public Find(string apiKey)
        {
            ApiKey = apiKey;
            FindByIDLink = ApiLinks.Find.FindByID.Replace("<<api_key>>", ApiKey);

        }

        #region Find By ID
        /// <summary>
        /// Dis Id degerinden arama yapmak icin kullanilan metod
        /// </summary>
        /// <param name="externalId">Dis Id degeri</param>
        /// <param name="externalSource">Dis kaynak</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<FindContainer> FindById(string externalId, ExternalSourceIds externalSource ,string ? language=null)
        {
            StringBuilder sb = new(FindByIDLink);
            sb.Replace("{external_id}", externalId);

            if (!string.IsNullOrEmpty(language))
            {
                sb.Append("&language=");
                sb.Append(language);
            }
            sb.Append("&external_source=");
            switch (externalSource)
            {
                case ExternalSourceIds.ImdbId:
                    sb.Append("imdb_id");
                    break;
                case ExternalSourceIds.FreebaseMid:
                    sb.Append("freebase_mid");
                    break;
                case ExternalSourceIds.FreebaseId:
                    sb.Append("freebase_id");

                    break;
                case ExternalSourceIds.TvdbId:
                    sb.Append("tvdb_id");

                    break;
                case ExternalSourceIds.TvrageId:
                    sb.Append("tvrage_id");

                    break;
                case ExternalSourceIds.FacebookId:
                    sb.Append("facebook_id");

                    break;
                case ExternalSourceIds.TwitterId:
                    sb.Append("twitter_id");
                    break;
                case ExternalSourceIds.InstagramId:
                    sb.Append("instagram_id");
                    break;
                default:
                    break;
            }
            return Api.Get<FindContainer>(sb.ToString());


        }
        #endregion
    }
}
