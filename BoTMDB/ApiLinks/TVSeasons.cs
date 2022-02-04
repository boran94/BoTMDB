using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.ApiLinks
{
    /// <summary>
    /// https://developers.themoviedb.org/3/tv-seasons Api links for TV Seasons section
    /// </summary>
    static class TVSeasons
    {
        public static string GetDetails { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/season/{season_number}?api_key=<<api_key>>";
        public static string GetAccountStates { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/season/{season_number}/account_states?api_key=<<api_key>>";
        public static string GetAggregateCredits { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/season/{season_number}/aggregate_credits?api_key=<<api_key>>";
        public static string GetChanges { get; } = "https://api.themoviedb.org/3/tv/season/{season_number}/changes?api_key=<<api_key>>";
        public static string GetCredits { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/season/{season_number}/credits?api_key=<<api_key>>";
        public static string GetExternalIDs { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/season/{season_number}/external_ids?api_key=<<api_key>>";
        public static string GetImages { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/season/{season_number}/images?api_key=<<api_key>>";
        public static string GetTranslations { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/season/{season_number}/translations?api_key=<<api_key>>";
        public static string GetVideos { get; } = "https://api.themoviedb.org/3/tv/{tv_id}/season/{season_number}/videos?api_key=<<api_key>>";

    }
}
