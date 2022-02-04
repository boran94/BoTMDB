using BoTMDB.Models.Networks;
using BoTMDB.Models.TvEpisodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.TvEpisodeGroups
{
    /// <summary>
    /// 
    /// </summary>
    public class EpisodeGroup
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("episode_count")]
        public int EpisodeCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("group_count")]
        public int GroupCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("type")]
        public int Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("network")]
        public NetworkItem? Network { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("groups")]

        public List<EpisodeGroupItem> Groups { get; set; } = new();

    }

    /// <summary>
    /// 
    /// </summary>
    public class EpisodeGroupItem
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }



        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("order")]
        public int Order { get; set; }



        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("locked")]
        public bool Locked { get; set; }



        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("episodes")]
        public List<Episode> Episodes { get; set; } = new();



    }
}
