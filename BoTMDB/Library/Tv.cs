using BoTMDB.Models.Movies;
using BoTMDB.Models.Tv;
using BoTMDB.Models.WatchProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Library
{
    /// <summary>
    /// Tv Sovlarla ilgili metodlarin bulundugu sinif
    /// Bu sinif icerisinde bulunan metodlar
    /// <list type="bullet">
    /// <item><see cref="GetDetails(int, string?)"/></item>
    /// <item><see cref="GetDetailsWithAppend(int, string?, string?)"/></item>
    /// <item><see cref="GetAccountStates(int, string, string?)"/></item>
    /// <item><see cref="GetAggregateCredits(int, string?)"/></item>
    /// <item><see cref="GetAlternativeTitles(int, string?)"/></item>
    /// <item><see cref="GetChanges(int, DateTime?, DateTime?, int?)"/></item>
    /// <item><see cref="GetContentRatings(int, string?)"/></item>
    /// <item><see cref="GetCredits(int, string?)"/></item>
    /// <item><see cref="GetEpisodeGroups(int, string?)"/></item>
    /// <item><see cref="GetExternalIDs(int, string?)"/></item>
    /// <item><see cref="GetImages(int)"/></item>
    /// <item><see cref="GetKeywords(int)"/></item>
    /// <item><see cref="GetRecommendations(int, string?, int?)"/></item>
    /// <item><see cref="GetReviews(int, string?, int?)"/></item>
    /// <item><see cref="GetScreenedTheatrically(int)"/></item>
    /// <item><see cref="GetSimilarTVShows(int, string?, int?)"/></item>
    /// <item><see cref="GetTranslations(int, string?)"/></item>
    /// <item><see cref="GetVideos(int, string?)"/></item>
    /// <item><see cref="GetWatchProviders(int)"/></item>
    /// <item><see cref="RateTVShow(int, decimal, string)"/></item>
    /// <item><see cref="RateTVShow(int, string, decimal)"/></item>
    /// <item><see cref="DeleteRating(int, string)"/></item>
    /// <item><see cref="DeleteRating(string, int)"/></item>
    /// <item><see cref="GetLatest(string?)"/></item>
    /// <item><see cref="GetTVAiringToday(string?, int?, string?)"/></item>
    /// <item><see cref="GetTVOnTheAir(string?, int?, string?)"/></item>
    /// <item><see cref="GetPopular(string?, int?, string?)"/></item>
    /// <item><see cref="GetTopRated(string?, int?, string?)"/></item>
    /// </list>
    /// <see href="https://developers.themoviedb.org/3/tv"/>
    /// </summary>
    public class Tv
    {
        private string ApiKey { get; set; }
        private string GetDetailsLink { get; set; }
        private string GetAccountStatesLink { get; set; }
        private string GetAggregateCreditsLink { get; set; }
        private string GetAlternativeTitlesLink { get; set; }
        private string GetChangesLink { get; set; }
        private string GetContentRatingsLink { get; set; }
        private string GetCreditsLink { get; set; }
        private string GetEpisodeGroupsLink { get; set; }
        private string GetExternalIDsLink { get; set; }
        private string GetImagesLink { get; set; }
        private string GetKeywordsLink { get; set; }
        private string GetRecommendationsLink { get; set; }
        private string GetReviewsLink { get; set; }
        private string GetScreenedTheatricallyLink { get; set; }
        private string GetSimilarTVShowsLink { get; set; }
        private string GetTranslationsLink { get; set; }
        private string GetVideosLink { get; set; }
        private string GetWatchProvidersLink { get; set; }
        private string RateTVShowLink { get; set; }
        private string DeleteRatingLink { get; set; }
        private string GetLatestLink { get; set; }
        private string GetTVAiringTodayLink { get; set; }
        private string GetTVOnTheAirLink { get; set; }
        private string GetPopularLink { get; set; }
        private string GetTopRatedLink { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey">Api Key Degeri</param>
        public Tv(string apiKey)
        {
            ApiKey = apiKey;
            GetDetailsLink = ApiLinks.TV.GetDetails.Replace("<<api_key>>", ApiKey);
            GetAccountStatesLink = ApiLinks.TV.GetAccountStates.Replace("<<api_key>>", ApiKey);
            GetAggregateCreditsLink = ApiLinks.TV.GetAggregateCredits.Replace("<<api_key>>", ApiKey);
            GetAlternativeTitlesLink = ApiLinks.TV.GetAlternativeTitles.Replace("<<api_key>>", ApiKey);
            GetChangesLink = ApiLinks.TV.GetChanges.Replace("<<api_key>>", ApiKey);
            GetContentRatingsLink = ApiLinks.TV.GetContentRatings.Replace("<<api_key>>", ApiKey);
            GetCreditsLink = ApiLinks.TV.GetCredits.Replace("<<api_key>>", ApiKey);
            GetEpisodeGroupsLink = ApiLinks.TV.GetEpisodeGroups.Replace("<<api_key>>", ApiKey);
            GetExternalIDsLink = ApiLinks.TV.GetExternalIDs.Replace("<<api_key>>", ApiKey);
            GetImagesLink = ApiLinks.TV.GetImages.Replace("<<api_key>>", ApiKey);
            GetKeywordsLink = ApiLinks.TV.GetKeywords.Replace("<<api_key>>", ApiKey);
            GetRecommendationsLink = ApiLinks.TV.GetRecommendations.Replace("<<api_key>>", ApiKey);
            GetReviewsLink = ApiLinks.TV.GetReviews.Replace("<<api_key>>", ApiKey);
            GetScreenedTheatricallyLink = ApiLinks.TV.GetScreenedTheatrically.Replace("<<api_key>>", ApiKey);
            GetSimilarTVShowsLink = ApiLinks.TV.GetSimilarTVShows.Replace("<<api_key>>", ApiKey);
            GetTranslationsLink = ApiLinks.TV.GetTranslations.Replace("<<api_key>>", ApiKey);
            GetVideosLink = ApiLinks.TV.GetVideos.Replace("<<api_key>>", ApiKey);
            GetWatchProvidersLink = ApiLinks.TV.GetWatchProviders.Replace("<<api_key>>", ApiKey);
            RateTVShowLink = ApiLinks.TV.RateTVShow.Replace("<<api_key>>", ApiKey);
            DeleteRatingLink = ApiLinks.TV.DeleteRating.Replace("<<api_key>>", ApiKey);
            GetLatestLink = ApiLinks.TV.GetLatest.Replace("<<api_key>>", ApiKey);
            GetTVAiringTodayLink = ApiLinks.TV.GetTVAiringToday.Replace("<<api_key>>", ApiKey);
            GetTVOnTheAirLink = ApiLinks.TV.GetTVOnTheAir.Replace("<<api_key>>", ApiKey);
            GetPopularLink = ApiLinks.TV.GetPopular.Replace("<<api_key>>", ApiKey);
            GetTopRatedLink = ApiLinks.TV.GetTopRated.Replace("<<api_key>>", ApiKey);

        }


        #region Get Details 					
        /// <summary>
        /// Id degeri verilen Tv Sov hakkinda detayli bilgi almak icin kullanilan metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<TvItem> GetDetails(int tvId, string? language = null)
        {
            StringBuilder sb = new(GetDetailsLink);
            sb.Replace("{tv_id}", tvId.ToString());
            if (sb is null)
                sb = new(GetDetailsLink);
            if (!string.IsNullOrEmpty(language))
            {
                sb.Append("&language=");
                sb.Append(language);
            }
            return Api.Get<TvItem>(sb.ToString());
        }

        /// <summary>
        /// Id degeri verilen Tv Sov hakkinda detayli bilgi almak icin kullanilan metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="appendToResponse">Tv sov ile birlikte video,resim, dis id degerleri gibi degerleri getirmek icin kullanilir</param>
        /// <returns></returns>
        public Response<TvWithAppend> GetDetailsWithAppend(int tvId, string? language = null, string? appendToResponse = null)
        {
            StringBuilder sb = new(GetDetailsLink);
            sb.Replace("{tv_id}", tvId.ToString());
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
            return Api.Get<TvWithAppend>(sb.ToString());
        }
        #endregion

        #region Get Account States 			
        /// <summary>
        /// Tv sovuna verilmis olan Puan,Izleme Listesine eklenmis mi, Favorilere eklenmis mi bilgilerini dondurmek icin kullanilan metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="sessionId">Oturum Id degeri</param>
        /// <param name="guestSessionId">MisafirOturum Id degeri</param>
        /// <returns></returns>
        public Response<AccountState> GetAccountStates(int tvId, string sessionId, string? guestSessionId = null)
        {
            StringBuilder sb = new(GetAccountStatesLink);
            sb.Replace("{tv_id}", tvId.ToString());
            sb.Append("&session_id=");
            sb.Append(sessionId);
            if (!string.IsNullOrEmpty(guestSessionId))
            {
                sb.Append("&guest_session_id=");
                sb.Append(guestSessionId);
            }
            return Api.Get<AccountState>(sb.ToString());
        }
        #endregion

        #region Get Aggregate Credits 		
        /// <summary>
        /// Tv Sovunda rol alan oyuncu ve diger calisanlari donduren metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<TvCredits> GetAggregateCredits(int tvId, string? language = null)
        {
            StringBuilder sb = new(GetAggregateCreditsLink);
            sb.Replace("{tv_id}", tvId.ToString());
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

        #region Get Alternative Titles 		
        /// <summary>
        /// Tv sovuna ait alternatif isimleri donduren metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="country">ISO 3166-1 Bolge Kodu</param>
        /// <returns></returns>
        public Response<AlternativeTitlesForTv> GetAlternativeTitles(int tvId, string? country = null)
        {
            StringBuilder sb = new(GetAlternativeTitlesLink);
            sb.Replace("{tv_id}", tvId.ToString());
            if (sb is null)
                sb = new(GetAlternativeTitlesLink);
            if (!string.IsNullOrEmpty(country))
            {
                sb.Append("&country=");
                sb.Append(country);
            }
            return Api.Get<AlternativeTitlesForTv>(sb.ToString());

        }
        #endregion

        #region Get Changes 					
        /// <summary>
        /// Tv Sov uzerinde yapilmis olan degisiklikleri dondurmek icin kullanilan metod.
        /// Tarih araligi verilmezse son 24 saat icerisinde yapilmis olan degisiklikleri dondurur.
        /// Tek bir sorguda maksimum 14 gun araligindaki degisiklikleri sorgulayabilirsiniz
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="startDate">Baslangic Tarihi</param>
        /// <param name="endDate">Bitis Tarihi</param>
        /// <param name="page">Sayfa Sayisi</param>
        /// <returns></returns>
        public Response<MediaChangeContainer> GetChanges(int tvId, DateTime? startDate = null, DateTime? endDate = null, int? page = null)
        {

            StringBuilder sb = new(GetChangesLink);
            sb.Replace("{tv_id}", tvId.ToString());
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

        #region Get Content Ratings 			

        /// <summary>
        /// Tv Sovuna ait sertifikalari bolgelere gore donduren metod
        /// </summary>
        /// <param name="tvId">Tv sov Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<ContentRating> GetContentRatings(int tvId, string? language = null)
        {
            StringBuilder sb = new(GetContentRatingsLink);
            sb.Replace("{tv_id}", tvId.ToString());
            if (sb is not null)
            {
                if (!string.IsNullOrEmpty(language))
                {
                    sb.Append("&language=");
                    sb.Append(language);
                }
            }
            if (sb is null)
                sb = new(GetContentRatingsLink);
            return Api.Get<ContentRating>(sb.ToString());
        }


        #endregion

        #region Get Credits 		
        /// <summary>
        /// Tv Sovunda rol alan oyuncu ve diger calisanlari donduren metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<TvCredits> GetCredits(int tvId, string? language = null)
        {
            StringBuilder sb = new(GetCreditsLink);
            sb.Replace("{tv_id}", tvId.ToString());
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

        #region Get Episode Groups 			

        /// <summary>
        /// Tv Sovu icin olusturulmus bolum gruplarini donduren metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<EpisodeGroupForTv> GetEpisodeGroups(int tvId, string? language = null)
        {
            StringBuilder sb = new(GetEpisodeGroupsLink);
            sb.Replace("{tv_id}", tvId.ToString());
            if (sb is not null)
            {
                if (!string.IsNullOrEmpty(language))
                {
                    sb.Append("&language=");
                    sb.Append(language);
                }
            }
            if (sb is null)
                sb = new(GetEpisodeGroupsLink);
            return Api.Get<EpisodeGroupForTv>(sb.ToString());
        }
        #endregion

        #region Get External IDs 				
        /// <summary>
        /// Tv sovuna ait sosyal medya hesaplarinin Id degerlerini donduren metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<ExternalIdsForTv> GetExternalIDs(int tvId, string? language = null)
        {
            StringBuilder sb = new(GetExternalIDsLink);
            sb.Replace("{tv_id}", tvId.ToString());
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
            return Api.Get<ExternalIdsForTv>(sb.ToString());
        }
        #endregion

        #region Get Images 					
        /// <summary>
        /// Tv Sovuna ait resimleri donduren metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <returns></returns>
        public Response<ImageContainer> GetImages(int tvId)
        {
            return Api.Get<ImageContainer>(GetImagesLink.Replace("{tv_id}", tvId.ToString()));
        }
        #endregion

        #region Get Keywords 				
        /// <summary>
        /// Tv Sovuna ait anahtar kelimeleri donduren metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <returns></returns>
        public Response<TvKeywords> GetKeywords(int tvId)
        {
            return Api.Get<TvKeywords>(GetKeywordsLink.Replace("{tv_id}", tvId.ToString()));

        }
        #endregion

        #region Get Recommendations 			
        /// <summary>
        /// Id degeri verilen Tv sovuna gore Tv sov onerilerini donduren metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="page">Sayfa sayisi</param>
        /// <returns></returns>
        public Response<TvContainer> GetRecommendations(int tvId, string? language = null, int? page = null)
        {
            StringBuilder sb = new(GetRecommendationsLink);
            sb.Replace("{tv_id}", tvId.ToString());
            if (sb is null)
                sb = new(GetRecommendationsLink);
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
            return Api.Get<TvContainer>(sb.ToString());
        }
        #endregion

        #region Get Reviews 					
        /// <summary>
        /// Tv Sovuna yapilan incelemeleri donduren metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="page">Sayfa sayisi</param>
        /// <returns></returns>
        public Response<MediaReview> GetReviews(int tvId, string? language = null, int? page = null)
        {
            StringBuilder sb = new(GetReviewsLink);
            sb.Replace("{tv_id}", tvId.ToString());
            if (sb is null)
                sb = new(GetReviewsLink);
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
            return Api.Get<MediaReview>(sb.ToString());
        }
        #endregion

        #region Get Screened Theatrically 	
        /// <summary>
        /// Festival veya tiyatroda gosterilen bolumleri donduren metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <returns></returns>
        public Response<ScreenedTheatrically> GetScreenedTheatrically(int tvId)
        {
            StringBuilder sb = new(GetScreenedTheatricallyLink);
            sb.Replace("{tv_id}", tvId.ToString());
            return Api.Get<ScreenedTheatrically>(sb.ToString());
        }
        #endregion

        #region Get Similar TV Shows 			
        /// <summary>
        /// Tv Sovuna benzeyen tv sov onerilerini donduren metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="page">Sayfa sayisi</param>
        /// <returns></returns>
        public Response<TvContainer> GetSimilarTVShows(int tvId, string? language = null, int? page = null)
        {
            StringBuilder sb = new(GetSimilarTVShowsLink);
            sb.Replace("{tv_id}", tvId.ToString());
            if (sb is null)
                sb = new(GetSimilarTVShowsLink);
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
            return Api.Get<TvContainer>(sb.ToString());
        }
        #endregion

        #region Get Translations 			
        /// <summary>
        /// Tv Sov icin olusturulmus ceviri listesini donduren metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<MediaTranslationContainer> GetTranslations(int tvId, string? language = null)
        {
            StringBuilder sb = new(GetTranslationsLink);
            sb.Replace("{tv_id}", tvId.ToString());
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
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<VideoContainer> GetVideos(int tvId, string? language = null)
        {
            StringBuilder sb = new(GetVideosLink);
            sb.Replace("{tv_id}", tvId.ToString());
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

        #region Get Watch Providers 			
        /// <summary>
        /// Izleme saglayicilarini ulkelere gore donduren metod. Veriler JustWatch sitesinden cekilmektedir.
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <returns></returns>
        public Response<ProviderContainer> GetWatchProviders(int tvId)
        {
            StringBuilder sb = new(GetWatchProvidersLink);
            sb.Replace("{tv_id}", tvId.ToString());
            if (sb is null)
                sb = new(GetWatchProvidersLink);
            return Api.Get<ProviderContainer>(sb.ToString());

        }
        #endregion

        #region Rate TV Show 					
        /// <summary>
        /// Tv Sovuna puan vermek icin kullanilan metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="value">Puan 0.5 ile 10 arasinda deger almasi gerekmektedir</param>
        /// <param name="sessionId">Oturum Id degeri</param>
        /// <returns></returns>
        public Response<Status> RateTVShow(int tvId, decimal value, string sessionId)
        {
            StringBuilder sb = new(RateTVShowLink);
            sb.Replace("{tv_id}", tvId.ToString());
            if (sb is null)
                sb = new(RateTVShowLink);
            sb.Append("&session_id=");
            sb.Append(sessionId);
            return Api.Post<Status>(sb.ToString(), JsonContent.Create(new { value = value }));
        }
        /// <summary>
        /// Tv Sovuna puan vermek icin kullanilan metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="value">Puan 0.5 ile 10 arasinda deger almasi gerekmektedir</param>
        /// <param name="guestSessionId">Misafir Oturum Id degeri</param>
        /// <returns></returns>
        public Response<Status> RateTVShow(int tvId, string guestSessionId, decimal value)
        {
            StringBuilder sb = new(RateTVShowLink);
            sb.Replace("{tv_id}", tvId.ToString());
            if (sb is null)
                sb = new(RateTVShowLink);
            sb.Append("&guest_session_id=");
            sb.Append(guestSessionId);
            return Api.Post<Status>(sb.ToString(), JsonContent.Create(new { value = value }));
        }
        #endregion

        #region Delete Rating 				
        /// <summary>
        /// Tv Sovuna verilen puani silmek icin kullanilan metod
        /// </summary>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <param name="sessionId">Oturum Id degeri</param>
        /// <returns></returns>
        public Response<Status> DeleteRating(int tvId, string sessionId)
        {
            StringBuilder sb = new(DeleteRatingLink);
            sb.Replace("{tv_id}", tvId.ToString());
            if (sb is null)
                sb = new(DeleteRatingLink);
            sb.Append("&session_id=");
            sb.Append(sessionId);
            return Api.Delete<Status>(sb.ToString());
        }
        /// <summary>
        /// Tv Sovuna  verilen puani silmek icin kullanilan metod
        /// </summary>
        /// <param name="guestSessionId">Misafir Oturum Id degeri</param>
        /// <param name="tvId">Tv Sov Id degeri</param>
        /// <returns></returns>
        public Response<Status> DeleteRating(string guestSessionId, int tvId)
        {
            StringBuilder sb = new(DeleteRatingLink);
            sb.Replace("{tv_id}", tvId.ToString());
            if (sb is null)
                sb = new(DeleteRatingLink);
            sb.Append("&guest_session_id=");
            sb.Append(guestSessionId);
            return Api.Delete<Status>(sb.ToString());
        }
        #endregion

        #region Get Latest 					
        /// <summary>
        /// Son eklenen Tv sovuna ait bilgilerini donduren metod
        /// </summary>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<TvItem> GetLatest(string? language = null)
        {
            StringBuilder sb = new(GetLatestLink);
            if (!string.IsNullOrEmpty(language))
            {
                sb.Append("&language=");
                sb.Append(language);
            }
            return Api.Get<TvItem>(sb.ToString());
        }
        #endregion

        #region Get TV Airing Today 			
        /// <summary>
        /// Bugun gosterimde olan Tv sovlarini donduren metod
        /// </summary>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="page">Sayfa sayisi</param>
        /// <param name="region">Ulke/Bolge Kodu</param>
        /// <returns></returns>
        public Response<TvContainer> GetTVAiringToday(string? language = null, int? page = null, string? region = null)
        {
            StringBuilder sb = new(GetTVAiringTodayLink);
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
            if (!string.IsNullOrEmpty(region))
            {
                sb.Append("&region=");
                sb.Append(region);
            }
            return Api.Get<TvContainer>(sb.ToString());
        }
        #endregion

        #region Get TV On The Air 				
        /// <summary>
        /// Su anda gosterimde olan Tv sovlarini donduren metod
        /// </summary>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="page">Sayfa sayisi</param>
        /// <param name="region">Ulke/Bolge Kodu</param>
        /// <returns></returns>
        public Response<TvContainer> GetTVOnTheAir(string? language = null, int? page = null, string? region = null)
        {
            StringBuilder sb = new(GetTVOnTheAirLink);
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
            if (!string.IsNullOrEmpty(region))
            {
                sb.Append("&region=");
                sb.Append(region);
            }
            return Api.Get<TvContainer>(sb.ToString());
        }
        #endregion

        #region Get Popular 					
        /// <summary>
        /// TMDB sitesinde populer olan tv sovlarini donduren metod
        /// </summary>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="page">Sayfa sayisi</param>
        /// <param name="region">Ulke/Bolge Kodu</param>
        /// <returns></returns>
        public Response<TvContainer> GetPopular(string? language = null, int? page = null, string? region = null)
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
            if (!string.IsNullOrEmpty(region))
            {
                sb.Append("&region=");
                sb.Append(region);
            }
            return Api.Get<TvContainer>(sb.ToString());
        }
        #endregion

        #region Get Top Rated 				
        /// <summary>
        /// TMDB sitesinde en yuksek oylari alan tv sovlarini donduren metod
        /// </summary>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="page">Sayfa sayisi</param>
        /// <param name="region">Ulke/Bolge Kodu</param>
        /// <returns></returns>
        public Response<TvContainer> GetTopRated(string? language = null, int? page = null, string? region = null)
        {
            StringBuilder sb = new(GetTopRatedLink);
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
            if (!string.IsNullOrEmpty(region))
            {
                sb.Append("&region=");
                sb.Append(region);
            }
            return Api.Get<TvContainer>(sb.ToString());
        }
        #endregion
    }
}
