using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class ListItem
    {

        /// <summary>
        /// </summary>
        [JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("favorite_count")]
        public int FavoriteCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("items")]
        public List<MovieItem> Items { get; set; } = new();

        /// <summary>
        /// </summary>
        [JsonPropertyName("item_count")]
        public int ItemCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("iso_639_1")]
        public string? Iso_639_1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("poster_path")]
        public string? PosterPath { get; set; }

    }
}
