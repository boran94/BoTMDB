using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.People
{
    /// <summary>
    /// </summary>
    public class PersonImage
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// </summary>

        [JsonPropertyName("profiles")]
        public List<ImageItem> Profiles { get; set; } = new List<ImageItem>();
    }
}
