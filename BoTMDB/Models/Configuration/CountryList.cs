using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Configuration
{
    /// <summary>
    /// Ulkelerin tutuldugu liste
    /// </summary>
    public class CountryList
    {
        /// <summary>
        /// Ulkelerin tutuldugu liste
        /// </summary>
        public List<CountryItem> Countries { get; set; } = new();
    }
}
