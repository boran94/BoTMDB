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
    public class ListsContainer:ListItem
    {

        /// <summary>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }
    }
}
