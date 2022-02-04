using BoTMDB.Models.Networks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Library
{
    /// <summary>
    /// Online saglayicilari ile ilgili metodlarin bulundugu sinif
    /// Bu sinif icerisinde bulunan metodlar
    /// <list type="bullet">
    /// <item><see cref="GetDetails(int)"/></item>
    /// <item><see cref="GetAlternativeNames(int)"/></item>
    /// <item><see cref="GetImages(int)"/></item>
    /// </list>
    /// <see href="https://developers.themoviedb.org/3/networks"/>
    /// </summary>
    public class Networks
    {
        private string ApiKey { get; set; }
        private string GetAlternativeNamesLink { get; set; }
        private string GetDetailsLink { get; set; }
        private string GetImagesLink { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey">Api Key Degeri</param>
        public Networks(string apiKey)
        {
            ApiKey = apiKey;
            GetDetailsLink = ApiLinks.Networks.GetDetails.Replace("<<api_key>>", ApiKey);
            GetAlternativeNamesLink = ApiLinks.Networks.GetAlternativeNames.Replace("<<api_key>>", ApiKey);
            GetImagesLink = ApiLinks.Networks.GetImages.Replace("<<api_key>>", ApiKey);

        }

        #region Get Details
        /// <summary>
        /// Online izleme saglayicilari hakkinda bilgi almak icin kullanilan metod
        /// </summary>
        /// <param name="networkId">Network Id degeri</param>
        /// <returns></returns>
        public Response<NetworkItem> GetDetails(int networkId)
        {
            StringBuilder sb = new(GetDetailsLink);
            sb.Replace("{network_id}", networkId.ToString());
            return Api.Get<NetworkItem>(sb.ToString());
        }
        #endregion

        #region Get Alternative Names
        /// <summary>
        /// Online izleme saglayicisinin alternatif isimlerini donduren metod
        /// </summary>
        /// <param name="networkId">Network Id degeri</param>
        /// <returns></returns>
        public Response<NetworkAlternativeName> GetAlternativeNames(int networkId)
        {
            StringBuilder sb = new(GetAlternativeNamesLink);
            sb.Replace("{network_id}", networkId.ToString());
            return Api.Get<NetworkAlternativeName>(sb.ToString());
        }
        #endregion

        #region Get Images
        /// <summary>
        /// Online izleme saglayicisina ait logolari donduren metod
        /// </summary>
        /// <param name="networkId">Network Id degeri</param>
        /// <returns></returns>
        public Response<NetworkImages> GetImages(int networkId)
        {
            StringBuilder sb = new(GetImagesLink);
            sb.Replace("{network_id}", networkId.ToString());
            return Api.Get<NetworkImages>(sb.ToString());
        }
        #endregion
    }
}
