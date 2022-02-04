using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Collections
{
    /// <summary>
    /// Serileri tutmak icin kullanilan sinif
    /// </summary>
    public class CollectionContainer
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("overview")]
        public string? Overview { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("poster_path")]
        public string? PosterPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("backdrop_path")]
        public string? BackdropPath { get; set; }

        /// <summary>
        /// Seriye ait bolumlerin tutuldugu property
        /// </summary>
        [JsonPropertyName("parts")]
        public List<MediaItem> Parts { get; set; } =new List<MediaItem>();

    }
}
