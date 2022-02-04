using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class ImageContainer
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Arka Plan Resimleri
        /// </summary>

        [JsonPropertyName("backdrops")]
        public List<ImageItem> Backdrops { get; set; } = new List<ImageItem>();
        /// <summary>
        /// Afisler
        /// </summary>
        [JsonPropertyName("posters")]
        public List<ImageItem> Posters { get; set; }=new List<ImageItem>();
    }
}
