using BoTMDB.Models.Companies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Library
{
    /// <summary>
    /// Sirketlere ait bilgilere ulasmak icin kullanilan metodlarin bulundugu sinif
    /// <list type="bullet">
    /// <item><see cref="GetDetails(int)"/></item>
    /// <item><see cref="GetAlternativeNames(int)"/></item>
    /// <item><see cref="GetImages(int)"/></item>
    /// </list>
    /// <see href="https://developers.themoviedb.org/3/companies"/>
    /// </summary>
    public class Companies
    {
        private string ApiKey { get; set; }
        private string GetDetailsLink { get; set; }
        private string GetAlternativeNamesLink { get; set; }
        private string GetImagesLink { get; set; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey">Api Key Degeri</param>
        public Companies(string apiKey)
        {
            ApiKey = apiKey;
            GetDetailsLink = ApiLinks.Companies.GetDetails.Replace("<<api_key>>", ApiKey);
            GetAlternativeNamesLink = ApiLinks.Companies.GetAlternativeNames.Replace("<<api_key>>", ApiKey);
            GetImagesLink = ApiLinks.Companies.GetImages.Replace("<<api_key>>", ApiKey);
        }

        #region Get Details
        /// <summary>
        /// Sirkete ait bilgileri dondurmek icin kullanilan metod
        /// </summary>
        /// <param name="companyId">Sirket Id degeri</param>
        /// <returns></returns>
        public Response<CompanyItem> GetDetails(int companyId)
        {
            StringBuilder sb = new(GetDetailsLink);
            sb.Replace("<<company_id>>", companyId.ToString());
            return Api.Get<CompanyItem>(sb.ToString());

        }
        #endregion

        #region Get Alternative Names
        /// <summary>
        /// Sirkete ait alternatif isimleri donduren metod
        /// </summary>
        /// <param name="companyId">Sirket Id degeri</param>
        /// <returns></returns>
        public Response<CompanyAlternativeNames> GetAlternativeNames(int companyId)
        {
            StringBuilder sb = new(GetAlternativeNamesLink);
            sb.Replace("<<company_id>>", companyId.ToString());
            return Api.Get<CompanyAlternativeNames>(sb.ToString());

        }
        #endregion

        #region Get Images
        /// <summary>
        /// Sirkete ait resimlerin donduruldugu metod
        /// </summary>
        /// <param name="companyId">Sirket Id degeri</param>
        /// <returns></returns>
        public Response<CompanyLogos> GetImages(int companyId)
        {
            StringBuilder sb = new(GetImagesLink);
            sb.Replace("<<company_id>>", companyId.ToString());
            return Api.Get<CompanyLogos>(sb.ToString());
        }
        #endregion
    }
}
