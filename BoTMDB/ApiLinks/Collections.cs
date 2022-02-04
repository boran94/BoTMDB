using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.ApiLinks
{

    /// <summary>
    /// https://developers.themoviedb.org/3/collections Api links for Collections section
    /// </summary>
    static class Collections
    {
        public static string GetDetails { get; } = "https://api.themoviedb.org/3/collection/<<collection_id>>?api_key=<<api_key>>";
        public static string GetImages { get; } = "https://api.themoviedb.org/3/collection/<<collection_id>>/images?api_key=<<api_key>>";
        public static string GetTranslations { get; } = "https://api.themoviedb.org/3/collection/<<collection_id>>/translations?api_key=<<api_key>>";
    }
}
