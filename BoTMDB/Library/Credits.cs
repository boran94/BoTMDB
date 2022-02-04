using BoTMDB.Models.Credits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Library
{
    /// <summary>
    /// Jenerikler hakkinda bilgi almak icin kullanilan sinif
    /// <list type="bullet">
    /// <item><see cref="GetDetails(string)"/></item>
    /// </list>
    /// <see href="https://developers.themoviedb.org/3/credits"/>
    /// </summary>
    public class Credits
    {
        private string ApiKey { get; set; }

        private string GetDetailsLink { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey"></param>
        public Credits(string apiKey)
        {
            ApiKey = apiKey;
            GetDetailsLink = ApiLinks.Credits.GetDetails.Replace("<<api_key>>", ApiKey);

        }

        #region Get Details

        /// <summary>
        /// Film veya Tv Sovlari icin oyuncu ve rol alan kisiler hakkinda bilgi almak icin kullanilan metod
        /// </summary>
        /// <param name="creditId"></param>
        /// <returns></returns>
        public Response<CreditItem> GetDetails(string creditId)
        {
            StringBuilder sb = new(GetDetailsLink);
            sb.Replace("<<credit_id>>", creditId.ToString());
            return Api.Get<CreditItem>(sb.ToString());

        }
        #endregion
    }
}
