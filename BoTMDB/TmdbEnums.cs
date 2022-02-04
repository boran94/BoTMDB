using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB
{
    /// <summary>
    /// 
    /// </summary>
    public class TmdbEnums
    {
    }


    /// <summary>
    /// 
    /// </summary>
    public enum MediaType
    {
        /// <summary>
        /// 
        /// </summary>
        Movie,
        /// <summary>
        /// 
        /// </summary>
        Tv
    }

    /// <summary>
    /// 
    /// </summary>
    public enum TmdbTypes
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Movie,
        /// <summary>
        /// 
        /// </summary>
        Tv,
        /// <summary>
        /// 
        /// </summary>
        Person
    }

    /// <summary>
    /// 
    /// </summary>
    public enum TimeWindow
    {
        /// <summary>
        /// 
        /// </summary>
        Day,
        /// <summary>
        /// 
        /// </summary>
        Week
    }

    /// <summary>
    /// 
    /// </summary>
    public enum SortByCreated
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc
    }
    /// <summary>
    /// 
    /// </summary>
    public enum MonetizationTypes
    {
        /// <summary>
        /// 
        /// </summary>
        Flatrate,
        /// <summary>
        /// 
        /// </summary>
        Free,
        /// <summary>
        /// 
        /// </summary>
        Ads,
        /// <summary>
        /// 
        /// </summary>
        Rent,
        /// <summary>
        /// 
        /// </summary>
        Buy
    }

    /// <summary>
    /// 
    /// </summary>
    public enum SortByTv
    {
        /// <summary>
        /// 
        /// </summary>
        VoteAverage_Desc,
        /// <summary>
        /// 
        /// </summary>
        VoteAverage_Asc,
        /// <summary>
        /// 
        /// </summary>
        FirstAirDate_Desc,
        /// <summary>
        /// 
        /// </summary>
        FirstAirDate_Asc,
        /// <summary>
        /// 
        /// </summary>
        Popularity_Desc,
        /// <summary>
        /// 
        /// </summary>
        Popularity_Asc
    }

    /// <summary>
    /// 
    /// </summary>
    public enum SortByMovie
    {
        /// <summary>
        /// 
        /// </summary>
        Popularity_Asc,
        /// <summary>
        /// 
        /// </summary>
        Popularity_Desc,
        /// <summary>
        /// 
        /// </summary>
        ReleaseDate_Asc,
        /// <summary>
        /// 
        /// </summary>
        ReleaseDate_Desc,
        /// <summary>
        /// 
        /// </summary>
        Revenue_Asc,
        /// <summary>
        /// 
        /// </summary>
        Revenue_Desc,
        /// <summary>
        /// 
        /// </summary>
        PrimaryReleaseDate_Asc,
        /// <summary>
        /// 
        /// </summary>
        PrimaryReleaseDate_Desc,
        /// <summary>
        /// 
        /// </summary>
        OriginalTitle_Asc,
        /// <summary>
        /// 
        /// </summary>
        OriginalTitle_Desc,
        /// <summary>
        /// 
        /// </summary>
        VoteAverage_Asc,
        /// <summary>
        /// 
        /// </summary>
        VoteAverage_Desc,
        /// <summary>
        /// 
        /// </summary>
        VoteCount_Asc,
        /// <summary>
        /// 
        /// </summary>
        VoteCount_Desc
    }

    /// <summary>
    /// 
    /// </summary>
    public enum ExternalSourceIds
    {
        /// <summary>
        /// 
        /// </summary>
        ImdbId,
        /// <summary>
        /// 
        /// </summary>
        FreebaseMid,
        /// <summary>
        /// 
        /// </summary>
        FreebaseId,
        /// <summary>
        /// 
        /// </summary>
        TvdbId,
        /// <summary>
        /// 
        /// </summary>
        TvrageId,
        /// <summary>
        /// 
        /// </summary>
        FacebookId,
        /// <summary>
        /// 
        /// </summary>
        TwitterId,
        /// <summary>
        /// 
        /// </summary>
        InstagramId
    }
}
