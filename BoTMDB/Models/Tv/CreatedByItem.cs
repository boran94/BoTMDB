using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Tv
{
    /// <summary>
    /// 
    /// </summary>
    public class CreatedByItem
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("credit_id")]
        public string? CreditId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("gender")]
        public int Gender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("profile_path")]
        public string? ProfilePath { get; set; }
        
            
            
            
    }
}
