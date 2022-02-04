using BoTMDB.Models.Networks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Companies
{
    /// <summary>
    /// Sirket verilerinin tutuldugu sinif
    /// </summary>
    public class CompanyItem:NetworkItem
    {
        /// <summary>
        /// Sirket aciklamasi
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Sirketin ana sirketi hakkinda bilgilerin tutuldugu property
        /// </summary>
        [JsonPropertyName("parent_company")]
        public CompanyItem? ParentCompany { get; set; }

    }
}
