using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Genres
{
    /// <summary>
    /// Tur listenin tutuldugu sinif
    /// </summary>
    public class GenreList
    {
        /// <summary>
        /// Turlerin tutuldugu liste
        /// </summary>
        [JsonPropertyName("genres")]
        public List<IdName> Genres { get; set; } = new();

    }
}
