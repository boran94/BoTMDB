using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.People
{
    /// <summary>
    /// </summary>
    public class KnownForPerson: TaggedMediaItem
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("media_type")]
        public string? MediaType { get; set; }
    }
}
