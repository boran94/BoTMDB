using BoTMDB.Models.TvEpisodeGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Library
{
    /// <summary>
    /// Bolum Gruplarina ait metodlarin bulundugu sinif
    /// Bu sinif icerisinde bulunan metodlar
    /// <list type="bullet">
    /// <item><see cref="GetDetails(string)"/></item>
    /// </list>
    /// <see href="https://developers.themoviedb.org/3/tv-episode-groups"/>
    /// </summary>
    public class TvEpisodeGroups
    {
        private string ApiKey { get; set; }
        private string GetDetailsLink { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey">Api Key Degeri</param>
        public TvEpisodeGroups(string apiKey)
        {
            ApiKey = apiKey;
            GetDetailsLink = ApiLinks.TVEpisodeGroups.GetDetails.Replace("<<api_key>>", ApiKey);

        }

        #region  Get Details
        /// <summary>
        /// Tv Grubuna ait detaylari almak icin kullanilan metod
        /// 7 Farkli turu destekler
        /// <list type="number">
        ///<item>Originalairdate</item>
        ///<item>Absolute</item>
        ///<item>DVD</item>
        ///<item>Digital</item>
        ///<item>Storyarc</item>
        ///<item>Production</item>
        ///<item>TV</item>
        /// </list>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Response<EpisodeGroup> GetDetails(string id)
        {
            return Api.Get<EpisodeGroup>(GetDetailsLink.Replace("{id}", id));
        }
        #endregion
    }
}
