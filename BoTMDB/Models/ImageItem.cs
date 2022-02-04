using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models
{
    /// <summary>
    /// Resim bilgilerinin tutuldugu sinif
    /// </summary>
    public class ImageItem
    {
        /// <summary>
        /// Yukseklik/Genislik Orani
        /// </summary>
        [JsonPropertyName("aspect_ratio")]
        public decimal AspectRatio { get; set; }

        /// <summary>
        /// Dosya Yolu
        /// </summary>

        [JsonPropertyName("file_path")]
        public string? FilePath 
        {
            get { return filepath; }
            set {
                filepath = value;
                if (!string.IsNullOrEmpty(value))
                {
                    Console.WriteLine(value);
                    if (!string.IsNullOrEmpty(value))
                    {
                        string[] split = value.Split('.');
                        if (split.Length > 1)
                            FileType = "."+split[split.Length - 1];
                    }
                }
                
            }
        }

        private string? filepath { get; set; }

        /// <summary>
        /// Yukseklik
        /// </summary>
        [JsonPropertyName("height")]
        public int Height { get; set; }

        /// <summary>
        /// Dil kodu
        /// </summary>

        [JsonPropertyName("iso_639_1")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// Ortalama Oy Puani
        /// </summary>

        [JsonPropertyName("vote_average")]
        public decimal VoteAverage { get; set; }

        /// <summary>
        /// Oy Sayisi
        /// </summary>

        [JsonPropertyName("vote_count")]
        public int VoteCount { get; set; }

        /// <summary>
        /// Genislik
        /// </summary>

        [JsonPropertyName("width")]
        public int Width { get; set; }

        /// <summary>
        /// Dosya Yolu
        /// </summary>

        [JsonPropertyName("file_type")]
        public string? FileType { get; set; }
    }
}
