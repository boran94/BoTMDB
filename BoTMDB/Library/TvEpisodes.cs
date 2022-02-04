using BoTMDB.Models.Tv;
using BoTMDB.Models.TvEpisodes;
using BoTMDB.Models.TvSeasons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Library
{
    /// <summary>
    /// Bolumlerle ilgili metodlarin bulundugu sinif
    /// Bu sinif icerisinde bulunan metodlar
    /// <list type="bullet">
    /// <item><see cref="GetDetails(int, int, int, string?)"/></item>
    /// <item><see cref="GetDetailsWithAppend(int, int, int, string?, string?)"/></item>
    /// <item><see cref="GetAccountStates(int, int, int, string, string?)"/></item>
    /// <item><see cref="GetChanges(int, DateTime?, DateTime?, int?)"/></item>
    /// <item><see cref="GetCredits(int, int, int, string?)"/></item>
    /// <item><see cref="GetExternalIDs(int, int, int, string?)"/></item>
    /// <item><see cref="GetImages(int, int, int)"/></item>
    /// <item><see cref="GetTranslations(int, int, int, string?)"/></item>
    /// <item><see cref="RateTVEpisode(int, int, int, decimal, string)"/></item>
    /// <item><see cref="RateTVEpisode(int, int, int, string, decimal)"/></item>
    /// <item><see cref="DeleteRating(int, int, int, string)"/></item>
    /// <item><see cref="DeleteRating(string, int, int, int)"/></item>
    /// <item><see cref="GetVideos(int, int, int, string?)"/></item>
    /// </list>
    /// <see href="https://developers.themoviedb.org/3/tv-episodes"/>
    /// </summary>
    public class TvEpisodes
    {
        private string ApiKey { get; set; }
        private string GetDetailsLink { get; set; }
        private string GetAccountStatesLink { get; set; }
        private string GetChangesLink { get; set; }
        private string GetCreditsLink { get; set; }
        private string GetExternalIDsLink { get; set; }
        private string GetImagesLink { get; set; }
        private string GetTranslationsLink { get; set; }
        private string RateTVEpisodeLink { get; set; }
        private string DeleteRatingLink { get; set; }
        private string GetVideosLink { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey">Api Key Degeri</param>
        public TvEpisodes(string apiKey)
        {
            ApiKey = apiKey;

            GetDetailsLink = ApiLinks.TVEpisodes.GetDetails.Replace("<<api_key>>", ApiKey);
            GetAccountStatesLink = ApiLinks.TVEpisodes.GetAccountStates.Replace("<<api_key>>", ApiKey);
            GetChangesLink = ApiLinks.TVEpisodes.GetChanges.Replace("<<api_key>>", ApiKey);
            GetCreditsLink = ApiLinks.TVEpisodes.GetCredits.Replace("<<api_key>>", ApiKey);
            GetExternalIDsLink = ApiLinks.TVEpisodes.GetExternalIDs.Replace("<<api_key>>", ApiKey);
            GetImagesLink = ApiLinks.TVEpisodes.GetImages.Replace("<<api_key>>", ApiKey);
            GetTranslationsLink = ApiLinks.TVEpisodes.GetTranslations.Replace("<<api_key>>", ApiKey);
            RateTVEpisodeLink = ApiLinks.TVEpisodes.RateTVEpisode.Replace("<<api_key>>", ApiKey);
            DeleteRatingLink = ApiLinks.TVEpisodes.DeleteRating.Replace("<<api_key>>", ApiKey);
            GetVideosLink = ApiLinks.TVEpisodes.GetVideos.Replace("<<api_key>>", ApiKey);
        }


        #region GetDetails 		
        /// <summary>
        /// Bolum hakkinda detayli bilgileri almak icin kullanilan metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="seasonNumber">Sezon Numarasi</param>
        /// <param name="episodeNumber">Bolum Numarasi</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<TvSeasonEpisode> GetDetails(int tvId, int seasonNumber,int episodeNumber, string? language = null)
        {
            StringBuilder sb = new(GetDetailsLink);
            sb.Replace("{tv_id}", tvId.ToString());
            sb.Replace("{season_number}", seasonNumber.ToString());
            sb.Replace("{episode_number}", episodeNumber.ToString());
            if (sb is null)
                sb = new(GetDetailsLink);
            if (!string.IsNullOrEmpty(language))
            {
                sb.Append("&language=");
                sb.Append(language);
            }
            return Api.Get<TvSeasonEpisode>(sb.ToString());
        }
        /// <summary>
        /// Bolum hakkinda detayli bilgileri almak icin kullanilan metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="seasonNumber">Sezon Numarasi</param>
        /// <param name="episodeNumber">Bolum Numarasi</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="appendToResponse">Tv bolumu ile birlikte video,resim, dis id degerleri gibi degerleri getirmek icin kullanilir</param>
        /// <returns></returns>
        public Response<TvSeasonEpisodeWithAppend> GetDetailsWithAppend(int tvId, int seasonNumber, int episodeNumber, string? language = null,string? appendToResponse=null)
        {
            StringBuilder sb = new(GetDetailsLink);
            sb.Replace("{tv_id}", tvId.ToString());
            sb.Replace("{season_number}", seasonNumber.ToString());
            sb.Replace("{episode_number}", episodeNumber.ToString());
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
            return Api.Get<TvSeasonEpisodeWithAppend>(sb.ToString());
        }
        #endregion

        #region GetAccountStates    
        /// <summary>
        /// Bolume verilen puani donduren metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="seasonNumber">Sezon Numarasi</param>
        /// <param name="episodeNumber">Bolum Numarasi</param>
        /// <param name="sessionId">Oturum Id degeri</param>
        /// <param name="guestSessionId">Misafir Oturum Id degeri</param>
        /// <returns></returns>
        public Response<AccountStateForEpisode> GetAccountStates(int tvId, int seasonNumber,int episodeNumber, string sessionId, string? guestSessionId = null)
        {
            StringBuilder sb = new(GetAccountStatesLink);
            sb.Replace("{tv_id}", tvId.ToString());
            sb.Replace("{season_number}", seasonNumber.ToString());
            sb.Replace("{episode_number}", episodeNumber.ToString());
            sb.Append("&session_id=");
            sb.Append(sessionId);
            if (!string.IsNullOrEmpty(guestSessionId))
            {
                sb.Append("&guest_session_id=");
                sb.Append(guestSessionId);
            }
            return Api.Get<AccountStateForEpisode>(sb.ToString());
        }
        #endregion

        #region GetChanges 		    
        /// <summary>
        /// Sezon uzerinde yapilmis olan degisiklikleri dondurmek icin kullanilan metod.
        /// Tarih araligi verilmezse son 24 saat icerisinde yapilmis olan degisiklikleri dondurur.
        /// Tek bir sorguda maksimum 14 gun araligindaki degisiklikleri sorgulayabilirsiniz
        /// </summary>
        /// <param name="episodeId">Bolum Id Degeri</param>
        /// <param name="startDate">Baslangic Tarihi</param>
        /// <param name="endDate">Bitis Tarihi</param>
        /// <param name="page">Sayfa Sayisi</param>
        /// <returns></returns>
        public Response<MediaChangeContainer> GetChanges(int episodeId, DateTime? startDate = null, DateTime? endDate = null, int? page = null)
        {
            StringBuilder sb = new(GetChangesLink);
            sb.Replace("{episode_id}", episodeId.ToString());
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

        #region GetCredits 		    
        /// <summary>
        /// Bolumde rol alan oyuncular ve diger calisanlar hakkindaki bilgileri donduren metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="seasonNumber">Sezon Numarasi</param>
        /// <param name="episodeNumber">Bolum Numarasi</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<EpisodeCredits> GetCredits(int tvId, int seasonNumber,int episodeNumber, string? language = null)
        {
            StringBuilder sb = new(GetCreditsLink);
            sb.Replace("{tv_id}", tvId.ToString());
            sb.Replace("{season_number}", seasonNumber.ToString());
            sb.Replace("{episode_number}", episodeNumber.ToString());
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
            return Api.Get<EpisodeCredits>(sb.ToString());
        }
        #endregion

        #region GetExternalIDs 	    
        /// <summary>
        /// Tv sovu icin sezona ait sosyal medya hesaplarinin Id degerlerini donduren metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="seasonNumber">Sezon Numarasi</param>
        /// <param name="episodeNumber">Bolum Numarasi</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<ExternalIdForSeasons> GetExternalIDs(int tvId, int seasonNumber,int episodeNumber, string? language = null)
        {
            StringBuilder sb = new(GetExternalIDsLink);
            sb.Replace("{tv_id}", tvId.ToString());
            sb.Replace("{season_number}", seasonNumber.ToString());
            sb.Replace("{episode_number}", seasonNumber.ToString());

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

        #region GetImages 		    
        /// <summary>
        /// Bolume ait resimleri donduren metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="seasonNumber">Sezon Numarasi</param>
        /// <param name="episodeNumber">Sezon Numarasi</param>
        /// <returns></returns>
        public Response<EpisodeImageContainer> GetImages(int tvId, int seasonNumber,int episodeNumber)
        {
            StringBuilder sb = new(GetImagesLink);
            sb.Replace("{tv_id}", tvId.ToString());
            sb.Replace("{season_number}", seasonNumber.ToString());
            sb.Replace("{episode_number}", episodeNumber.ToString());
            return Api.Get<EpisodeImageContainer>(sb.ToString());
        }
        #endregion

        #region GetTranslations 	
        /// <summary>
        /// Bolume ait cevirileri dondurmek icin kullanilan metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="seasonNumber">Sezon Numarasi</param>
        /// <param name="episodeNumber">Bolum Numarasi</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<MediaTranslationContainer> GetTranslations(int tvId, int seasonNumber,int episodeNumber, string? language = null)
        {
            StringBuilder sb = new(GetTranslationsLink);
            sb.Replace("{tv_id}", tvId.ToString());
            sb.Replace("{season_number}", seasonNumber.ToString());
            sb.Replace("{episode_number}", episodeNumber.ToString());

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

        #region RateTVEpisode 	    
        /// <summary>
        /// Bolume puan vermek icin kullanilan metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="seasonNumber">Sezon Numarasi</param>
        /// <param name="episodeNumber">Bolum Numarasi</param>
        /// <param name="value">Puan 0.5 ile 10 arasinda deger almasi gerekmektedir</param>
        /// <param name="sessionId">Oturum Id degeri</param>
        /// <returns></returns>
        public Response<Status> RateTVEpisode(int tvId,int seasonNumber,int episodeNumber, decimal value, string sessionId)
        {
            StringBuilder sb = new(RateTVEpisodeLink);
            sb.Replace("{tv_id}", tvId.ToString());
            sb.Replace("{season_number}", seasonNumber.ToString());
            sb.Replace("{episode_number}", episodeNumber.ToString());
            if (sb is null)
                sb = new(RateTVEpisodeLink);
            sb.Append("&session_id=");
            sb.Append(sessionId);
            return Api.Post<Status>(sb.ToString(), JsonContent.Create(new { value = value }));
        }
        /// <summary>
        /// Bolume puan vermek icin kullanilan metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="seasonNumber">Sezon Numarasi</param>
        /// <param name="episodeNumber">Bolum Numarasi</param>
        /// <param name="value">Puan 0.5 ile 10 arasinda deger almasi gerekmektedir</param>
        /// <param name="guestSessionId">Misafir Oturum Id degeri</param>
        /// <returns></returns>
        public Response<Status> RateTVEpisode(int tvId, int seasonNumber, int episodeNumber, string guestSessionId, decimal value)
        {
            StringBuilder sb = new(RateTVEpisodeLink);
            sb.Replace("{tv_id}", tvId.ToString());
            sb.Replace("{season_number}", seasonNumber.ToString());
            sb.Replace("{episode_number}", episodeNumber.ToString());
            if (sb is null)
                sb = new(RateTVEpisodeLink);
            sb.Append("&guest_session_id=");
            sb.Append(guestSessionId);
            return Api.Post<Status>(sb.ToString(), JsonContent.Create(new { value = value }));
        }
        #endregion

        #region DeleteRating 	    
        /// <summary>
        /// Bolume verilen puani silmek icin kullanilan metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="sessionId">Oturum Id degeri</param>
        /// <param name="seasonNumber">Sezon Numarasi</param>
        /// <param name="episodeNumber">Bolum Numarasi</param>
        /// <returns></returns>
        public Response<Status> DeleteRating(int tvId, int seasonNumber, int episodeNumber, string sessionId)
        {
            StringBuilder sb = new(DeleteRatingLink);
            sb.Replace("{tv_id}", tvId.ToString());
            sb.Replace("{season_number}", seasonNumber.ToString());
            sb.Replace("{episode_number}", episodeNumber.ToString());
            if (sb is null)
                sb = new(DeleteRatingLink);
            sb.Append("&session_id=");
            sb.Append(sessionId);
            return Api.Delete<Status>(sb.ToString());
        }
        /// <summary>
        /// Bolume  verilen puani silmek icin kullanilan metod
        /// </summary>
        /// <param name="guestSessionId">Misafir Oturum Id degeri</param>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="seasonNumber">Sezon Numarasi</param>
        /// <param name="episodeNumber">Bolum Numarasi</param>
        /// <returns></returns>
        public Response<Status> DeleteRating(string guestSessionId, int seasonNumber, int episodeNumber, int tvId)
        {
            StringBuilder sb = new(DeleteRatingLink);
            sb.Replace("{tv_id}", tvId.ToString());
            sb.Replace("{season_number}", seasonNumber.ToString());
            sb.Replace("{episode_number}", episodeNumber.ToString());
            if (sb is null)
                sb = new(DeleteRatingLink);
            sb.Append("&guest_session_id=");
            sb.Append(guestSessionId);
            return Api.Delete<Status>(sb.ToString());
        }
        #endregion

        #region GetVideos 		    
        /// <summary>
        /// Bolume ait videolari donduren metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="seasonNumber">Sezon Numarasi</param>
        /// <param name="episodeNumber">Bolum Numarasi</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<VideoContainer> GetVideos(int tvId, int seasonNumber, int episodeNumber, string? language = null)
        {
            StringBuilder sb = new(GetVideosLink);
            sb.Replace("{tv_id}", tvId.ToString());
            sb.Replace("{season_number}", seasonNumber.ToString());
            sb.Replace("{episode_number}", episodeNumber.ToString());
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
