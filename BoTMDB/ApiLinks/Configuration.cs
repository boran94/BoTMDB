using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.ApiLinks
{
    /// <summary>
    /// https://developers.themoviedb.org/3/configuration Api links for Configuration section
    /// </summary>
    static class Configuration
    {
        public static string GetAPIConfiguration { get; } = "https://api.themoviedb.org/3/configuration?api_key=<<api_key>>";
        public static string GetCountries { get; } = "https://api.themoviedb.org/3/configuration/countries?api_key=<<api_key>>";
        public static string GetJobs { get; } = "https://api.themoviedb.org/3/configuration/jobs?api_key=<<api_key>>";
        public static string GetLanguages { get; } = "https://api.themoviedb.org/3/configuration/languages?api_key=<<api_key>>";
        public static string GetPrimaryTranslations { get; } = "https://api.themoviedb.org/3/configuration/primary_translations?api_key=<<api_key>>";
        public static string GetTimezones{ get; } = "https://api.themoviedb.org/3/configuration/timezones?api_key=<<api_key>>";

    }
}
