using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Configuration
{
    /// <summary>
    /// Api Config verilerinin tutuldugu sinif
    /// </summary>
    public class ConfigContainer
    {
        /// <summary>
        /// Api icerisindeki resimlerle ilgili temel bilgilerin tutuldugu property
        /// </summary>
        [JsonPropertyName("images")]
        public ConfigImage Images { get; set; } = new();

        /// <summary>
        /// Degisen anahtar kelime listesinin tutuldugu property
        /// </summary>

        [JsonPropertyName("change_keys")]
        public List<string> ChangeKeys { get; set; } =new List<string>();
    }
}
