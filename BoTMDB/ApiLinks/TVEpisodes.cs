using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.ApiLinks
{
    /// <summary>
    /// https://developers.themoviedb.org/3/tv-episodes Api links for TV Episodes section
    /// </summary>
    static class TVEpisodes
    {
        public static string GetDetails { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/season/{season_number}/episode/{episode_number}?api_key=<<api_key>>";
        public static string GetAccountStates { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/season/{season_number}/episode/{episode_number}/account_states?api_key=<<api_key>>";
        public static string GetChanges { get; } = "https://api.themoviedb.org/3/tv/episode/{episode_id}/changes?api_key=<<api_key>>";
        public static string GetCredits { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/season/{season_number}/episode/{episode_number}/credits?api_key=<<api_key>>";
        public static string GetExternalIDs { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/season/{season_number}/episode/{episode_number}/external_ids?api_key=<<api_key>>";
        public static string GetImages { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/season/{season_number}/episode/{episode_number}/images?api_key=<<api_key>>";
        public static string GetTranslations { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/season/{season_number}/episode/{episode_number}/translations?api_key=<<api_key>>";
        public static string RateTVEpisode { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/season/{season_number}/episode/{episode_number}/rating?api_key=<<api_key>>";
        public static string DeleteRating { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/season/{season_number}/episode/{episode_number}/rating?api_key=<<api_key>>";
        public static string GetVideos { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/season/{season_number}/episode/{episode_number}/videos?api_key=<<api_key>>";

    }
}
