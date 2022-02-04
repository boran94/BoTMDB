using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.ApiLinks
{
    /// <summary>
    /// https://developers.themoviedb.org/3/keywords Api links for Keywords section
    /// </summary>
    internal class Keywords
    {
        public static string GetDetails { get; } = "https://api.themoviedb.org/3/keyword/{keyword_id}?api_key=<<api_key>>";
        public static string GetMovies { get; } = "https://api.themoviedb.org/3/keyword/{keyword_id}/movies?api_key=<<api_key>>";

    }
}
