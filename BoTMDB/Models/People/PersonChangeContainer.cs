using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.People
{
    /// <summary>
    /// Kisilerde yapilan degisiklikleri tutmak icin kullanilan sinif
    /// </summary>
    public class PersonChangeContainer
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("changes")]
        public List<ChangeWrapper> Changes { get; set; } = new();
    }

    /// <summary>
    /// </summary>
    public class ChangeWrapper
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("items")]
        public List<ChangeItem> Items { get; set; } = new();
    }

    
}
