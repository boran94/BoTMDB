using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.ApiLinks
{
    /// <summary>
    /// https://developers.themoviedb.org/3/search Api links for Search section
    /// </summary>
    static class Search
    {
        public static string SearchCompanies { get; } = "https://api.themoviedb.org/3/search/company?api_key=<<api_key>>";
        public static string SearchCollections { get; } = "https://api.themoviedb.org/3/search/collection?api_key=<<api_key>>";
        public static string SearchKeywords { get; } = "https://api.themoviedb.org/3/search/keyword?api_key=<<api_key>>";
        public static string SearchMovies { get; } = "https://api.themoviedb.org/3/search/movie?api_key=<<api_key>>";
        public static string MultiSearch { get; } = "https://api.themoviedb.org/3/search/multi?api_key=<<api_key>>";
        public static string SearchPeople { get; } = "https://api.themoviedb.org/3/search/person?api_key=<<api_key>>";
        public static string SearchTVShows { get; } = "https://api.themoviedb.org/3/search/tv?api_key=<<api_key>>";

    }
}
