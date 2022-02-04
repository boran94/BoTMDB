using BoTMDB.Models.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Library
{
    /// <summary>
    /// Kisilerle ilgili metodlarin bulundugu sinif
    /// Bu sinif icerisinde bulunan metodlar
    /// <list type="bullet">
    /// <item><see cref="GetDetails(int, string?)"/></item>
    /// <item><see cref="GetDetailsWithAppend(int, string?, string?)"/></item>
    /// <item><see cref="GetChanges(int, DateTime?, DateTime?, int?)"/></item>
    /// <item><see cref="GetMovieCredits(int, string?)"/></item>
    /// <item><see cref="GetTVCredits(int, string?)"/></item>
    /// <item><see cref="GetCombinedCredits(int, string?)"/></item>
    /// <item><see cref="GetExternalIDs(int, string?)"/></item>
    /// <item><see cref="GetImages(int)"/></item>
    /// <item><see cref="GetTaggedImages(int, string?, int?)"/></item>
    /// <item><see cref="GetTranslations(int, string?)"/></item>
    /// <item><see cref="GetLatest(string?)"/></item>
    /// <item><see cref="GetPopular(string?, int?)"/></item>
    /// </list>
    /// <see href="https://developers.themoviedb.org/3/people"/>
    /// </summary>
    public class People
    {
        private string ApiKey { get; set; }
        private string GetDetailsLink { get; set; }
        private string GetChangesLink { get; set; }
        private string GetMovieCreditsLink { get; set; }
        private string GetTVCreditsLink { get; set; }
        private string GetCombinedCreditsLink { get; set; }
        private string GetExternalIDsLink { get; set; }
        private string GetImagesLink { get; set; }
        private string GetTaggedImagesLink { get; set; }
        private string GetTranslationsLink { get; set; }
        private string GetLatestLink { get; set; }
        private string GetPopularLink { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey">Api Key Degeri</param>
        public People(string apiKey)
        {
            ApiKey = apiKey;
            GetDetailsLink = ApiLinks.People.GetDetails.Replace("<<api_key>>", ApiKey);
            GetChangesLink = ApiLinks.People.GetChanges.Replace("<<api_key>>", ApiKey);
            GetMovieCreditsLink = ApiLinks.People.GetMovieCredits.Replace("<<api_key>>", ApiKey);
            GetTVCreditsLink = ApiLinks.People.GetTVCredits.Replace("<<api_key>>", ApiKey);
            GetCombinedCreditsLink = ApiLinks.People.GetCombinedCredits.Replace("<<api_key>>", ApiKey);
            GetExternalIDsLink = ApiLinks.People.GetExternalIDs.Replace("<<api_key>>", ApiKey);
            GetImagesLink = ApiLinks.People.GetImages.Replace("<<api_key>>", ApiKey);
            GetTaggedImagesLink = ApiLinks.People.GetTaggedImages.Replace("<<api_key>>", ApiKey);
            GetTranslationsLink = ApiLinks.People.GetTranslations.Replace("<<api_key>>", ApiKey);
            GetLatestLink = ApiLinks.People.GetLatest.Replace("<<api_key>>", ApiKey);
            GetPopularLink = ApiLinks.People.GetPopular.Replace("<<api_key>>", ApiKey);
        }

        #region Get Details

        /// <summary>
        /// Kisi hakkindaki detayli bilgi almak icin kullanilan metod
        /// </summary>
        /// <param name="personId">Kisi Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<Person> GetDetails(int personId,string? language=null)
        {

            StringBuilder sb = new(GetDetailsLink);
            sb.Replace("{person_id}", personId.ToString());
            if (sb is not null)
            {
                if (!string.IsNullOrEmpty(language))
                {
                    sb.Append("&language=");
                    sb.Append(language);
                }
            }
            if (sb is null)
                sb = new(GetDetailsLink);
            return Api.Get<Person>(sb.ToString());
        }
        /// <summary>
        /// Kisi hakkindaki detayli bilgi almak icin kullanilan metod. <paramref name="appendToResponse"/> kullanilarak birden fazla sorgu cekilebilir
        /// </summary>
        /// <param name="personId">Kisi Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="appendToResponse">Kisi ile birlikte video,resim, dis id degerleri gibi degerleri getirmek icin kullanilir</param>
        /// <returns></returns>
        public Response<PersonWithAppend> GetDetailsWithAppend(int personId, string? language = null,string? appendToResponse=null)
        {

            StringBuilder sb = new(GetDetailsLink);
            sb.Replace("{person_id}", personId.ToString());
            if (sb is not null)
            {
                if (!string.IsNullOrEmpty(language))
                {
                    sb.Append("&language=");
                    sb.Append(language);
                }
                if (!string.IsNullOrEmpty(appendToResponse))
                {
                    sb.Append("&append_to_response=");
                    sb.Append(Uri.EscapeDataString(appendToResponse));
                }
            }
            if (sb is null)
                sb = new(GetDetailsLink);
            return Api.Get<PersonWithAppend>(sb.ToString());
        }
        #endregion


        #region Get Changes

        /// <summary>
        /// Kisi uzerinde yapilmis olan degisiklikleri dondurmek icin kullanilan metod.
        /// Tarih araligi verilmezse son 24 saat icerisinde yapilmis olan degisiklikleri dondurur.
        /// Tek bir sorguda maksimum 14 gun araligindaki degisiklikleri sorgulayabilirsiniz
        /// </summary>
        /// <param name="personId">Kisi Id degeri</param>
        /// <param name="startDate">Baslangic Tarihi</param>
        /// <param name="endDate">Bitis Tarihi</param>
        /// <param name="page">Sayfa Sayisi</param>
        /// <returns></returns>
        public Response<PersonChangeContainer> GetChanges(int personId,DateTime? startDate=null,DateTime? endDate = null, int? page = null)
        {
            StringBuilder sb=new(GetChangesLink);
            sb.Replace("{person_id}", personId.ToString());
            if (sb is not null)
            {
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
            }
            if (sb is null)
                sb = new(GetChangesLink);
            return Api.Get<PersonChangeContainer>(sb.ToString());
        }

        #endregion


        #region Get Movie Credits
        /// <summary>
        /// Kisinin rol aldigi veya calistigi filmleri donduren metod
        /// </summary>
        /// <param name="personId">Kisi Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<MovieCreditsForPerson> GetMovieCredits(int personId,string? language=null)
        {
            StringBuilder sb = new(GetMovieCreditsLink);
            sb.Replace("{person_id}", personId.ToString());
            if (sb is not null)
            {
                if (!string.IsNullOrEmpty(language))
                {
                    sb.Append("&language=");
                    sb.Append(language);
                }
            }
            if (sb is null)
                sb = new(GetMovieCreditsLink);
            return Api.Get<MovieCreditsForPerson>(sb.ToString());
        }

        #endregion


        #region Get TV Credits
        /// <summary>
        /// Kisinin rol aldigi veya calistigi Tv sovlarini donduren metod
        /// </summary>
        /// <param name="personId">Kisi Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<TvCreditsForPerson> GetTVCredits(int personId, string? language = null)
        {
            StringBuilder sb = new(GetTVCreditsLink);
            sb.Replace("{person_id}", personId.ToString());
            if (sb is not null)
            {
                if (!string.IsNullOrEmpty(language))
                {
                    sb.Append("&language=");
                    sb.Append(language);
                }
            }
            if (sb is null)
                sb = new(GetTVCreditsLink);
            return Api.Get<TvCreditsForPerson>(sb.ToString());
        }
        #endregion


        #region Get Combined Credits
        /// <summary>
        /// Kisinin rol aldigi veya calistigi Tv sovlarini ve filmlerini donduren metod
        /// </summary>
        /// <param name="personId">Kisi Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<CombinedCreditsForPerson> GetCombinedCredits(int personId, string? language = null)
        {
            StringBuilder sb = new(GetCombinedCreditsLink);
            sb.Replace("{person_id}", personId.ToString());
            if (sb is not null)
            {
                if (!string.IsNullOrEmpty(language))
                {
                    sb.Append("&language=");
                    sb.Append(language);
                }
            }
            if (sb is null)
                sb = new(GetCombinedCreditsLink);
            return Api.Get<CombinedCreditsForPerson>(sb.ToString());
        }

        #endregion


        #region Get External IDs
        /// <summary>
        /// Kisiye ait sosyal medya hesaplarinin Id degerlerini donduren metod
        /// </summary>
        /// <param name="personId">Kisi Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<ExternalIdsForPerson> GetExternalIDs(int personId, string? language = null)
        {
            StringBuilder sb = new(GetExternalIDsLink);
            sb.Replace("{person_id}", personId.ToString());
            if (sb is not null)
            {
                if (!string.IsNullOrEmpty(language))
                {
                    sb.Append("&language=");
                    sb.Append(language);
                }
            }
            if (sb is null)
                sb = new(GetExternalIDsLink);
            return Api.Get<ExternalIdsForPerson>(sb.ToString());
        }
        #endregion


        #region Get Images
        /// <summary>
        /// Kisiye ait resimleri donduren metod
        /// </summary>
        /// <param name="personId">Kisi Id degeri</param>
        /// <returns></returns>
        public Response<PersonImage> GetImages(int personId)
        {
            return Api.Get<PersonImage>(GetImagesLink.Replace("{person_id}", personId.ToString()));
        }
        #endregion


        #region Get Tagged Images
        /// <summary>
        /// Kisiye ait resimleri etiketlendigi film veya Tv Sov objesi ile birlikte donduren metod
        /// </summary>
        /// <param name="personId">Kisi Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="page">Sayfa sayisi</param>
        /// <returns></returns>
        public Response<TaggedImageContainer> GetTaggedImages(int personId,string?language=null,int? page=null)
        {
            StringBuilder sb=new(GetTaggedImagesLink);
            sb.Replace("{person_id}", personId.ToString());
            if (sb is not null)
            {
                if (!string.IsNullOrEmpty(language))
                {
                    sb.Append("&language=");
                    sb.Append(language);
                }
                if (page.HasValue)
                {
                    sb.Append("&page=");
                    sb.Append(page);
                }
            }
            if (sb is null)
                sb=new(GetTaggedImagesLink);
            return Api.Get<TaggedImageContainer>(sb.ToString());
        }
        #endregion


        #region Get Translations
        /// <summary>
        /// Kisi icin olusturulmus ceviri listesini donduren metod
        /// </summary>
        /// <param name="personId">Kisi Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<PersonTranslationContainer> GetTranslations(int personId, string? language = null)
        {
            StringBuilder sb = new(GetTranslationsLink);
            sb.Replace("{person_id}", personId.ToString());
            if (sb is not null)
            {
                if (!string.IsNullOrEmpty(language))
                {
                    sb.Append("&language=");
                    sb.Append(language);
                }
            }
            if (sb is null)
                sb = new(GetTranslationsLink);
            return Api.Get<PersonTranslationContainer>(sb.ToString());
        }
        #endregion

        #region Get Latest
        /// <summary>
        /// TMDB sitesine eklenen son kisiye ait bilgileri donduren metod
        /// </summary>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<Person> GetLatest( string? language = null)
        {
            StringBuilder sb = new(GetLatestLink);
            if (!string.IsNullOrEmpty(language))
            {
                sb.Append("&language=");
                sb.Append(language);
            }
            return Api.Get<Person>(sb.ToString());
        }
        #endregion

        #region Get Popular
        /// <summary>
        /// TMDB sitesinde populer olan kisilerin listesini almak icin kullanilan metod.
        /// Bu liste gunluk olarak guncellenmektedir.
        /// </summary>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="page">Sayfa sayisi</param>
        /// <returns></returns>
        public Response<PopularPeople> GetPopular(string? language = null, int? page = null)
        {
            StringBuilder sb = new(GetPopularLink);
            if (!string.IsNullOrEmpty(language))
            {
                sb.Append("&language=");
                sb.Append(language);
            }
            if (page.HasValue)
            {
                sb.Append("&page=");
                sb.Append(page);
            }
            return Api.Get<PopularPeople>(sb.ToString());
        }
        #endregion

    }
}
