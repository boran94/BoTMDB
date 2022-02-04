using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Configuration
{
    /// <summary>
    /// Zaman dilimlerinin tutuldugu liste
    /// </summary>
    public class TimezoneList
    {
        /// <summary>
        /// 
        /// </summary>
        public List<Timezone> Timezones { get; set; } = new();
    }
}
