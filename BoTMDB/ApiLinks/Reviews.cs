using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.ApiLinks
{
    /// <summary>
    /// https://developers.themoviedb.org/3/reviews Api links for Reviews section
    /// </summary>
    static class Reviews
    {
        public static string GetDetails { get; } = "https://api.themoviedb.org/3/review/{review_id}?api_key=<<api_key>>";

    }
}
