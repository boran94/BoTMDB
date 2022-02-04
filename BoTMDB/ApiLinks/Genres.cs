using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.ApiLinks
{
    /// <summary>
    /// https://developers.themoviedb.org/3/genres Api links for Genres section
    /// </summary>
    internal class Genres
    {
        public static string GetMovieList { get; } = "https://api.themoviedb.org/3/genre/movie/list?api_key=<<api_key>>";
        public static string GetTVList { get; } = "https://api.themoviedb.org/3/genre/tv/list?api_key=<<api_key>>";
    }
}
