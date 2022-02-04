using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.TvSeasons
{
    /// <summary>
    /// 
    /// </summary>
    public class ExternalIdForSeasons
    {

        /// <summary>
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("tvdb_id")]
        public int? TvdbId { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("tvrage_id")]
        public int? TvrageId { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("freebase_mid")]
        public string? FreebaseMid { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("freebase_id")]
        public string? FreebaseId { get; set; }
    }
}
