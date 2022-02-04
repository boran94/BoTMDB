using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.ApiLinks
{
    /// <summary>
    /// https://developers.themoviedb.org/3/companies Api links for Companies section
    /// </summary>
    static class Companies
    {
        public static string GetDetails { get; } = "https://api.themoviedb.org/3/company/<<company_id>>?api_key=<<api_key>>";
        public static string GetAlternativeNames { get; } = "https://api.themoviedb.org/3/company/<<company_id>>/alternative_names?api_key=<<api_key>>";
        public static string GetImages { get; } = "https://api.themoviedb.org/3/company/<<company_id>>/images?api_key=<<api_key>>";
    }
}
