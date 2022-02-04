using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.Configuration
{
    /// <summary>
    /// Sitedeki resimler ile ilgili verilerin tutuldugu sinif.
    /// (w)idth  = Genislik
    /// (h)eight = Yukseklik
    /// original = Orjinal Resim Boyutunu temsil etmektedir.
    /// </summary>
    public class ConfigImage
    {
        /// <summary>
        /// Resimlerin tutuldugu ana link
        /// </summary>
        [JsonPropertyName("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// Resimlerin tutuldugu ana link https olani
        /// </summary>

        [JsonPropertyName("secure_base_url")]
        public string? SecureBaseUrl { get; set; }

        /// <summary>
        /// Arka plan resimlerinin boyutlari
        /// </summary>

        [JsonPropertyName("backdrop_sizes")]
        public List<string> BackdropSizes { get; set; } = new List<string>();

        /// <summary>
        /// Logo Resim boyutlari
        /// </summary>

        [JsonPropertyName("logo_sizes")]
        public List<string> LogoSizes { get; set; } = new List<string>();

        /// <summary>
        /// Poster Resim Boyutlari
        /// </summary>

        [JsonPropertyName("poster_sizes")]
        public List<string> PosterSizes { get; set; } = new List<string>();

        /// <summary>
        /// Profil Resim Boyutlari
        /// </summary>

        [JsonPropertyName("profile_sizes")]
        public List<string> ProfileSizes { get; set; } = new List<string>();

        /// <summary>
        /// Sabit Resim boyutlari
        /// </summary>

        [JsonPropertyName("still_sizes")]
        public List<string> StillSizes { get; set; } = new List<string>();
    }
}
