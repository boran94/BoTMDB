using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.People
{
    /// <summary>
    /// </summary>
    public class PopularPerson
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("profile_path")]
        public string? ProfilePath { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("adult")]
        public bool Adult { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("popularity")]
        public decimal Popularity { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("known_for")]
        public List<KnownForPerson> KnownFor { get; set; } = new();
    }
}
