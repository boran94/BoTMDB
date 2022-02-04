using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Configuration
{
    /// <summary>
    /// Is ve departmanlarin tutuldugu sinif
    /// </summary>
    public class JobItem
    {
        /// <summary>
        /// Departman adi
        /// </summary>
        [JsonPropertyName("department")]
        public string? Department { get; set; }

        /// <summary>
        /// Is adlarinin tutuldugu liste
        /// </summary>
        [JsonPropertyName("jobs")]
        public List<string> Jobs { get; set; } = new();
    }
}
