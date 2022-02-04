using BoTMDB.Models.Tv;
using BoTMDB.Models.TvSeasons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Library
{

    /// <summary>
    /// Sezonlarla ilgili metodlarin bulundugu sinif
    /// Bu sinif icerisinde bulunan metodlar
    /// <list type="bullet">
    /// <item><see cref="GetDetails(int, int, string?)"/></item>
    /// <item><see cref="GetDetailsWithAppend(int, int, string?, string?)"/></item>
    /// <item><see cref="GetAccountStates(int, int, string, string?)"/></item>
    /// <item><see cref="GetAggregateCredits(int, int, string?)"/></item>
    /// <item><see cref="GetChanges(int, DateTime?, DateTime?, int?)"/></item>
    /// <item><see cref="GetCredits(int, int, string?)"/></item>
    /// <item><see cref="GetExternalIDs(int, int, string?)"/></item>
    /// <item><see cref="GetImages(int, int)"/></item>
    /// <item><see cref="GetTranslations(int, int, string?)"/></item>
    /// <item><see cref="GetVideos(int, int, string?)"/></item>
    /// </list>
    /// <see href="https://developers.themoviedb.org/3/tv-seasons"/>
    /// </summary>
    public class TvSeasons
    {
        private string ApiKey { get; set; }
        private string GetDetailsLink { get; set; }
        private string GetAccountStatesLink { get; set; }
        private string GetAggregateCreditsLink { get; set; }
        private string GetChangesLink { get; set; }
        private string GetCreditsLink { get; set; }
        private string GetExternalIDsLink { get; set; }
        private string GetImagesLink { get; set; }
        private string GetTranslationsLink { get; set; }
        private string GetVideosLink { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey">Api Key Degeri</param>
        public TvSeasons(string apiKey)
        {
            ApiKey = apiKey;

            GetDetailsLink = ApiLinks.TVSeasons.GetDetails.Replace("<<api_key>>", ApiKey);
            GetAccountStatesLink = ApiLinks.TVSeasons.GetAccountStates.Replace("<<api_key>>", ApiKey);
            GetAggregateCreditsLink = ApiLinks.TVSeasons.GetAggregateCredits.Replace("<<api_key>>", ApiKey);
            GetChangesLink = ApiLinks.TVSeasons.GetChanges.Replace("<<api_key>>", ApiKey);
            GetCreditsLink = ApiLinks.TVSeasons.GetCredits.Replace("<<api_key>>", ApiKey);
            GetExternalIDsLink = ApiLinks.TVSeasons.GetExternalIDs.Replace("<<api_key>>", ApiKey);
            GetImagesLink = ApiLinks.TVSeasons.GetImages.Replace("<<api_key>>", ApiKey);
            GetTranslationsLink = ApiLinks.TVSeasons.GetTranslations.Replace("<<api_key>>", ApiKey);
            GetVideosLink = ApiLinks.TVSeasons.GetVideos.Replace("<<api_key>>", ApiKey);
        }


        #region Get Details 		
        /// <summary>
        /// Tv Sezonuna ait detaylari donduren metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="seasonNumber">Sezon numarasi</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<TvSeason> GetDetails(int tvId,int seasonNumber, string? language = null)
        {
            StringBuilder sb = new(GetDetailsLink);
            sb.Replace("{tv_id}", tvId.ToString());
            sb.Replace("{season_number}", seasonNumber.ToString());
            if (sb is null)
                sb = new(GetDetailsLink);
            if (!string.IsNullOrEmpty(language))
            {
                sb.Append("&language=");
                sb.Append(language);
            }
            return Api.Get<TvSeason>(sb.ToString());
        }

        /// <summary>
        /// Tv Sezonuna ait detaylari donduren metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="seasonNumber">Sezon numarasi</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="appendToResponse">Tv sezonu ile birlikte video,resim, dis id degerleri gibi degerleri getirmek icin kullanilir</param>
        /// <returns></returns>
        public Response<TvSeasonWithAppend> GetDetailsWithAppend(int tvId, int seasonNumber, string? language = null,string? appendToResponse=null)
        {
            StringBuilder sb = new(GetDetailsLink);
            sb.Replace("{tv_id}", tvId.ToString());
            sb.Replace("{season_number}", seasonNumber.ToString());
            if (sb is null)
                sb = new(GetDetailsLink);
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
            return Api.Get<TvSeasonWithAppend>(sb.ToString());
        }
        #endregion

        #region Get Account States 		    
        /// <summary>
        /// Kullanicinin sezondaki bolumlere verdigi tum degerlendirmeleri donduren metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="seasonNumber">Sezon numarasi</param>
        /// <param name="sessionId">Oturum Id degeri</param>
        /// <param name="guestSessionId">Misafir Oturum Id degeri</param>
        /// <returns></returns>
        public Response<AccountStateForTvSeason> GetAccountStates(int tvId,int seasonNumber, string sessionId, string? guestSessionId = null)
        {
            StringBuilder sb = new(GetAccountStatesLink);
            sb.Replace("{tv_id}", tvId.ToString());
            sb.Replace("{season_number}", seasonNumber.ToString());
            sb.Append("&session_id=");
            sb.Append(sessionId);
            if (!string.IsNullOrEmpty(guestSessionId))
            {
                sb.Append("&guest_session_id=");
                sb.Append(guestSessionId);
            }
            return Api.Get<AccountStateForTvSeason>(sb.ToString());
        }
        #endregion

        #region Get Aggregate Credits 	    
        /// <summary>
        /// Sezon icerisinde rol alan oyuncu ve diger calisanlari donduren metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="seasonNumber">Sezon Numarasi</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<TvCredits> GetAggregateCredits(int tvId,int seasonNumber, string? language = null)
        {
            StringBuilder sb = new(GetAggregateCreditsLink);
            sb.Replace("{tv_id}", tvId.ToString());
            sb.Replace("{season_number}", seasonNumber.ToString());
            if (sb is not null)
            {
                if (!string.IsNullOrEmpty(language))
                {
                    sb.Append("&language=");
                    sb.Append(language);
                }
            }
            if (sb is null)
                sb = new(GetAggregateCreditsLink);
            return Api.Get<TvCredits>(sb.ToString());
        }
        #endregion

        #region Get Changes 				
        /// <summary>
        /// Sezon uzerinde yapilmis olan degisiklikleri dondurmek icin kullanilan metod.
        /// Tarih araligi verilmezse son 24 saat icerisinde yapilmis olan degisiklikleri dondurur.
        /// Tek bir sorguda maksimum 14 gun araligindaki degisiklikleri sorgulayabilirsiniz
        /// </summary>
        /// <param name="seasonNumber">Sezon Numarasi</param>
        /// <param name="startDate">Baslangic Tarihi</param>
        /// <param name="endDate">Bitis Tarihi</param>
        /// <param name="page">Sayfa Sayisi</param>
        /// <returns></returns>
        public Response<MediaChangeContainer> GetChanges(int seasonNumber, DateTime? startDate = null, DateTime? endDate = null, int? page = null)
        {
            StringBuilder sb = new(GetChangesLink);
            sb.Replace("{season_number}", seasonNumber.ToString());

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
            return Api.Get<MediaChangeContainer>(sb.ToString());
        }
        #endregion

        #region Get Credits 				
        /// <summary>
        /// Tv Sov icin id degeri verilen sezonda rol alan oyuncu ve diger calisanlari donduren metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="seasonNumber">Sezon Numarasi</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<TvCredits> GetCredits(int tvId,int seasonNumber, string? language = null)
        {
            StringBuilder sb = new(GetCreditsLink);
            sb.Replace("{tv_id}", tvId.ToString());
            sb.Replace("{season_number}", seasonNumber.ToString());
            if (sb is not null)
            {
                if (!string.IsNullOrEmpty(language))
                {
                    sb.Append("&language=");
                    sb.Append(language);
                }
            }
            if (sb is null)
                sb = new(GetCreditsLink);
            return Api.Get<TvCredits>(sb.ToString());
        }
        #endregion

        #region Get External IDs 			
        /// <summary>
        /// Tv sovu icin sezona ait sosyal medya hesaplarinin Id degerlerini donduren metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="seasonNumber">Sezon Numarasi</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<ExternalIdForSeasons> GetExternalIDs(int tvId,int seasonNumber, string? language = null)
        {
            StringBuilder sb = new(GetExternalIDsLink);
            sb.Replace("{tv_id}", tvId.ToString());
            sb.Replace("{season_number}", seasonNumber.ToString());

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
            return Api.Get<ExternalIdForSeasons>(sb.ToString());
        }
        #endregion

        #region Get Images 				    
        /// <summary>
        /// Sezona ait resimleri donduren metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="seasonNumber">Sezon Numarasi</param>
        /// <returns></returns>
        public Response<ImageContainer> GetImages(int tvId,int seasonNumber)
        {
            StringBuilder sb = new(GetImagesLink);
            sb.Replace("{tv_id}", tvId.ToString());
            sb.Replace("{season_number}", seasonNumber.ToString());
            return Api.Get<ImageContainer>(sb.ToString());
        }
        #endregion

        #region Get Translations 		    
        /// <summary>
        /// Tv Sov icin id degeri verilen sezona ait olusturulmus ceviri listesini donduren metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="seasonNumber">Sezon Numarasi</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<MediaTranslationContainer> GetTranslations(int tvId,int seasonNumber, string? language = null)
        {
            StringBuilder sb = new(GetTranslationsLink);
            sb.Replace("{tv_id}", tvId.ToString());
            sb.Replace("{season_number}", seasonNumber.ToString());
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
            return Api.Get<MediaTranslationContainer>(sb.ToString());
        }
        #endregion

        #region Get Videos 				    
        /// <summary>
        /// Tv sovuna ait videolari donduren metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="seasonNumber">Sezon Numarasi</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<VideoContainer> GetVideos(int tvId,int seasonNumber, string? language = null)
        {
            StringBuilder sb = new(GetVideosLink);
            sb.Replace("{tv_id}", tvId.ToString());
            sb.Replace("{season_number}", seasonNumber.ToString());

            if (sb is null)
                sb = new(GetVideosLink);
            if (!string.IsNullOrEmpty(language))
            {
                sb.Append("&language=");
                sb.Append(language);
            }
            return Api.Get<VideoContainer>(sb.ToString());
        }
        #endregion
    }
}
