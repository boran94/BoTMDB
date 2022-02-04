using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Authentication
{
    /// <summary>
    /// </summary>
    public class RToken
    {

        /// <summary>
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("expires_at")]
        public string? ExpiresAt { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("request_token")]
        public string? RequestToken { get; set; } 
    }
}
