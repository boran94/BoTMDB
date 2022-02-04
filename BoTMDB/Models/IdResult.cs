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
    public class IdResult<T>
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("id")]
        public int id { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("results")]
        public List<T> Results { get; set; } = new();
    }
}
