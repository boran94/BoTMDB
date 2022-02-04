using BoTMDB.Models.Credits;
using BoTMDB.Models.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Movies
{
    /// <summary>
    /// </summary>
    public class MovieCredits : CreditContainer<MovieCast, MovieCredits>
    {


        /// <summary>
        /// </summary>
        [JsonPropertyName("known_for_department")]
        public string? KnownForDepartment { get; set; }
    }
}
