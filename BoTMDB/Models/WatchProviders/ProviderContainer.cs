using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.WatchProviders
{
    /// <summary>
    /// 
    /// </summary>
    public class ProviderContainer
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("results")]
        public Dictionary<string, Provider> Results { get; set; } = new();
    }
    /// <summary>
    /// 
    /// </summary>
    public class Provider
    {


        /// <summary>
        /// </summary>
        [JsonPropertyName("link")]
        public string? Link { get; set; }

        /// <summary>
        /// </summary>

        [JsonPropertyName("rent")]
        public List<ProviderItem> Rent { get; set; } = new();

        /// <summary>
        /// </summary>

        [JsonPropertyName("flatrate")]
        public List<ProviderItem> Flatrate { get; set; } = new();

        /// <summary>
        /// </summary>

        [JsonPropertyName("buy")]
        public List<ProviderItem> Buy { get; set; } = new();
    }
}
