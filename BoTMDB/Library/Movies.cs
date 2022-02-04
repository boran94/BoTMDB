using BoTMDB.Models.Movies;
using BoTMDB.Models.Reviews;
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
    /// Filmlerle ilgili metodlarin bulundugu sinif
    /// Bu sinif icerisinde bulunan metodlar
    /// <list type="bullet">
    /// <item><see cref="GetDetails(int, string?)"/></item>
    /// <item><see cref="GetDetailsWithAppend(int, string?, string?)"/></item>
    /// <item><see cref="GetAccountStates(int, string, string?)"/></item>
    /// <item><see cref="GetAlternativeTitles(int, string?)"/></item>
    /// <item><see cref="GetChanges(int, DateTime?, DateTime?, int?)"/></item>
    /// <item><see cref="GetCredits(int, string?)"/></item>
    /// <item><see cref="GetExternalIDs(int, string?)"/></item>
    /// <item><see cref="GetImages(int)"/></item>
    /// <item><see cref="GetKeywords(int)"/></item>
    /// <item><see cref="GetLists(int, string?, int?)"/></item>
    /// <item><see cref="GetRecommendations(int, string?, int?)"/></item>
    /// <item><see cref="GetReleasDates(int)"/></item>
    /// <item><see cref="GetReviews(int, string?, int?)"/></item>
    /// <item><see cref="GetSimilarMovies(int, string?, int?)"/></item>
    /// <item><see cref="GetTranslations(int, string?)"/></item>
    /// <item><see cref="GetVideos(int, string?)"/></item>
    /// <item><see cref="GetWatchProviders(int)"/></item>
    /// <item><see cref="RateMovie(int, decimal, string)"/></item>
    /// <item><see cref="RateMovie(int, string, decimal)"/></item>
    /// <item><see cref="DeleteRating(int, string)"/></item>
    /// <item><see cref="DeleteRating(int, string)"/></item>
    /// <item><see cref="GetLatest(string?)"/></item>
    /// <item><see cref="GetNowPlaying(string?, int?, string?)"/></item>
    /// <item><see cref="GetPopular(string?, int?, string?)"/></item>
    /// <item><see cref="GetTopRated(string?, int?, string?)"/></item>
    /// <item><see cref="GetUpcoming(string?, int?, string?)"/></item>
    /// </list>
    /// <see href="https://developers.themoviedb.org/3/movies"/>
    /// </summary>
    public class Movies
    {
        private string ApiKey { get; set; }
        private string GetDetailsLink { get; set; }
        private string GetAccountStatesLink { get; set; }
        private string GetAlternativeTitlesLink { get; set; }
        private string GetChangesLink { get; set; }
        private string GetCreditsLink { get; set; }
        private string GetExternalIDsLink { get; set; }
        private string GetImagesLink { get; set; }
        private string GetKeywordsLink { get; set; }
        private string GetListsLink { get; set; }
        private string GetRecommendationsLink { get; set; }
        private string GetReleaseDatesLink { get; set; }
        private string GetReviewsLink { get; set; }
        private string GetSimilarMoviesLink { get; set; }
        private string GetTranslationsLink { get; set; }
        private string GetVideosLink { get; set; }
        private string GetWatchProvidersLink { get; set; }
        private string RateMovieLink { get; set; }
        private string DeleteRatingLink { get; set; }
        private string GetLatestLink { get; set; }
        private string GetNowPlayingLink { get; set; }
        private string GetPopularLink { get; set; }
        private string GetTopRatedLink { get; set; }
        private string GetUpcomingLink { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey">Api Key Degeri</param>
        public Movies(string apiKey)
        {
            ApiKey = apiKey;
            GetDetailsLink = ApiLinks.Movies.GetDetails.Replace("<<api_key>>", ApiKey);
            GetAccountStatesLink = ApiLinks.Movies.GetAccountStates.Replace("<<api_key>>", ApiKey);
            GetAlternativeTitlesLink = ApiLinks.Movies.GetAlternativeTitles.Replace("<<api_key>>", ApiKey);
            GetChangesLink = ApiLinks.Movies.GetChanges.Replace("<<api_key>>", ApiKey);
            GetCreditsLink = ApiLinks.Movies.GetCredits.Replace("<<api_key>>", ApiKey);
            GetExternalIDsLink = ApiLinks.Movies.GetExternalIDs.Replace("<<api_key>>", ApiKey);
            GetImagesLink = ApiLinks.Movies.GetImages.Replace("<<api_key>>", ApiKey);
            GetKeywordsLink = ApiLinks.Movies.GetKeywords.Replace("<<api_key>>", ApiKey);
            GetListsLink = ApiLinks.Movies.GetLists.Replace("<<api_key>>", ApiKey);
            GetRecommendationsLink = ApiLinks.Movies.GetRecommendations.Replace("<<api_key>>", ApiKey);
            GetReleaseDatesLink = ApiLinks.Movies.GetReleaseDates.Replace("<<api_key>>", ApiKey);
            GetReviewsLink = ApiLinks.Movies.GetReviews.Replace("<<api_key>>", ApiKey);
            GetSimilarMoviesLink = ApiLinks.Movies.GetSimilarMovies.Replace("<<api_key>>", ApiKey);
            GetTranslationsLink = ApiLinks.Movies.GetTranslations.Replace("<<api_key>>", ApiKey);
            GetVideosLink = ApiLinks.Movies.GetVideos.Replace("<<api_key>>", ApiKey);
            GetWatchProvidersLink = ApiLinks.Movies.GetWatchProviders.Replace("<<api_key>>", ApiKey);
            RateMovieLink = ApiLinks.Movies.RateMovie.Replace("<<api_key>>", ApiKey);
            DeleteRatingLink = ApiLinks.Movies.DeleteRating.Replace("<<api_key>>", ApiKey);
            GetLatestLink = ApiLinks.Movies.GetLatest.Replace("<<api_key>>", ApiKey);
            GetNowPlayingLink = ApiLinks.Movies.GetNowPlaying.Replace("<<api_key>>", ApiKey);
            GetPopularLink = ApiLinks.Movies.GetPopular.Replace("<<api_key>>", ApiKey);
            GetTopRatedLink = ApiLinks.Movies.GetTopRated.Replace("<<api_key>>", ApiKey);
            GetUpcomingLink = ApiLinks.Movies.GetUpcoming.Replace("<<api_key>>", ApiKey);

        }

        #region Get Details 	
        /// <summary>
        /// Film hakkinda temel bilgileri almak icin kullanilan metod
        /// </summary>
        /// <param name="movieId">Film Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<Movie> GetDetails(int movieId,string? language = null)
        {
            StringBuilder sb = new(GetDetailsLink);
            sb.Replace("{movie_id}", movieId.ToString());
            if (sb is null)
                sb = new(GetDetailsLink);
            if (!string.IsNullOrEmpty(language))
            {
                sb.Append("&language=");
                sb.Append(language);
            }
            return Api.Get<Movie>(sb.ToString());
        }
        /// <summary>
        /// Film hakkinda temel bilgileri almak icin kullanilan metod
        /// </summary>
        /// <param name="movieId">Film Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="appendToResponse">Filmle ile birlikte video,resim, dis id degerleri gibi degerleri getirmek icin kullanilir</param>
        /// <returns></returns>
        public Response<MovieWithAppend> GetDetailsWithAppend(int movieId, string? language = null,string? appendToResponse=null)
        {
            StringBuilder sb = new(GetDetailsLink);
            sb.Replace("{movie_id}", movieId.ToString());
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
            return Api.Get<MovieWithAppend>(sb.ToString());
        }
        #endregion

        #region Get Account States 	    
        /// <summary>
        /// Filme verilmis olan Puan,Izleme Listesine eklenmis mi, Favorilere eklenmis mi bilgilerini dondurmek icin kullanilan metod
        /// </summary>
        /// <param name="movieId">Film Id degeri</param>
        /// <param name="sessionId">Oturum Id degeri</param>
        /// <param name="guestSessionId">MisafirOturum Id degeri</param>
        /// <returns></returns>
        public Response<AccountState> GetAccountStates(int movieId,string sessionId,string? guestSessionId=null)
        {
            StringBuilder sb = new(GetAccountStatesLink);
            sb.Replace("{movie_id}", movieId.ToString());
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
        #region Get Alternative Titles  
        /// <summary>
        /// Filme ait alternatif isimleri donduren metod
        /// </summary>
        /// <param name="movieId">Film Id degeri</param>
        /// <param name="country"></param>
        /// <returns></returns>
        public Response<AlternativeTitlesForMedia> GetAlternativeTitles(int movieId, string? country=null)
        {
            StringBuilder sb = new(GetAlternativeTitlesLink);
            sb.Replace("{movie_id}", movieId.ToString());
            if (sb is null)
                sb = new(GetAlternativeTitlesLink);
            if (!string.IsNullOrEmpty(country))
            {
                sb.Append("&country=");
                sb.Append(country);
            }
            return Api.Get<AlternativeTitlesForMedia>(sb.ToString());

        }
        #endregion

        #region Get Changes 	
        /// <summary>
        /// Film uzerinde yapilmis olan degisiklikleri dondurmek icin kullanilan metod.
        /// Tarih araligi verilmezse son 24 saat icerisinde yapilmis olan degisiklikleri dondurur.
        /// Tek bir sorguda maksimum 14 gun araligindaki degisiklikleri sorgulayabilirsiniz
        /// </summary>
        /// <param name="movieId">Film Id degeri</param>
        /// <param name="startDate">Baslangic Tarihi</param>
        /// <param name="endDate">Bitis Tarihi</param>
        /// <param name="page">Sayfa Sayisi</param>
        /// <returns></returns>
        public Response<MediaChangeContainer> GetChanges(int movieId, DateTime? startDate = null, DateTime? endDate = null, int? page = null)
        {

            StringBuilder sb = new(GetChangesLink);
            sb.Replace("{movie_id}", movieId.ToString());
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
        /// Filmdeki oyuncu ve diger calisanlari donduren metod
        /// </summary>
        /// <param name="movieId">Film Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<MovieCredits> GetCredits(int movieId, string? language = null)
        {
            StringBuilder sb = new(GetCreditsLink);
            sb.Replace("{movie_id}", movieId.ToString());
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
            return Api.Get<MovieCredits>(sb.ToString());
        }

        #endregion

        #region Get External IDs 		
        /// <summary>
        /// Filme ait sosyal medya hesaplarinin Id degerlerini donduren metod
        /// </summary>
        /// <param name="movieId">Film Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<ExternalItem> GetExternalIDs(int movieId, string? language = null)
        {
            StringBuilder sb = new(GetExternalIDsLink);
            sb.Replace("{movie_id}", movieId.ToString());
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
            return Api.Get<ExternalItem>(sb.ToString());
        }
        #endregion

        #region Get Images 		
        /// <summary>
        /// Filme ait resimleri donduren metod
        /// </summary>
        /// <param name="movieId">Film Id degeri</param>
        /// <returns></returns>
        public Response<ImageContainer> GetImages(int movieId)
        {
            return Api.Get<ImageContainer>(GetImagesLink.Replace("{movie_id}", movieId.ToString()));
        }
        #endregion

        #region Get Keywords 			
        /// <summary>
        /// Filme ait anahtar kelimeleri donduren metod
        /// </summary>
        /// <param name="movieId">Film Id degeri</param>
        /// <returns></returns>
        public Response<MovieKeywords> GetKeywords(int movieId)
        {
            return Api.Get<MovieKeywords>(GetKeywordsLink.Replace("{movie_id}", movieId.ToString()));

        }
        #endregion

        #region Get Lists 		
        /// <summary>
        /// Id degeri verilen filmin eklenmis oldugu listeleri donduren metod
        /// </summary>
        /// <param name="movieId">Film Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="page">Sayfa sayisi</param>
        /// <returns></returns>
        public Response<MovieListContainer> GetLists(int movieId, string? language = null, int? page = null)
        {
            StringBuilder sb = new(GetListsLink);
            sb.Replace("{movie_id}", movieId.ToString());
            if (sb is null)
                sb = new(GetListsLink);
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
            return Api.Get<MovieListContainer>(sb.ToString());
        }
        #endregion

        #region Get Recommendations 	
        /// <summary>
        /// Id degeri verilen filme gore film onerilerini donduren metod
        /// </summary>
        /// <param name="movieId">Film Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="page">Sayfa sayisi</param>
        /// <returns></returns>
        public Response<MovieContainer> GetRecommendations(int movieId, string? language = null, int? page = null)
        {
            StringBuilder sb = new(GetRecommendationsLink);
            sb.Replace("{movie_id}", movieId.ToString());
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
            return Api.Get<MovieContainer>(sb.ToString());
        }
        #endregion

        #region Get Release Dates 		
        /// <summary>
        /// Filmin cikis tarihini ve sertifika bilgilerini dondurmek icin kullanilan metod
        /// Cikis tarihlerinin destekledigi turler
        /// <list type="number">
        /// <item>Premiere</item>
        /// <item>Theatrical (limited)</item>
        /// <item>Theatrical</item>
        /// <item>Digital</item>
        /// <item>Physical</item>
        /// <item>TV</item>
        /// </list>
        /// </summary>
        /// <param name="movieId">Film Id degeri</param>
        /// <returns></returns>
        public Response<ReleaseDateContainer> GetReleasDates(int movieId)
        {
            StringBuilder sb = new(GetReleaseDatesLink);
            sb.Replace("{movie_id}", movieId.ToString());
            if (sb is null)
                sb = new(GetReleaseDatesLink);
            return Api.Get<ReleaseDateContainer>(sb.ToString());

        }
        #endregion

        #region Get Reviews 	
        /// <summary>
        /// Filmlere yapilan incelemeleri donduren metod
        /// </summary>
        /// <param name="movieId">Film Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="page">Sayfa sayisi</param>
        /// <returns></returns>
        public Response<MediaReview> GetReviews(int movieId, string? language = null, int? page = null)
        {
            StringBuilder sb = new(GetReviewsLink);
            sb.Replace("{movie_id}", movieId.ToString());
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

        #region Get Similar Movies 	    
        /// <summary>
        /// Filme benzeyen film onerilerini donduren metod
        /// </summary>
        /// <param name="movieId">Film Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="page">Sayfa sayisi</param>
        /// <returns></returns>
        public Response<MovieContainer> GetSimilarMovies(int movieId, string? language = null, int? page = null)
        {
            StringBuilder sb = new(GetSimilarMoviesLink);
            sb.Replace("{movie_id}", movieId.ToString());
            if (sb is null)
                sb = new(GetSimilarMoviesLink);
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
            return Api.Get<MovieContainer>(sb.ToString());
        }
        #endregion

        #region Get Translations 
        /// <summary>
        /// Film icin olusturulmus ceviri listesini donduren metod
        /// </summary>
        /// <param name="movieId">Film Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<MediaTranslationContainer> GetTranslations(int movieId, string? language = null)
        {
            StringBuilder sb = new(GetTranslationsLink);
            sb.Replace("{movie_id}", movieId.ToString());
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
        /// Filme ait videolari donduren metod
        /// </summary>
        /// <param name="movieId">Film Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<VideoContainer> GetVideos(int movieId, string? language = null)
        {
            StringBuilder sb = new(GetVideosLink);
            sb.Replace("{movie_id}", movieId.ToString());
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
        /// <param name="movieId">Film Id degeri</param>
        /// <returns></returns>
        public Response<ProviderContainer> GetWatchProviders(int movieId)
        {
            StringBuilder sb = new(GetWatchProvidersLink);
            sb.Replace("{movie_id}", movieId.ToString());
            if (sb is null)
                sb = new(GetWatchProvidersLink);
            return Api.Get<ProviderContainer>(sb.ToString());

        }
        #endregion

        #region Rate Movie 	
        /// <summary>
        /// Filme puan vermek icin kullanilan metod
        /// </summary>
        /// <param name="movieId">Film Id degeri</param>
        /// <param name="value">Puan 0.5 ile 10 arasinda deger almasi gerekmektedir</param>
        /// <param name="sessionId">Oturum Id degeri</param>
        /// <returns></returns>
        public Response<Status> RateMovie(int movieId,decimal value,string sessionId)
        {
            StringBuilder sb = new(RateMovieLink);
            sb.Replace("{movie_id}", movieId.ToString());
            if (sb is null)
                sb = new(RateMovieLink);
            sb.Append("&session_id=");
            sb.Append(sessionId);
            return Api.Post<Status>(sb.ToString(), JsonContent.Create(new { value = value }));
        }
        /// <summary>
        /// Filme puan vermek icin kullanilan metod
        /// </summary>
        /// <param name="movieId">Film Id degeri</param>
        /// <param name="value">Puan 0.5 ile 10 arasinda deger almasi gerekmektedir</param>
        /// <param name="guestSessionId">Misafir Oturum Id degeri</param>
        /// <returns></returns>
        public Response<Status> RateMovie(int movieId, string guestSessionId, decimal value)
        {
            StringBuilder sb = new(RateMovieLink);
            sb.Replace("{movie_id}", movieId.ToString());
            if (sb is null)
                sb = new(RateMovieLink);
            sb.Append("&guest_session_id=");
            sb.Append(guestSessionId);
            return Api.Post<Status>(sb.ToString(), JsonContent.Create(new { value = value }));
        }
        #endregion
        #region Delete Rating 		    
        /// <summary>
        /// Filme verilen puani silmek icin kullanilan metod
        /// </summary>
        /// <param name="movieId">Film Id degeri</param>
        /// <param name="sessionId">Oturum Id degeri</param>
        /// <returns></returns>
        public Response<Status> DeleteRating(int movieId, string sessionId)
        {
            StringBuilder sb = new(DeleteRatingLink);
            sb.Replace("{movie_id}", movieId.ToString());
            if (sb is null)
                sb = new(DeleteRatingLink);
            sb.Append("&session_id=");
            sb.Append(sessionId);
            return Api.Delete<Status>(sb.ToString());
        }
        /// <summary>
        /// Filme verilen puani silmek icin kullanilan metod
        /// </summary>
        /// <param name="guestSessionId">Misafir Oturum Id degeri</param>
        /// <param name="movieId">Film Id degeri</param>
        /// <returns></returns>
        public Response<Status> DeleteRating(string guestSessionId, int movieId)
        {
            StringBuilder sb = new(DeleteRatingLink);
            sb.Replace("{movie_id}", movieId.ToString());
            if (sb is null)
                sb = new(DeleteRatingLink);
            sb.Append("&guest_session_id=");
            sb.Append(guestSessionId);
            return Api.Delete<Status>(sb.ToString());
        }
        #endregion

        #region Get Latest 		
        /// <summary>
        /// Son eklenen film bilgilerini donduren metod
        /// </summary>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<MovieItem> GetLatest(string? language = null)
        {
            StringBuilder sb = new(GetLatestLink);
            if (!string.IsNullOrEmpty(language))
            {
                sb.Append("&language=");
                sb.Append(language);
            }
            return Api.Get<MovieItem>(sb.ToString());
        }
        #endregion

        #region Get Now Playing 		
        /// <summary>
        /// Su anda gosterimde olan filmleri donduren metod
        /// </summary>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="page">Sayfa sayisi</param>
        /// <param name="region">Ulke/Bolge Kodu</param>
        /// <returns></returns>
        public Response<NowPlayingMovieContainer> GetNowPlaying(string? language = null, int? page = null,string? region=null)
        {
            StringBuilder sb = new(GetNowPlayingLink);
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
            return Api.Get<NowPlayingMovieContainer>(sb.ToString());
        }
        #endregion

        #region Get Popular 	
        /// <summary>
        /// TMDB sitesinde populer olan filmleri donduren metod
        /// </summary>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="page">Sayfa sayisi</param>
        /// <param name="region">Ulke/Bolge Kodu</param>
        /// <returns></returns>
        public Response<MovieContainer> GetPopular(string? language = null, int? page = null, string? region = null)
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
            return Api.Get<MovieContainer>(sb.ToString());
        }
        #endregion

        #region Get Top Rated 		
        /// <summary>
        /// TMDB sitesinde en yuksek oylari alan filmleri donduren metod
        /// </summary>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="page">Sayfa sayisi</param>
        /// <param name="region">Ulke/Bolge Kodu</param>
        /// <returns></returns>
        public Response<MovieContainer> GetTopRated(string? language = null, int? page = null, string? region = null)
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
            return Api.Get<MovieContainer>(sb.ToString());
        }
        #endregion

        #region Get Upcoming 		
        /// <summary>
        /// Yakinda gosterime girecek olan filmleri donduren metod
        /// </summary>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="page">Sayfa sayisi</param>
        /// <param name="region">Ulke/Bolge Kodu</param>
        /// <returns></returns>
        public Response<MovieContainer> GetUpcoming(string? language = null, int? page = null, string? region = null)
        {
            StringBuilder sb = new(GetUpcomingLink);
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
            return Api.Get<MovieContainer>(sb.ToString());
        }
        #endregion
    }
}
