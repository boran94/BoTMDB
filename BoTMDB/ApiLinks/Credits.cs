using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.ApiLinks
{
    /// <summary>
    /// https://developers.themoviedb.org/3/credits Api links for Credits section
    /// </summary>
    static class Credits
    {
        public static string GetDetails { get; } = "https://api.themoviedb.org/3/credit/<<credit_id>>?api_key=<<api_key>>";
    }
}
