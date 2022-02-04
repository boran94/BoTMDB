using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models
{
    /// <summary>
    /// Id ve adult degerinin tutuldugu sinif.
    /// Adult degeri null olabilir
    /// </summary>
    public class IdAdult
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("adult")]
        public bool? Adult { get; set; }
    }
}
