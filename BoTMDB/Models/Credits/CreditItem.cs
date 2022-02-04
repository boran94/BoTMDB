using BoTMDB.Models.TvEpisodes;
using BoTMDB.Models.TvSeasons;
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
    public class CreditItem
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("credit_type")]
        public string? CreditType { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("department")]
        public string? Department { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("job")]
        public string? Job { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("media_type")]
        public string? MediaType { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("person")]
        public IdName? Person { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("media")]
        public MediaItemForCredit? Media { get; set; }

    }
    /// <summary>
    /// 
    /// </summary>
    public class MediaItemForCredit
    {

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
        [JsonPropertyName("original_name")]
        public string? OriginalName { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("character")]
        public string? Character { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("episodes")]
        public List<Episode> Episodes { get; set; } = new();

        /// <summary>
        /// </summary>
        [JsonPropertyName("seasons")]
        public List<Season> Seasons { get; set; } = new();
    }
}
