using BoTMDB.Models.Movies;
using BoTMDB.Models.Tv;
using BoTMDB.Models.TvEpisodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Library
{
    /// <summary>
    /// Misafir oturumu ile ilgili metodlarin bulundugu sinif
    /// Bu sinif icerisinde bulunan metodlar
    /// <list type="bullet">
    /// <item><see cref="GetRatedMovies(string, string?, SortByCreated?)"/></item>
    /// <item><see cref="GetRatedTVEpisodes(string, string?, SortByCreated?)"/></item>
    /// <item><see cref="GetRatedTVShows(string, string?, SortByCreated?)"/></item>
    /// </list>
    /// <see href="https://developers.themoviedb.org/3/guest-sessions"/>
    /// </summary>
    public class GuestSessions
    {
        private string ApiKey { get; set; }
        private string GetRatedMoviesLink { get; set; }
        private string GetRatedTVShowsLink { get; set; }
        private string GetRatedTVEpisodesLink { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey">Api Key Degeri</param>

        public GuestSessions(string apiKey)
        {
            ApiKey = apiKey;
            GetRatedMoviesLink = ApiLinks.GuestSessions.GetRatedMovies.Replace("<<api_key>>", ApiKey);
            GetRatedTVShowsLink = ApiLinks.GuestSessions.GetRatedTVShows.Replace("<<api_key>>", ApiKey);
            GetRatedTVEpisodesLink = ApiLinks.GuestSessions.GetRatedTVEpisodes.Replace("<<api_key>>", ApiKey);

        }

        private Response<T> GetRated<T>(string apiLink, string? language = null, SortByCreated? sortBy = null) 
        {

            StringBuilder sb = new(apiLink);
            if (!string.IsNullOrEmpty(language))
            {
                sb.Append("&language=");
                sb.Append(language);
            }
            if (sortBy is not null)
            {
                sb.Append("&sort_by=");
                if (sortBy==SortByCreated.Asc)
                    sb.Append("created_at.asc");
                else
                    sb.Append("created_at.desc");
            }

            return Api.Get<T>(apiLink);
        }

        #region GetRatedMovies
        /// <summary>
        /// Oy verilmis olan filmleri donduren metod
        /// </summary>
        /// <param name="guestSessionId">Misafir Oturum Id Degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="sortBy">Siralama turu</param>
        /// <returns></returns>
        public Response<MovieContainer> GetRatedMovies(string guestSessionId,string? language=null, SortByCreated? sortBy=null)
        {
            return GetRated<MovieContainer>(GetRatedMoviesLink.Replace("{guest_session_id}", guestSessionId));
        }
        #endregion

        #region GetRatedTVShows
        /// <summary>
        /// Oy verilmis olan Tv Sovlarini donduren metod
        /// </summary>
        /// <param name="guestSessionId">Misafir Oturum Id Degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="sortBy">Siralama turu</param>
        /// <returns></returns>
        public Response<TvContainer> GetRatedTVShows(string guestSessionId, string? language = null, SortByCreated? sortBy = null)
        {
            return GetRated<TvContainer>(GetRatedTVShowsLink.Replace("{guest_session_id}", guestSessionId));
        }
        #endregion

        #region GetRatedTVEpisodes
        /// <summary>
        /// Oy verilmis olan Tv bolumlerini donduren metod
        /// </summary>
        /// <param name="guestSessionId">Misafir Oturum Id Degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="sortBy">Siralama turu</param>
        /// <returns></returns>
        public Response<EpisodeContainer> GetRatedTVEpisodes(string guestSessionId, string? language = null, SortByCreated? sortBy = null)
        {
            return GetRated<EpisodeContainer>(GetRatedTVEpisodesLink.Replace("{guest_session_id}", guestSessionId));
        }
        #endregion
    }
}
