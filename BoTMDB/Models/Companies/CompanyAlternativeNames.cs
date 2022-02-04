using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Companies
{
    /// <summary>
    /// Sirketlere ait alternatif isimlerin tutuldugu sinif
    /// </summary>
    public class CompanyAlternativeNames
    {
        /// <summary>
        /// Sirket Id degeri
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Sirket alternatif isimleri
        /// </summary>
        [JsonPropertyName("results")]
        public List<NameType> Results { get; set; }=new List<NameType>();

    }
    /// <summary>
    /// 
    /// </summary>
    public class NameType
    {
        /// <summary>
        /// Ad
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Tip
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

}
