using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Account
{
    /// <summary>
    /// 
    /// </summary>
    public class AccountItem
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("avatar")]
        public Avatar? Avatar { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("iso_639_1")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("iso_3166_1")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("include_adult")]
        public bool IncludeAdult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("username")]
        public string? Username { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Avatar
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("gravatar")]
        public Gravatar? Gravatar { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Gravatar
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("hash")]
        public string? Hash { get; set; }
    }
}
