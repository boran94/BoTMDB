using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.ApiLinks
{
    /// <summary>
    /// https://developers.themoviedb.org/3/watch-providers Api links for Watch Providers section
    /// </summary>
    static class WatchProviders
    {
        public static string GetAvailableRegions { get; } = "https://api.themoviedb.org/3/watch/providers/regions?api_key=<<api_key>>";
        public static string GetMovieProviders { get; } = "https://api.themoviedb.org/3/watch/providers/movie?api_key=<<api_key>>";
        public static string GetTVProviders { get; } = "https://api.themoviedb.org/3/watch/providers/tv?api_key=<<api_key>>";

    }
}
