using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BoTMDB.Models.TvEpisodes
{
    /// <summary>
    /// 
    /// </summary>
    public class AccountStateForEpisode
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("rated")]
        public object? Rated
        {
            get { return rated; }
            set
            {
                rated = value;
                if (rated is not null)
                {
                    Regex regex = new Regex("(?<=:)d*.*\\w");
                    string v = rated.ToString() ?? "";
                    if (regex.IsMatch(v))
                    {
                        IsRated = true;
                        Console.WriteLine(regex.Match(v).Value);
                        RatePoint = decimal.Parse(regex.Match(v).Value);
                        if (RatePoint > 10)
                            RatePoint /= 10;

                    }
                    else
                        IsRated = false;
                }

            }
        }



        private object? rated { get; set; }

        /// <summary>
        /// </summary>
        public bool IsRated { get; set; }

        /// <summary>
        /// </summary>
        public decimal? RatePoint { get; set; }

    }
}
