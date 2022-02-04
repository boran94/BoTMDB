using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.ApiLinks
{
    /// <summary>
    /// https://developers.themoviedb.org/3/certifications Api links for Certifications section
    /// </summary>
    public static class Certifications
    {
        /// <summary>
        /// </summary>
        public static string GetMovieCertifications { get; } = "https://api.themoviedb.org/3/certification/movie/list?api_key=<<api_key>>";
        /// <summary>
        /// </summary>
        public static string GetTVCertifications { get; } = "https://api.themoviedb.org/3/certification/tv/list?api_key=<<api_key>>";
    }
}
