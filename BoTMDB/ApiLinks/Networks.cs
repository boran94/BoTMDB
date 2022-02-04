using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.ApiLinks
{
    /// <summary>
    /// https://developers.themoviedb.org/3/networks Api links for Networks section
    /// </summary>
    static class Networks
    {
        public static string GetDetails { get; } = "https://api.themoviedb.org/3/network/{network_id}?api_key=<<api_key>>";
        public static string GetAlternativeNames    { get; } = "https://api.themoviedb.org/3/network/{network_id}/alternative_names?api_key=<<api_key>>";
        public static string GetImages { get; } = "https://api.themoviedb.org/3/network/{network_id}/images?api_key=<<api_key>>";

    }
}
