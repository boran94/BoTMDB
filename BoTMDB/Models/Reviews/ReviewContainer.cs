using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Reviews
{
    /// <summary>
    /// Inceleme hakkindaki bilgilerin tutuldugu sinif
    /// </summary>
    public class ReviewContainer
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("author")]
        public string? Author { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("author_details")]
        public ReviewItem AuthorDetails { get; set; } = new();

        /// <summary>
        /// </summary>
        [JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("iso_639_1")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("media_id")]
        public int MediaId { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("media_title")]
        public string? MediaTitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("media_type")]
        public string? MediaType { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }

    }
    /// <summary>
    /// 
    /// </summary>
    public class ReviewItem
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("avatar_path")]
        public string? AvatarPath { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("rating")]
        public decimal? Rating { get; set; }
    }
}
