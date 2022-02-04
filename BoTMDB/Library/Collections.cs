using BoTMDB.Models.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Library
{
    /// <summary>
    /// Seriler hakkindaki metotlarin tutuldugu sinif
    /// <list type="bullet">
    /// <item><see cref="GetDetails(int, string?)"/></item>
    /// <item><see cref="GetImages(int, string?)"/></item>
    /// <item><see cref="GetTranslations(int, string?)"/></item>
    /// </list>
    /// <see href="https://developers.themoviedb.org/3/collections"/>
    /// </summary>
    public class Collections
    {
        private string ApiKey { get; set; }
        private string GetDetailsLink { get; set; }
        private string GetImagesLink { get; set; }
        private string GetTranslationsLink { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey">Api Key Degeri</param>
        public Collections(string apiKey)
        {
            ApiKey = apiKey;


            GetDetailsLink = ApiLinks.Collections.GetDetails.Replace("<<api_key>>", ApiKey);
            GetImagesLink = ApiLinks.Collections.GetImages.Replace("<<api_key>>", ApiKey);
            GetTranslationsLink = ApiLinks.Collections.GetTranslations.Replace("<<api_key>>", ApiKey);
        }

        #region Get Details

        /// <summary>
        /// Seriye ait bilgileri getirmek icin kullanilan metod
        /// </summary>
        /// <param name="collectionId">Seri Id degeri</param>
        /// <param name="language">ISO 639-1 dil kodu</param>
        /// <returns></returns>
        public Response<CollectionContainer> GetDetails(int collectionId,string? language=null)
        {
            StringBuilder sb = new(GetDetailsLink);
            sb.Replace("<<collection_id>>", collectionId.ToString());
            if (!string.IsNullOrEmpty(language))
            {
                sb.Append("&language=");
                sb.Append(language);
            }
            return Api.Get<CollectionContainer>(sb.ToString());
        }

        #endregion

        #region Get Images
        /// <summary>
        /// Seriye ait goruntuleri getirmek icin kullanilan metod
        /// </summary>
        /// <param name="collectionId">Seri Id degeri</param>
        /// <param name="language">ISO 639-1 dil kodu</param>
        /// <returns></returns>
        public Response<ImageContainer> GetImages(int collectionId, string? language = null)
        {
            StringBuilder sb = new(GetImagesLink);
            sb.Replace("<<collection_id>>", collectionId.ToString());
            if (!string.IsNullOrEmpty(language))
            {
                sb.Append("&language=");
                sb.Append(language);
            }
            return Api.Get<ImageContainer>(sb.ToString());
        }

        #endregion

        #region Get Translations
        /// <summary>
        /// Seriye ait cevirileri getirmek icin kullanilan metod
        /// </summary>
        /// <param name="collectionId">Seri Id degeri</param>
        /// <param name="language">ISO 639-1 dil kodu</param>
        /// <returns></returns>
        public Response<TranslationContainer> GetTranslations(int collectionId, string? language = null)
        {
            StringBuilder sb = new(GetTranslationsLink);
            sb.Replace("<<collection_id>>", collectionId.ToString());
            if (!string.IsNullOrEmpty(language))
            {
                sb.Append("&language=");
                sb.Append(language);
            }
            return Api.Get<TranslationContainer>(sb.ToString());
        }


        #endregion
    }
}
