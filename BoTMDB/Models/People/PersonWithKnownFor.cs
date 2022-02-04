using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.People
{
    /// <summary>
    /// 
    /// </summary>
    public class PersonWithKnownFor:Person
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("known_for")]
        public object? KnownFor { get; set; }
    }
}
