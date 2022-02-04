using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Models.People
{

    /// <summary>
    /// </summary>
    public class PersonWithAppend:Person
    {
        /// <summary>
        /// </summary>
        [JsonPropertyName("changes")]
        public PersonChangeContainer? Changes { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("movie_credits")]
        public MovieCreditsForPerson? MovieCredits { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("tv_credits")]
        public TvCreditsForPerson? TvCredits { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("combined_credits")]
        public CombinedCreditsForPerson? CombinedCredits { get; set; }


        /// <summary>
        /// </summary>
        [JsonPropertyName("external_ids")]
        public ExternalIdsForPerson? ExternalIds { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("images")]
        public PersonImage? Images { get; set; }

        /// <summary>
        /// </summary>
        [JsonPropertyName("tagged_images")]
        public TaggedImageContainer? TaggedImages { get; set; }
    }
}
