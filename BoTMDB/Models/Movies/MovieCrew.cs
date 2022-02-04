using BoTMDB.Models.Credits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Movies
{
    /// <summary>
    /// 
    /// </summary>
    public class MovieCrew: PersonCrewForMovie
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("profile_path")]
        public string? PosterOrProfilePath { get; set; }
    }
}
