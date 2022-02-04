using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.ApiLinks
{
    /// <summary>
    /// https://developers.themoviedb.org/3/tv-episode-groups Api links for TV Episode Groups section
    /// </summary>
    static class TVEpisodeGroups
    {
        public static string GetDetails { get; } = "https://api.themoviedb.org/3/tv/episode_group/{id}?api_key=<<api_key>>";

    }
}
