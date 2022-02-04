using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.ApiLinks
{
    /// <summary>
    /// https://developers.themoviedb.org/3/lists Api links for Lists section
    /// </summary>
    static class Lists
    {
        public static string GetDetails { get; } = "https://api.themoviedb.org/3/list/{list_id}?api_key=<<api_key>>";
        public static string CheckItemStatus { get; } = "https://api.themoviedb.org/3/list/{list_id}/item_status?api_key=<<api_key>>";
        public static string CreateList { get; } = "https://api.themoviedb.org/3/list?api_key=<<api_key>>";
        public static string AddMovie { get; } = "https://api.themoviedb.org/3/list/{list_id}/add_item?api_key=<<api_key>>";
        public static string RemoveMovie { get; } = "https://api.themoviedb.org/3/list/{list_id}/remove_item?api_key=<<api_key>>";
        public static string ClearList { get; } = "https://api.themoviedb.org/3/list/{list_id}/clear?api_key=<<api_key>>";
        public static string DeleteList { get; } = "https://api.themoviedb.org/3/list/{list_id}?api_key=<<api_key>>";

    }
}
