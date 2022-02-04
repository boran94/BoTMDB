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
    public class PresentItem
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("item_present")]
        public bool ItemPresent { get; set; }
    }
}
