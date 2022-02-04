using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.ApiLinks
{
    /// <summary>
    /// https://developers.themoviedb.org/3/guest-sessions Api links for Guest Sessions section
    /// </summary>
    static class GuestSessions
    {
        public static string GetRatedMovies { get; } = "https://api.themoviedb.org/3/guest_session/{guest_session_id}/rated/movies?api_key=<<api_key>>";
        public static string GetRatedTVShows { get; } = "https://api.themoviedb.org/3/guest_session/{guest_session_id}/rated/tv?api_key=<<api_key>>";
        public static string GetRatedTVEpisodes { get; } = "https://api.themoviedb.org/3/guest_session/{guest_session_id}/rated/tv/episodes?api_key=<<api_key>>";

    }
}
