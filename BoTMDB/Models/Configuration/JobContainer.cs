using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Configuration
{
    /// <summary>
    /// Is ve departman listelerinin tutuldugu sinif
    /// </summary>
    public class JobContainer
    {
        /// <summary>
        /// Is ve departman listelerinin tutuldugu liste
        /// </summary>
        public List<JobItem> JobList { get; set; } = new();
    }
}
