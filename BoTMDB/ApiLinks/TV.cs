using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.ApiLinks
{
    /// <summary>
    /// https://developers.themoviedb.org/3/tv Api links for TV section
    /// </summary>
    static class TV
    {

        public static string GetDetails { get; } = "https://api.themoviedb.org/3/tv/{tv_id}?api_key=<<api_key>>";
        public static string GetAccountStates { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/account_states?api_key=<<api_key>>";
        public static string GetAggregateCredits { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/aggregate_credits?api_key=<<api_key>>";
        public static string GetAlternativeTitles { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/alternative_titles?api_key=<<api_key>>";
        public static string GetChanges { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/changes?api_key=<<api_key>>";
        public static string GetContentRatings { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/content_ratings?api_key=<<api_key>>";
        public static string GetCredits { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/credits?api_key=<<api_key>>";
        public static string GetEpisodeGroups { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/episode_groups?api_key=<<api_key>>";
        public static string GetExternalIDs { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/external_ids?api_key=<<api_key>>";
        public static string GetImages { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/images?api_key=<<api_key>>";
        public static string GetKeywords { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/keywords?api_key=<<api_key>>";
        public static string GetRecommendations { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/recommendations?api_key=<<api_key>>";
        public static string GetReviews { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/reviews?api_key=<<api_key>>";
        public static string GetScreenedTheatrically { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/screened_theatrically?api_key=<<api_key>>";
        public static string GetSimilarTVShows { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/similar?api_key=<<api_key>>";
        public static string GetTranslations { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/translations?api_key=<<api_key>>";
        public static string GetVideos { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/videos?api_key=<<api_key>>";
        public static string GetWatchProviders { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/watch/providers?api_key=<<api_key>>";
        public static string RateTVShow { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/rating?api_key=<<api_key>>";
        public static string DeleteRating { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/rating?api_key=<<api_key>>";
        public static string GetLatest { get; } = "https://api.themoviedb.org/3/tv/latest?api_key=<<api_key>>";
        public static string GetTVAiringToday { get; } = "https://api.themoviedb.org/3/tv/airing_today?api_key=<<api_key>>";
        public static string GetTVOnTheAir { get; } = "https://api.themoviedb.org/3/tv/on_the_air?api_key=<<api_key>>";
        public static string GetPopular { get; } = "https://api.themoviedb.org/3/tv/popular?api_key=<<api_key>>";
        public static string GetTopRated { get; } = "https://api.themoviedb.org/3/tv/top_rated?api_key=<<api_key>>";

    }
}
