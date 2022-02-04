using BoTMDB.Models.Credits;
using BoTMDB.Models.Tv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.TvEpisodes
{
    /// <summary>
    /// 
    /// </summary>
    public class EpisodeCredits : CreditContainer<TvCast, TvCrew>
    {

        /// <summary>
        /// </summary>
        [JsonPropertyName("guest_stars")]
        public List<TvCast> GuestStars { get; set; } = new();
    }
}
