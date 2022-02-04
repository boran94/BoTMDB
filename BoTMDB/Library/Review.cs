using BoTMDB.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Library
{
    /// <summary>
    /// Film ve Tv Sovlarina dair yapilan incelemelere ait metodlarin bulundugu sinif
    /// Bu sinif icerisinde bulunan metodlar
    /// <list type="bullet">
    /// <item><see cref="GetDetails(string)"/></item>
    /// </list>
    /// <see href="https://developers.themoviedb.org/3/reviews"/>
    /// </summary>
    public class Review
    {
        private string ApiKey { get; set; }
        private string GetDetailsLink { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey">Api Key Degeri</param>
        public Review(string apiKey)
        {
            ApiKey = apiKey;
            GetDetailsLink = ApiLinks.Reviews.GetDetails.Replace("<<api_key>>", ApiKey);

        }

        #region Get Details
        /// <summary>
        /// Inceleme detaylarini donduren metod
        /// </summary>
        /// <param name="reviewId">Inceleme Id degeri</param>
        /// <returns></returns>
        public Response<ReviewContainer> GetDetails(string reviewId)
        {
            StringBuilder sb = new(GetDetailsLink);
            sb.Replace("{review_id}", reviewId);
            return Api.Get<ReviewContainer>(sb.ToString());
        }
        #endregion
    }
}
