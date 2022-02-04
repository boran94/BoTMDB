using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.ApiLinks
{
    /// <summary>
    /// https://developers.themoviedb.org/3/trending Api links for Trending section
    /// </summary>
    static class Trending
    {
        public static string GetTrending { get; } = "https://api.themoviedb.org/3/trending/<<media_type>>/<<time_window>>?api_key=<<api_key>>";

    }
}
