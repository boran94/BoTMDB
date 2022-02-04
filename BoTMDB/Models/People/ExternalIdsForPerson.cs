using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.People
{
    /// <summary>
    /// </summary>
    public class ExternalIdsForPerson:ExternalItem
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("freebase_mid")]
        public string? FreebaseMid { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("freebase_id")]
        public string? FreebaseId { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("tvrage_id")]
        public int? TvrageId { get; set; }

    }
}
