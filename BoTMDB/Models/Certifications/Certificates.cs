using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Certifications
{
    /// <summary>
    /// TMDB de kayitli sertifikalarin tutuldugu sinif
    /// </summary>
    public class Certificates
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("certifications")]
        public Dictionary<string, List<Certificate>> Certifications { get; set; } = new();
    }
}
