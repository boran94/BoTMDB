using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Credits
{
    /// <summary>
    /// </summary>
    public class CreditContainer<T1,T2>
    {

        /// <summary>
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("cast")]
        public List<T1> Cast { get; set; } = new();

        /// <summary>
        /// </summary>
        [JsonPropertyName("crew")]
        public List<T2> Crew { get; set; } = new();
    }
}
