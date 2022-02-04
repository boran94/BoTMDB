using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.ApiLinks
{
    /// <summary>
    /// https://developers.themoviedb.org/3/movies Api links for Movies section
    /// </summary>
    static class Movies
    {
        public static string GetDetails { get; } = "https://api.themoviedb.org/3/movie/{movie_id}?api_key=<<api_key>>";
        public static string GetAccountStates { get; } = "https://api.themoviedb.org/3/movie/{movie_id}/account_states?api_key=<<api_key>>";
        public static string GetAlternativeTitles { get; } = "https://api.themoviedb.org/3/movie/{movie_id}/alternative_titles?api_key=<<api_key>>";
        public static string GetChanges { get; } = "https://api.themoviedb.org/3/movie/{movie_id}/changes?api_key=<<api_key>>";
        public static string GetCredits { get; } = "https://api.themoviedb.org/3/movie/{movie_id}/credits?api_key=<<api_key>>";
        public static string GetExternalIDs { get; } = "https://api.themoviedb.org/3/movie/{movie_id}/external_ids?api_key=<<api_key>>";
        public static string GetImages { get; } = "https://api.themoviedb.org/3/movie/{movie_id}/images?api_key=<<api_key>>";
        public static string GetKeywords { get; } = "https://api.themoviedb.org/3/movie/{movie_id}/keywords?api_key=<<api_key>>";
        public static string GetLists { get; } = "https://api.themoviedb.org/3/movie/{movie_id}/lists?api_key=<<api_key>>";
        public static string GetRecommendations { get; } = "https://api.themoviedb.org/3/movie/{movie_id}/recommendations?api_key=<<api_key>>";
        public static string GetReleaseDates { get; } = "https://api.themoviedb.org/3/movie/{movie_id}/release_dates?api_key=<<api_key>>";
        public static string GetReviews { get; } = "https://api.themoviedb.org/3/movie/{movie_id}/reviews?api_key=<<api_key>>";
        public static string GetSimilarMovies { get; } = "https://api.themoviedb.org/3/movie/{movie_id}/similar?api_key=<<api_key>>";
        public static string GetTranslations { get; } = "https://api.themoviedb.org/3/movie/{movie_id}/translations?api_key=<<api_key>>";
        public static string GetVideos { get; } = "https://api.themoviedb.org/3/movie/{movie_id}/videos?api_key=<<api_key>>";
        public static string GetWatchProviders { get; } = "https://api.themoviedb.org/3/movie/{movie_id}/watch/providers?api_key=<<api_key>>";
        public static string RateMovie { get; } = "https://api.themoviedb.org/3/movie/{movie_id}/rating?api_key=<<api_key>>";
        public static string DeleteRating { get; } = "https://api.themoviedb.org/3/movie/{movie_id}/rating?api_key=<<api_key>>";
        public static string GetLatest { get; } = "https://api.themoviedb.org/3/movie/latest?api_key=<<api_key>>";
        public static string GetNowPlaying { get; } = "https://api.themoviedb.org/3/movie/now_playing?api_key=<<api_key>>";
        public static string GetPopular { get; } = "https://api.themoviedb.org/3/movie/popular?api_key=<<api_key>>";
        public static string GetTopRated { get; } = "https://api.themoviedb.org/3/movie/top_rated?api_key=<<api_key>>";
        public static string GetUpcoming { get; } = "https://api.themoviedb.org/3/movie/upcoming?api_key=<<api_key>>";


    }
}
