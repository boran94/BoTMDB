using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.ApiLinks
{
    /// <summary>
    /// https://developers.themoviedb.org/3/account Api links for account section
    /// </summary>
    static class Account
    {
        /// <summary>
        /// </summary>
        public static string GetDetails { get; } = "https://api.themoviedb.org/3/account?api_key=<<api_key>>";
        /// <summary>
        /// </summary>
        public static string GetCreatedLists { get; } = "https://api.themoviedb.org/3/account/{account_id}/lists?api_key=<<api_key>>";
        /// <summary>
        /// </summary>
        public static string GetFavoriteMovies { get; } = "https://api.themoviedb.org/3/account/{account_id}/favorite/movies?api_key=<<api_key>>";
        /// <summary>
        /// </summary>
        public static string GetFavoriteTVShows { get; } = "https://api.themoviedb.org/3/account/{account_id}/favorite/tv?api_key=<<api_key>>";
        /// <summary>
        /// </summary>
        public static string MarkAsFavorite { get; } = "https://api.themoviedb.org/3/account/{account_id}/favorite?api_key=<<api_key>>";
        /// <summary>
        /// </summary>
        public static string GetRatedMovies { get; } = "https://api.themoviedb.org/3/account/{account_id}/rated/movies?api_key=<<api_key>>";
        /// <summary>
        /// </summary>
        public static string GetRatedTVShows { get; } = "https://api.themoviedb.org/3/account/{account_id}/rated/tv?api_key=<<api_key>>";
        /// <summary>
        /// </summary>
        public static string GetRatedTVEpisodes { get; } = "https://api.themoviedb.org/3/account/{account_id}/rated/tv/episodes?api_key=<<api_key>>";
        /// <summary>
        /// </summary>
        public static string GetMovieWatchlist { get; } = "https://api.themoviedb.org/3/account/{account_id}/watchlist/movies?api_key=<<api_key>>";
        /// <summary>
        /// </summary>
        public static string GetTVShowWatchlist { get; } = "https://api.themoviedb.org/3/account/{account_id}/watchlist/tv?api_key=<<api_key>>";
        /// <summary>
        /// </summary>
        public static string AddToWatchlist { get; } = "https://api.themoviedb.org/3/account/{account_id}/watchlist?api_key=<<api_key>>";


    }
}
