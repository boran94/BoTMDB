using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.ApiLinks
{
    /// <summary>
    /// https://developers.themoviedb.org/3/discover Api links for Discover section
    /// </summary>
    static class Discover
    {
        public static string MovieDiscover { get; } = "https://api.themoviedb.org/3/discover/movie?api_key=<<api_key>>";
        public static string TVDiscover { get; } = "https://api.themoviedb.org/3/discover/tv?api_key=<<api_key>>";
    }
}
