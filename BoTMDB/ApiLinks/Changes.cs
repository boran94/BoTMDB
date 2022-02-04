using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.ApiLinks
{
    /// <summary>
    /// https://developers.themoviedb.org/3/changes Api links for Changes section
    /// </summary>
    static class Changes
    {
        public static string GetMovieChangeList { get; } = "https://api.themoviedb.org/3/movie/changes?api_key=<<api_key>>";
        public static string GetTVChangeList { get; } = "https://api.themoviedb.org/3/tv/changes?api_key=<<api_key>>";
        public static string GetPersonChangeList { get; } = "https://api.themoviedb.org/3/person/changes?api_key=<<api_key>>";
    }
}
