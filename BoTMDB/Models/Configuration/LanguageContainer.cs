using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Configuration
{
    /// <summary>
    /// Dillerin tutuldugu listenin tutuldugu sinif
    /// </summary>
    public class LanguageContainer
    {
        /// <summary>
        /// Dillerin tutuldugu liste
        /// </summary>
        public List<LanguageItem> Languages { get; set; } = new();
    }
}
