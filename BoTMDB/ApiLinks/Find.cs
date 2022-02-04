using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.ApiLinks
{

    /// <summary>
    /// https://developers.themoviedb.org/3/find Api links for Find section
    /// </summary>
    static class Find
    {
        public static string FindByID { get; } = "https://api.themoviedb.org/3/find/{external_id}?api_key=<<api_key>>";
    }
}
