using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Networks
{
    /// <summary>
    /// Online izleme saglayicilarina ait logolarin tutuldugu sinif
    /// </summary>
    public class NetworkImages
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("logos")]
        public List<ImageItem> Logos { get; set; } = new();
    }
}
