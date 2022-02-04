

namespace BoTMDB.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Status
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("status_message")]
        public string? StatusMessage { get; set; } 

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("status_code")]
        public int StatusCode { get; set; }
    }
}
