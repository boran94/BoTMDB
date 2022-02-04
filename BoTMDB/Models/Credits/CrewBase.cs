using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Credits
{
    /// <summary>
    /// 
    /// </summary>
    public class CrewBase
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("adult")]
        public bool Adult { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("credit_id")]
        public string? CreditId { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("department")]
        public string? Department { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("gender")]
        public int? Gender { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("job")]
        public string? Job { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("name")]
        public string? TitleOrName { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("original_name")]
        public string? OriginalName { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("popularity")]
        public decimal Popularity { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("profile_path")]
        public string? PosterOrProfilePath { get; set; }

    }
}
