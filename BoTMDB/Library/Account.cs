using BoTMDB.Models.Account;
using BoTMDB.Models.Movies;
using BoTMDB.Models.Tv;
using BoTMDB.Models.TvEpisodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Library
{

    /// <summary>
    /// Hesapla ile ilgili metodlarin bulundugu sinif
    /// Bu sinif icerisinde bulunan metodlar
    /// <list type="bullet">
    /// <item><see cref="GetDetails(string)"/></item>
    /// <item><see cref="GetCreatedLists(string, int, string?, int?)"/></item>
    /// <item><see cref="GetFavoriteMovies(string, int, string?, int?, SortByCreated?)"/></item>
    /// <item><see cref="GetFavoriteTVShows(string, int, string?, int?, SortByCreated?)"/></item>
    /// <item><see cref="MarkAsFavorite(string, int, int, MediaType, bool)"/></item>
    /// <item><see cref="GetRatedMovies(string, int, string?, int?, SortByCreated?)"/></item>
    /// <item><see cref="GetRatedTVEpisodes(string, int, string?, int?, SortByCreated?)"/></item>
    /// <item><see cref="GetRatedTVShows(string, int, string?, int?, SortByCreated?)"/></item>
    /// <item><see cref="GetMovieWatchlist(string, int, string?, int?, SortByCreated?)"/></item>
    /// <item><see cref="GetTVShowWatchlist(string, int, string?, int?, SortByCreated?)"/></item>
    /// <item><see cref="AddToWatchlist(string, int, int, MediaType, bool)"/></item>
    /// </list>
    /// <see href="https://developers.themoviedb.org/3/account"/>
    /// </summary>
    public class Account
    {
        private string ApiKey { get; set; }
        private string GetDetailsLink { get; set; }
        private string GetCreatedListsLink { get; set; }
        private string GetFavoriteMoviesLink { get; set; }
        private string GetFavoriteTVShowsLink { get; set; }
        private string MarkAsFavoriteLink { get; set; }
        private string GetRatedMoviesLink { get; set; }
        private string GetRatedTVShowsLink { get; set; }
        private string GetRatedTVEpisodesLink { get; set; }
        private string GetMovieWatchlistLink { get; set; }
        private string GetTVShowWatchlistLink { get; set; }
        private string AddToWatchlistLink { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey">Api Key Degeri</param>
        public Account(string apiKey)
        {
            ApiKey = apiKey;

            GetDetailsLink = ApiLinks.Account.GetDetails.Replace("<<api_key>>", ApiKey);
            GetCreatedListsLink = ApiLinks.Account.GetCreatedLists.Replace("<<api_key>>", ApiKey);
            GetFavoriteMoviesLink = ApiLinks.Account.GetFavoriteMovies.Replace("<<api_key>>", ApiKey);
            GetFavoriteTVShowsLink = ApiLinks.Account.GetFavoriteTVShows.Replace("<<api_key>>", ApiKey);
            MarkAsFavoriteLink = ApiLinks.Account.MarkAsFavorite.Replace("<<api_key>>", ApiKey);
            GetRatedMoviesLink = ApiLinks.Account.GetRatedMovies.Replace("<<api_key>>", ApiKey);
            GetRatedTVShowsLink = ApiLinks.Account.GetRatedTVShows.Replace("<<api_key>>", ApiKey);
            GetRatedTVEpisodesLink = ApiLinks.Account.GetRatedTVEpisodes.Replace("<<api_key>>", ApiKey);
            GetMovieWatchlistLink = ApiLinks.Account.GetMovieWatchlist.Replace("<<api_key>>", ApiKey);
            GetTVShowWatchlistLink = ApiLinks.Account.GetTVShowWatchlist.Replace("<<api_key>>", ApiKey);
            AddToWatchlistLink = ApiLinks.Account.AddToWatchlist.Replace("<<api_key>>", ApiKey);

        }

        #region GetDetails
        /// <summary>
        /// Hesabiniz hakkindaki bilgileri almak icin kullanilan metod
        /// </summary>
        /// <param name="sessionId">Oturum Id degeri</param>
        /// <returns></returns>
        public Response<AccountItem> GetDetails(string sessionId)
        {
            StringBuilder sb = new(GetDetailsLink);
            sb.Append("&session_id=");
            sb.Append(sessionId);

            return Api.Get<AccountItem>(sb.ToString());

        }
        #endregion

        #region GetCreatedLists
        /// <summary>
        /// Olusturulmus olan listeleri donduren metod
        /// </summary>
        /// <param name="sessionId">Oturum Id degeri</param>
        /// <param name="accountId">Hesap Numarasi</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="page">Sayfa Numarasi</param>
        /// <returns></returns>
        public Response<ListContainer> GetCreatedLists(string sessionId,int accountId,string? language=null,int? page=null)
        {
            StringBuilder sb = new(GetCreatedListsLink);
            sb.Replace("{account_id}", accountId.ToString());
            sb.Append("&session_id=");
            sb.Append(sessionId);

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
            return Api.Get<ListContainer>(sb.ToString());

        }
        #endregion

        #region GetFavoriteMovies
        /// <summary>
        /// Favorilere eklenmis olan filmleri donduren metod
        /// </summary>
        /// <param name="sessionId">Oturum Id degeri</param>
        /// <param name="accountId">Hesap Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="page">Sayfa sayisi</param>
        /// <param name="sortBy">Siralama Turu</param>
        /// <returns></returns>
        public Response<MovieContainer> GetFavoriteMovies(string sessionId,int accountId,string? language=null,int? page=null,SortByCreated? sortBy=null)
        {
            StringBuilder sb=new(GetFavoriteMoviesLink);

            sb.Replace("{account_id}", accountId.ToString());
            sb.Append("&session_id=");
            sb.Append(sessionId);
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
            if (sortBy is not null)
            {
                sb.Append("&sort_by=");
                if (sortBy == SortByCreated.Asc)
                    sb.Append("created_at.asc");
                else
                    sb.Append("created_at.desc");
            }
            return Api.Get<MovieContainer>(sb.ToString());

        }
        #endregion

        #region GetFavoriteTVShows
        /// <summary>
        /// Favorilere eklenmis olan Tv sovlari donduren metod
        /// </summary>
        /// <param name="sessionId">Oturum Id degeri</param>
        /// <param name="accountId">Hesap Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="page">Sayfa sayisi</param>
        /// <param name="sortBy">Siralama Turu</param>
        /// <returns></returns>
        public Response<TvContainer> GetFavoriteTVShows(string sessionId, int accountId, string? language = null, int? page = null, SortByCreated? sortBy = null)
        {
            StringBuilder sb = new(GetFavoriteTVShowsLink);

            sb.Replace("{account_id}", accountId.ToString());
            sb.Append("&session_id=");
            sb.Append(sessionId);
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
            if (sortBy is not null)
            {
                sb.Append("&sort_by=");
                if (sortBy == SortByCreated.Asc)
                    sb.Append("created_at.asc");
                else
                    sb.Append("created_at.desc");
            }
            return Api.Get<TvContainer>(sb.ToString());

        }
        #endregion

        #region MarkAsFavorite
        /// <summary>
        /// Film veya tv sovuna favori eklemek icin kullanilan metod
        /// </summary>
        /// <param name="sessionId">Oturum Id degeri</param>
        /// <param name="accountId">Hesap Id degeri</param>
        /// <param name="mediaId">Film veya Tv sov Id degeri</param>
        /// <param name="mediaType">Medya turu</param>
        /// <param name="favorite"></param>
        /// <returns></returns>
        public Response<Status> MarkAsFavorite(string sessionId, int accountId, int mediaId, MediaType mediaType, bool favorite)
        {
            StringBuilder sb = new(MarkAsFavoriteLink);
            sb.Append("&session_id=");
            sb.Append(sessionId);
            sb.Replace("{account_id}", accountId.ToString());
            return Api.Post<Status>(sb.ToString(), JsonContent.Create(new { media_id = mediaId, favorite = favorite.ToString().ToLower(), media_type = mediaType.ToString().ToLower() }));
           
        }
        #endregion

        #region GetRatedMovies
        /// <summary>
        /// Oy verilmis olan filmleri donduren metod
        /// </summary>
        /// <param name="sessionId">Oturum Id degeri</param>
        /// <param name="accountId">Hesap Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="page">Sayfa sayisi</param>
        /// <param name="sortBy">Siralama Turu</param>
        /// <returns></returns>
        public Response<RatedMovieContainer> GetRatedMovies(string sessionId, int accountId, string? language = null, int? page = null, SortByCreated? sortBy = null)
        {
            StringBuilder sb = new(GetRatedMoviesLink);

            sb.Replace("{account_id}", accountId.ToString());
            sb.Append("&session_id=");
            sb.Append(sessionId);
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
            if (sortBy is not null)
            {
                sb.Append("&sort_by=");
                if (sortBy == SortByCreated.Asc)
                    sb.Append("created_at.asc");
                else
                    sb.Append("created_at.desc");
            }
            return Api.Get<RatedMovieContainer>(sb.ToString());

        }
        #endregion

        #region GetRatedTVShows
        /// <summary>
        /// Oy  verilmis olan Tv sovlarini donduren metod
        /// </summary>
        /// <param name="sessionId">Oturum Id degeri</param>
        /// <param name="accountId">Hesap Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="page">Sayfa sayisi</param>
        /// <param name="sortBy">Siralama Turu</param>
        /// <returns></returns>
        public Response<RatedTvContainer> GetRatedTVShows(string sessionId, int accountId, string? language = null, int? page = null, SortByCreated? sortBy = null)
        {
            StringBuilder sb = new(GetRatedTVShowsLink);

            sb.Replace("{account_id}", accountId.ToString());
            sb.Append("&session_id=");
            sb.Append(sessionId);
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
            if (sortBy is not null)
            {
                sb.Append("&sort_by=");
                if (sortBy == SortByCreated.Asc)
                    sb.Append("created_at.asc");
                else
                    sb.Append("created_at.desc");
            }
            return Api.Get<RatedTvContainer>(sb.ToString());

        }
        #endregion

        #region GetRatedTVEpisodes
        /// <summary>
        /// Oy  verilmis olan Tv bolumlerini donduren metod
        /// </summary>
        /// <param name="sessionId">Oturum Id degeri</param>
        /// <param name="accountId">Hesap Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="page">Sayfa sayisi</param>
        /// <param name="sortBy">Siralama Turu</param>
        /// <returns></returns>
        public Response<RatedEpisodeContainer> GetRatedTVEpisodes(string sessionId, int accountId, string? language = null, int? page = null, SortByCreated? sortBy = null)
        {
            StringBuilder sb = new(GetRatedTVEpisodesLink);

            sb.Replace("{account_id}", accountId.ToString());
            sb.Append("&session_id=");
            sb.Append(sessionId);
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
            if (sortBy is not null)
            {
                sb.Append("&sort_by=");
                if (sortBy == SortByCreated.Asc)
                    sb.Append("created_at.asc");
                else
                    sb.Append("created_at.desc");
            }
            return Api.Get<RatedEpisodeContainer>(sb.ToString());

        }
        #endregion

        #region GetMovieWatchlist
        /// <summary>
        /// Izleme listesine eklenmis olan filmleri donduren metod
        /// </summary>
        /// <param name="sessionId">Oturum Id degeri</param>
        /// <param name="accountId">Hesap Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="page">Sayfa sayisi</param>
        /// <param name="sortBy">Siralama Turu</param>
        /// <returns></returns>
        public Response<MovieContainer> GetMovieWatchlist(string sessionId, int accountId, string? language = null, int? page = null, SortByCreated? sortBy = null)
        {
            StringBuilder sb = new(GetMovieWatchlistLink);

            sb.Replace("{account_id}", accountId.ToString());
            sb.Append("&session_id=");
            sb.Append(sessionId);
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
            if (sortBy is not null)
            {
                sb.Append("&sort_by=");
                if (sortBy == SortByCreated.Asc)
                    sb.Append("created_at.asc");
                else
                    sb.Append("created_at.desc");
            }
            return Api.Get<MovieContainer>(sb.ToString());

        }
        #endregion

        #region GetTVShowWatchlist
        /// <summary>
        /// Izleme listesine eklenmis olan Tv sovlari donduren metod
        /// </summary>
        /// <param name="sessionId">Oturum Id degeri</param>
        /// <param name="accountId">Hesap Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="page">Sayfa sayisi</param>
        /// <param name="sortBy">Siralama Turu</param>
        /// <returns></returns>
        public Response<TvContainer> GetTVShowWatchlist(string sessionId, int accountId, string? language = null, int? page = null, SortByCreated? sortBy = null)
        {
            StringBuilder sb = new(GetTVShowWatchlistLink);

            sb.Replace("{account_id}", accountId.ToString());
            sb.Append("&session_id=");
            sb.Append(sessionId);
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
            if (sortBy is not null)
            {
                sb.Append("&sort_by=");
                if (sortBy == SortByCreated.Asc)
                    sb.Append("created_at.asc");
                else
                    sb.Append("created_at.desc");
            }
            return Api.Get<TvContainer>(sb.ToString());

        }
        #endregion

        #region AddToWatchlist
        /// <summary>
        /// Film veya tv sovuna izleme listesine eklemek icin kullanilan metod
        /// </summary>
        /// <param name="sessionId">Oturum Id degeri</param>
        /// <param name="accountId">Hesap Id degeri</param>
        /// <param name="mediaId">Film veya Tv sov Id degeri</param>
        /// <param name="mediaType">Medya turu</param>
        /// <param name="watchlist"></param>
        /// <returns></returns>
        public Response<Status> AddToWatchlist(string sessionId, int accountId, int mediaId, MediaType mediaType, bool watchlist)
        {
            StringBuilder sb = new(AddToWatchlistLink);
            sb.Append("&session_id=");
            sb.Append(sessionId);
            sb.Replace("{account_id}", accountId.ToString());
            return Api.Post<Status>(sb.ToString(), JsonContent.Create(new { media_id = mediaId, watchlist = watchlist.ToString().ToLower(), media_type = mediaType.ToString().ToLower() }));

        }
        #endregion
    }
}
