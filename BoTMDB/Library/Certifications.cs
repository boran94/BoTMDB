using BoTMDB.Models.Certifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Library
{
    /// <summary>
    /// TMDB'de resmi olarak desteklenen film ve Tv sovlarina ait sertifikalarin listesini almak icin kullanilan sinif
    /// Bu sinif icerisinde bulunan metodlar
    /// <list type="bullet">
    /// <item><see cref="GetMovieCertifications"/></item>
    /// <item><see cref="GetTVCertifications"/></item>
    /// </list>
    /// <see href="https://developers.themoviedb.org/3/certifications"/>
    /// </summary>
    public class Certifications
    {

        private string GetMovieCertificationsLink { get; set; }
        private string GetTVCertificationsLink { get; set; }
        private string ApiKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey">TMDB Api Anahtari</param>
        public Certifications(string apiKey)
        {
            ApiKey = apiKey;
            GetMovieCertificationsLink = ApiLinks.Certifications.GetMovieCertifications.Replace("<<api_key>>", ApiKey);
            GetTVCertificationsLink = ApiLinks.Certifications.GetTVCertifications.Replace("<<api_key>>", ApiKey);


        }

        #region Get Movie Certifications
        /// <summary>
        /// TMDB'de resmi olarak desteklenen film sertifikalarinin guncel listesini almak icin kullanilan metod
        /// </summary>
        /// <returns></returns>
        public Response<Certificates> GetMovieCertifications()
        {
            return Api.Get<Certificates>(GetMovieCertificationsLink);
        }
        #endregion

        #region Get TV Certifications
        /// <summary>
        /// TMDB'de resmi olarak desteklenen Tv Sov sertifikalarinin guncel listesini almak icin kullanilan metod
        /// </summary>
        /// <returns></returns>
        public Response<Certificates> GetTVCertifications()
        {
            return Api.Get<Certificates>(GetTVCertificationsLink);
        }
        #endregion
    }
}
