using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Companies
{
    /// <summary>
    /// Sirket Resimlerinin tutuldugu sinif
    /// </summary>
    public class CompanyLogos
    {

        /// <summary>
        /// Sirket Id degeri
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Sirket resimlerinin tutuldugu liste
        /// </summary>
        [JsonPropertyName("logos")]
        public List<ImageItem> Logos { get; set; }=new List<ImageItem>();
    }
}
