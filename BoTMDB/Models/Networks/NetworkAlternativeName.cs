using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Networks
{
    /// <summary>
    /// Online izleme saglayicilarinin alternatif isimlerinin tutuldugu sinif 
    /// </summary>
    public class NetworkAlternativeName
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("results")]
        public List<NameType> Results { get; set; } = new();
    }
    /// <summary>
    /// 
    /// </summary>
    public class NameType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }
}
