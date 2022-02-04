using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Lists
{
    /// <summary>
    /// 
    /// </summary>
    public class ListResult:Status
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; } 

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("list_id")]
        public int ListId { get; set; }
    }
}
