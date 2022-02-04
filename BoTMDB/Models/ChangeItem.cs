using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models
{
    /// <summary>
    /// Kisi,Tv Sovlari ve Filmlerdeki degisikliklerin tutuldugu temel sinif
    /// </summary>
    public class ChangeItem
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("action")]
        public string? Action { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("time")]
        public string? Time { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("original_value")]
        public object? OriginalValue { get; set; }
    }
}
