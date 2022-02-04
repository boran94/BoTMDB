using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.ApiLinks
{
    /// <summary>
    /// https://developers.themoviedb.org/3/authentication Api links for Authentication section
    /// </summary>
    static class Authentication
    {

        public static  string CreateGuestSession { get; } = "https://api.themoviedb.org/3/authentication/guest_session/new?api_key=<<api_key>>";
        public static  string CreateRequestToken { get; } = "https://api.themoviedb.org/3/authentication/token/new?api_key=<<api_key>>";
        public static  string CreateSession { get; } = "https://api.themoviedb.org/3/authentication/session/new?api_key=<<api_key>>";
        public static  string CreateSessionWithLogin { get; } = "https://api.themoviedb.org/3/authentication/token/validate_with_login?api_key=<<api_key>>";
        public static  string CreateSessionFromV4AccessToken { get; } = "https://api.themoviedb.org/3/authentication/session/convert/4?api_key=<<api_key>>";
        public static string DeleteSession { get; } = "https://api.themoviedb.org/3/authentication/session?api_key=<<api_key>>";
    }
}
