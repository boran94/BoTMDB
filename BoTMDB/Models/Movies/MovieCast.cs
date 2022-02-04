using BoTMDB.Models.Credits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Movies
{
    /// <summary>
    /// </summary>
    public class MovieCast: PersonCastForMovie
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("profile_path")]
        public string? PosterOrProfilePath { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("cast_id")]
        public int? CastId { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("known_for_department")]
        public string? KnownForDepartment { get; set; }

    }
}
