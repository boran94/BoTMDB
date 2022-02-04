using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.ApiLinks
{
    /// <summary>
    /// https://developers.themoviedb.org/3/people Api links for People section
    /// </summary>
    static class People
    {
        public static string GetDetails { get; } = "https://api.themoviedb.org/3/person/{person_id}?api_key=<<api_key>>";
        public static string GetChanges { get; } = "https://api.themoviedb.org/3/person/{person_id}/changes?api_key=<<api_key>>";
        public static string GetMovieCredits { get; } = "https://api.themoviedb.org/3/person/{person_id}/movie_credits?api_key=<<api_key>>";
        public static string GetTVCredits { get; } = "https://api.themoviedb.org/3/person/{person_id}/tv_credits?api_key=<<api_key>>";
        public static string GetCombinedCredits { get; } = "https://api.themoviedb.org/3/person/{person_id}/combined_credits?api_key=<<api_key>>";
        public static string GetExternalIDs { get; } = "https://api.themoviedb.org/3/person/{person_id}/external_ids?api_key=<<api_key>>";
        public static string GetImages { get; } = "https://api.themoviedb.org/3/person/{person_id}/images?api_key=<<api_key>>";
        public static string GetTaggedImages { get; } = "https://api.themoviedb.org/3/person/{person_id}/tagged_images?api_key=<<api_key>>";
        public static string GetTranslations { get; } = "https://api.themoviedb.org/3/person/{person_id}/translations?api_key=<<api_key>>";
        public static string GetLatest { get; } = "https://api.themoviedb.org/3/person/latest?api_key=<<api_key>>";
        public static string GetPopular { get; } = "https://api.themoviedb.org/3/person/popular?api_key=<<api_key>>";

    }
}
