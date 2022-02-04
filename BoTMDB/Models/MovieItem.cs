using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models
{
    /// <summary>
    /// Film verilerini tutmak icin kullanilan temel sinif
    /// </summary>
    public class MovieItem:MediaItem
    {
        /// <summary>
        /// Yetiskin filmi ise true, aksi halde false degeri alir.
        /// </summary>
        [JsonPropertyName("adult")]
        public bool Adult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("video")]
        public bool Video { get; set; }

    }
}
