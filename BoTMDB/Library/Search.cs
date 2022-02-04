using BoTMDB.Models.Movies;
using BoTMDB.Models.Search;
using BoTMDB.Models.Trending;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Library
{
    /// <summary>
    /// Seriler hakkindaki metotlarin tutuldugu sinif
    /// <list type="bullet">
    /// <item><see cref="SearchCompanies(string, int?)"/></item>
    /// <item><see cref="SearchCollections(string, int?)"/></item>
    /// <item><see cref="SearchKeywords(string, int?)"/></item>
    /// <item><see cref="SearchMovies(string, string?, bool?, string?, int?, int?, int?)"/></item>
    /// <item><see cref="MultiSearch(string, string?, bool?, string?, int?)"/></item>
    /// <item><see cref="SearchPeople(string, string?, bool?, string?, int?)"/></item>
    /// <item><see cref="SearchTVShows(string, string?, bool?, string?, int?, int?)"/></item>
    /// </list>
    /// <see href="https://developers.themoviedb.org/3/search"/>
    /// </summary>
    public class Search
    {
        private string ApiKey { get; set; }

        private string SearchCompaniesLink { get; set; }
        private string SearchCollectionsLink { get; set; }
        private string SearchKeywordsLink { get; set; }
        private string SearchMoviesLink { get; set; }
        private string MultiSearchLink { get; set; }
        private string SearchPeopleLink { get; set; }
        private string SearchTVShowsLink { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey">Api Key Degeri</param>
        public Search(string apiKey)
        {
            ApiKey = apiKey;
            SearchCompaniesLink = ApiLinks.Search.SearchCompanies.Replace("<<api_key>>", ApiKey);
            SearchCollectionsLink = ApiLinks.Search.SearchCollections.Replace("<<api_key>>", ApiKey);
            SearchKeywordsLink = ApiLinks.Search.SearchKeywords.Replace("<<api_key>>", ApiKey);
            SearchMoviesLink = ApiLinks.Search.SearchMovies.Replace("<<api_key>>", ApiKey);
            MultiSearchLink = ApiLinks.Search.MultiSearch.Replace("<<api_key>>", ApiKey);
            SearchPeopleLink = ApiLinks.Search.SearchPeople.Replace("<<api_key>>", ApiKey);
            SearchTVShowsLink = ApiLinks.Search.SearchTVShows.Replace("<<api_key>>", ApiKey);
        }

        #region SearchCompanies
        /// <summary>
        /// Sirket aramak icin kullanilan metod
        /// </summary>
        /// <param name="query">aranan deger</param>
        /// <param name="page">Sayfa sayisi</param>
        /// <returns></returns>
        public Response<SearchCompanyContainer> SearchCompanies(string query,int? page=null)
        {
            StringBuilder sb = new(SearchCompaniesLink);
            sb.Append("&query=");
            sb.Append(Uri.EscapeDataString(query));
            if (page != null)
            {
                sb.Append("&page=");
                sb.Append(page);
            }

            return Api.Get<SearchCompanyContainer>(sb.ToString());
        }
        #endregion

        #region SearchCollections
        /// <summary>
        /// Seri aramak icin kullanilan metod
        /// </summary>
        /// <param name="query">aranan deger</param>
        /// <param name="page">Sayfa sayisi</param>
        /// <returns></returns>
        public Response<SearchCollectionContainer> SearchCollections(string query, int? page = null)
        {
            StringBuilder sb = new(SearchCollectionsLink);
            sb.Append("&query=");
            sb.Append(Uri.EscapeDataString(query));
            if (page != null)
            {
                sb.Append("&page=");
                sb.Append(page);
            }

            return Api.Get<SearchCollectionContainer>(sb.ToString());
        }
        #endregion

        #region SearchKeywords
        /// <summary>
        /// Anahtar kelime aramak icin kullanilan metod
        /// </summary>
        /// <param name="query">aranan deger</param>
        /// <param name="page">Sayfa sayisi</param>
        /// <returns></returns>
        public Response<SearchKeywordContainer> SearchKeywords(string query, int? page = null)
        {
            StringBuilder sb = new(SearchKeywordsLink);
            sb.Append("&query=");
            sb.Append(Uri.EscapeDataString(query));
            if (page != null)
            {
                sb.Append("&page=");
                sb.Append(page);
            }

            return Api.Get<SearchKeywordContainer>(sb.ToString());
        }
        #endregion

        #region SearchMovies
        /// <summary>
        /// Film aramak icin kullanilan metod
        /// </summary>
        /// <param name="query">Aranan deger</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="includeAdult">Yetiskin filmler dahil olsun mu</param>
        /// <param name="region">Bolge Kodu</param>
        /// <param name="page">Sayfa Sayisi</param>
        /// <param name="year">Yil</param>
        /// <param name="primaryReleaseYear">Ilk Cikis Yili</param>
        /// <returns></returns>
        public Response<MovieContainer> SearchMovies(string query,string? language=null,bool? includeAdult=null,string? region=null, int? page = null,int? year=null,int? primaryReleaseYear=null)
        {
            StringBuilder sb = new(SearchMoviesLink);
            sb.Append("&query=");
            sb.Append(Uri.EscapeDataString(query));
            if (page != null)
            {
                sb.Append("&page=");
                sb.Append(page);
            }
            if (!string.IsNullOrEmpty(region))
            {
                sb.Append("&region=");
                sb.Append(region.ToUpper());
            }
            if (!string.IsNullOrEmpty(language))
            {
                sb.Append("&language=");
                sb.Append(language);
            }
            if (includeAdult.HasValue)
            {
                sb.Append("&include_adult=");
                sb.Append(includeAdult.Value.ToString().ToLower());
            }
            if (year.HasValue)
            {
                sb.Append("&year=");
                sb.Append(year);
            }
            if (primaryReleaseYear.HasValue)
            {
                sb.Append("&primary_release_year=");
                sb.Append(primaryReleaseYear);
            }
            
            return Api.Get<MovieContainer>(sb.ToString());
        }
        #endregion

        #region MultiSearch
        /// <summary>
        /// Film,Tv sov veya kisi  aramak icin kullanilan metod
        /// </summary>
        /// <param name="query">Aranan deger</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="includeAdult">Yetiskin filmler dahil olsun mu</param>
        /// <param name="region">Bolge Kodu</param>
        /// <param name="page">Sayfa Sayisi</param>
        /// <returns></returns>
        public Response<ObjectContainer> MultiSearch(string query, string? language = null, bool? includeAdult = null, string? region = null, int? page = null)
        {
            StringBuilder sb = new(MultiSearchLink);
            sb.Append("&query=");
            sb.Append(Uri.EscapeDataString(query));
            if (page != null)
            {
                sb.Append("&page=");
                sb.Append(page);
            }
            if (!string.IsNullOrEmpty(region))
            {
                sb.Append("&region=");
                sb.Append(region.ToUpper());
            }
            if (!string.IsNullOrEmpty(language))
            {
                sb.Append("&language=");
                sb.Append(language);
            }
            if (includeAdult.HasValue)
            {
                sb.Append("&include_adult=");
                sb.Append(includeAdult.Value.ToString().ToLower());
            }
            return Api.Get<ObjectContainer>(sb.ToString());
        }

        #endregion

        #region SearchPeople
        /// <summary>
        /// Film,Tv sov veya kisi  aramak icin kullanilan metod
        /// </summary>
        /// <param name="query">Aranan deger</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="includeAdult">Yetiskin filmler dahil olsun mu</param>
        /// <param name="region">Bolge Kodu</param>
        /// <param name="page">Sayfa Sayisi</param>
        /// <returns></returns>
        public Response<SearchPeopleContainer> SearchPeople(string query, string? language = null, bool? includeAdult = null, string? region = null, int? page = null)
        {
            StringBuilder sb = new(SearchPeopleLink);
            sb.Append("&query=");
            sb.Append(Uri.EscapeDataString(query));
            if (page != null)
            {
                sb.Append("&page=");
                sb.Append(page);
            }
            if (!string.IsNullOrEmpty(region))
            {
                sb.Append("&region=");
                sb.Append(region.ToUpper());
            }
            if (!string.IsNullOrEmpty(language))
            {
                sb.Append("&language=");
                sb.Append(language);
            }
            if (includeAdult.HasValue)
            {
                sb.Append("&include_adult=");
                sb.Append(includeAdult.Value.ToString().ToLower());
            }
            return Api.Get<SearchPeopleContainer>(sb.ToString());
        }
        #endregion

        #region SearchTVShows
        /// <summary>
        /// Film,Tv sov veya kisi  aramak icin kullanilan metod
        /// </summary>
        /// <param name="query">Aranan deger</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <param name="includeAdult">Yetiskin filmler dahil olsun mu</param>
        /// <param name="region">Bolge Kodu</param>
        /// <param name="page">Sayfa Sayisi</param>
        /// <param name="firstAirDateYear">Ilk cikis tarihi</param>
        /// <returns></returns>
        public Response<SearchTvContainer> SearchTVShows(string query, string? language = null, bool? includeAdult = null, string? region = null, int? page = null,int? firstAirDateYear=null)
        {
            StringBuilder sb = new(SearchTVShowsLink);
            sb.Append("&query=");
            sb.Append(Uri.EscapeDataString(query));
            if (page != null)
            {
                sb.Append("&page=");
                sb.Append(page);
            }
            if (!string.IsNullOrEmpty(region))
            {
                sb.Append("&region=");
                sb.Append(region.ToUpper());
            }
            if (!string.IsNullOrEmpty(language))
            {
                sb.Append("&language=");
                sb.Append(language);
            }
            if (includeAdult.HasValue)
            {
                sb.Append("&include_adult=");
                sb.Append(includeAdult.Value.ToString().ToLower());
            }
            if (firstAirDateYear.HasValue)
            {
                sb.Append("&first_air_date_year=");
                sb.Append(firstAirDateYear.Value.ToString().ToLower());
            }

            
            return Api.Get<SearchTvContainer>(sb.ToString());
        }

        #endregion
    }
}
