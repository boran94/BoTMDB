using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models
{
    /// <summary>
    /// Film ve Tv sovlari icin kullanilan temel sinif
    /// </summary>
    public class MediaItem
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("poster_path")]
        public string? PosterPath { get; set; }

        /// <summary>
        /// Ozet bilgi
        /// </summary>
        [JsonPropertyName("overview")]
        public string? Overview { get; set; }

        /// <summary>
        /// Tur Id degerlerinin tutuldugu liste
        /// </summary>

        [JsonPropertyName("genre_ids")]
        public List<int> Genres { get; set; }=new List<int>();

        /// <summary>
        /// Id degeri
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Orjinal dilin adi
        /// </summary>
        [JsonPropertyName("original_language")]
        public string? OriginalLanguage { get; set; }

        /// <summary>
        /// Arka plan resmi
        /// </summary>

        [JsonPropertyName("backdrop_path")]
        public string? BackdropPath { get; set; }

        /// <summary>
        /// TMDB Populerlik Sirasi
        /// </summary>

        [JsonPropertyName("popularity")]
        public decimal Popularity { get; set; }

        /// <summary>
        /// Oy Sayisi
        /// </summary>

        [JsonPropertyName("vote_count")]
        public int VoteCount { get; set; }

        /// <summary>
        /// Ortalama Oy Orani
        /// </summary>

        [JsonPropertyName("vote_average")]
        public decimal VoteAverage { get; set; }

        /// <summary>
        /// Orjinal Baslik
        /// </summary>

        [JsonPropertyName("original_title")]
        public string? OriginalNameOrTitle { get; set; }

        /// <summary>
        /// Baslik
        /// </summary>

        [JsonPropertyName("title")]
        public string? NameOrTitle { get; set; }

        /// <summary>
        /// Ilk Yayin Tarihi
        /// </summary>

        [JsonPropertyName("release_date")]
        public string? ReleaseDate { get; set; }

    }
}
