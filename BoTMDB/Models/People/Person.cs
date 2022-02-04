using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.People
{
    /// <summary>
    /// Kisi bilgilerinin tutuldugu temel sinif
    /// </summary>
    public class Person
    {

        /// <summary>
        /// </summary>
        [JsonPropertyName("birthday")]
        public string? Birthday { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("known_for_department")]
        public string? KnownForDepartment { get; set; }

        /// <summary>
        /// </summary>

        [JsonPropertyName("deathday")]
        public string? Deathday { get; set; }

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

        [JsonPropertyName("also_known_as")]
        public List<string> AlsoKnownAs { get; set; } = new();

        /// <summary>
        /// </summary>

        [JsonPropertyName("gender")]
        public int Gender { get; set; }

        /// <summary>
        /// </summary>

        [JsonPropertyName("biography")]
        public string? Biography { get; set; }

        /// <summary>
        /// </summary>

        [JsonPropertyName("popularity")]
        public decimal Popularity { get; set; }

        /// <summary>
        /// </summary>

        [JsonPropertyName("place_of_birth")]
        public string? PlaceOfBirth { get; set; }

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

        [JsonPropertyName("imdb_id")]
        public string? ImdbId { get; set; }

        /// <summary>
        /// </summary>

        [JsonPropertyName("homepage")]
        public string? Homepage { get; set; }
    }
}
