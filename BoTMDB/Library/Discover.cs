using BoTMDB.Models.Movies;
using BoTMDB.Models.Tv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Library
{
    /// <summary>
    /// Film ve Tv Sovlarini kesfetmek icin kullanilan metodlarin bulundugu sinif
    /// <list type="bullet">
    /// <item><see cref="MovieDiscover(string?, string?, SortByMovie?, string?, string?, string?, string?, bool?, bool?, int?, int?, string?, string?, string?, string?, int?, int?, int?, int?, decimal?, decimal?, string?, string?, string?, string?, string?, string?, string?, string?, int?, int?, string?, string?, string?, MonetizationTypes?, string?)"/></item>
    /// <item><see cref="TVDiscover(string?, SortByTv?, string?, string?, string?, string?, int?, int?, string?, decimal?, int?, string?, string?, string?, int?, int?, bool?, string?, string?, bool?, string?, string?, string?, string?, MonetizationTypes?, string?, string?, string?)"/></item>
    /// </list>
    /// <see href="https://developers.themoviedb.org/3/discover"/>
    /// </summary>
    public class Discover
    {
        private string ApiKey { get; set; }
        private string MovieDiscoverLink { get; set; }
        private string TVDiscoverLink { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey">Api Key Degeri</param>
        public Discover(string apiKey)
        {
            ApiKey = apiKey;
            MovieDiscoverLink = ApiLinks.Discover.MovieDiscover.Replace("<<api_key>>", ApiKey);
            TVDiscoverLink = ApiLinks.Discover.TVDiscover.Replace("<<api_key>>", ApiKey);

        }

        #region Movie Discover

        /// <summary>
        /// Detayli film arama yapmak icin kullanilan metod
        /// </summary>
        /// <param name="language">ISO 639-1 dil kodu. Minimum 2 karakter, Maksimum 4 karakter alir</param>
        /// <param name="region">ISO 3166-1 ulke kodu. </param>
        /// <param name="sortBy"><see cref="SortByMovie"/></param>
        /// <param name="certificationCountry"></param>
        /// <param name="certification">Sertifika filtrelemesi,<paramref name="certificationCountry"/> ile birlikte kullanilmalidir </param>
        /// <param name="certificationLte">Sertifika kucuk esittir filtrelemesi</param>
        /// <param name="certificationGte">Sertifika buyuk esittir filtrelemesi</param>
        /// <param name="includeAdult">Yetiskin filmleri icersin mi</param>
        /// <param name="includeVideo">Videolari dahil etmek icin</param>
        /// <param name="page">Sayfa sayisi</param>
        /// <param name="primaryReleaseYear">Ilk Cikis yili</param>
        /// <param name="primaryReleaseDateGte">Ilk Cikis yili buyuk esittir filtresi</param>
        /// <param name="primaryReleaseDateLte">Ilk Cikis yili kucuk esittir filtresi</param>
        /// <param name="releaseDateGte">Tum cikis tarihine bakarak buyuk esittir olanlari filtreleme</param>
        /// <param name="releaseDateLte">Tum cikis tarihine bakarak kucuk esittir olanlari filtreleme</param>
        /// <param name="withReleaseType">1 - 6 Arasinda deger alir </param>
        /// <param name="year">Yil filtrelemesi</param>
        /// <param name="voteCountGte">Oy sayisi buyuk esit filtresi</param>
        /// <param name="voteCountLte">Oy sayisi kucuk esit filtresi</param>
        /// <param name="voteAverageGte">Oy ortalamasi buyuk esit filtresi</param>
        /// <param name="voteAverageLte">Oy sayisi kucuk esit filtresi</param>
        /// <param name="withCast">Kisi Id degeri aralarina virgul konularak birden fazla kisi eklenebilir</param>
        /// <param name="withCrew">Kisi Id degeri aralarina virgul konularak birden fazla kisi eklenebilir</param>
        /// <param name="withPeople">Kisi Id degeri aralarina virgul konularak birden fazla kisi eklenebilir</param>
        /// <param name="withCompanies">Sirket Id degeri aralarina virgul konularak birden fazla sirket eklenebilir</param>
        /// <param name="withGenres">Tur Id degeri aralarina virgul konularak birden fazla tur eklenebilir</param>
        /// <param name="withoutGenres">Tur Id degeri aralarina virgul konularak birden fazla tur eklenebilir</param>
        /// <param name="withKeywords">Anahtar kelime Id degeri aralarina virgul konularak birden fazla anahtar kelime eklenebilir</param>
        /// <param name="withoutKeywords">Anahtar kelime Id degeri aralarina virgul konularak birden fazla anahtar kelime eklenebilir</param>
        /// <param name="withRuntimeGte">Suresi buyuk esittir olan</param>
        /// <param name="withRuntimeLte">Suresi kucuk esittir olan</param>
        /// <param name="withOriginalLanguage">Orjinal dil kodu  ISO 639-1</param>
        /// <param name="withWatchProviders">Filmi izleyebilecegin platformlarin Id degerleri, virgul konularak birden fazla eklenebilir.<paramref name="watchRegion"/> ile kullanilmalidir</param>
        /// <param name="watchRegion">ISO 3166-1 ulke kodu</param>
        /// <param name="withWatchMonetizationTypes"><see cref="MonetizationTypes"/></param>
        /// <param name="withoutCompanies">Sirket Id degeri aralarina virgul veya | konularak birden fazla sirket eklenebilir</param>
        /// <returns></returns>
        public Response<MovieContainer> MovieDiscover(
            string? language = null,
            string? region = null,
            SortByMovie? sortBy = null,
            string? certificationCountry = null,
            string? certification = null,
            string? certificationLte = null,
            string? certificationGte = null,
            bool? includeAdult = null,
            bool? includeVideo = null,
            int? page = null,
            int? primaryReleaseYear = null,
            string? primaryReleaseDateGte = null,
            string? primaryReleaseDateLte = null,
            string? releaseDateGte = null,
            string? releaseDateLte = null,
            int? withReleaseType = null,
            int? year = null,
            int? voteCountGte = null,
            int? voteCountLte = null,
            decimal? voteAverageGte = null,
            decimal? voteAverageLte = null,
            string? withCast = null,
            string? withCrew = null,
            string? withPeople = null,
            string? withCompanies = null,
            string? withGenres = null,
            string? withoutGenres = null,
            string? withKeywords = null,
            string? withoutKeywords = null,
            int? withRuntimeGte = null,
            int? withRuntimeLte = null,
            string? withOriginalLanguage = null,
            string? withWatchProviders = null,
            string? watchRegion = null,
            MonetizationTypes? withWatchMonetizationTypes = null,
            string? withoutCompanies = null
            )
        {

            StringBuilder sb = new(MovieDiscoverLink);
            if (!string.IsNullOrEmpty(language))
            {
                sb.Append("&language=");
                sb.Append(language);
            }
            if (!string.IsNullOrEmpty(region))
            {
                sb.Append("&region=");
                sb.Append(region);
            }
            if (sortBy.HasValue)
            {
                sb.Append("&sort_by=");
                switch (sortBy)
                {
                    case SortByMovie.Popularity_Asc:
                        sb.Append("popularity.asc");
                        break;
                    case SortByMovie.Popularity_Desc:
                        sb.Append("popularity.desc");

                        break;
                    case SortByMovie.ReleaseDate_Asc:
                        sb.Append("release_date.asc");

                        break;
                    case SortByMovie.ReleaseDate_Desc:
                        sb.Append("release_date.desc");

                        break;
                    case SortByMovie.Revenue_Asc:
                        sb.Append("revenue.asc");

                        break;
                    case SortByMovie.Revenue_Desc:
                        sb.Append("revenue.desc");

                        break;
                    case SortByMovie.PrimaryReleaseDate_Asc:
                        sb.Append("primary_release_date.asc");

                        break;
                    case SortByMovie.PrimaryReleaseDate_Desc:
                        sb.Append("primary_release_date.desc");

                        break;
                    case SortByMovie.OriginalTitle_Asc:
                        sb.Append("original_title.asc");

                        break;
                    case SortByMovie.OriginalTitle_Desc:
                        sb.Append("original_title.desc");

                        break;
                    case SortByMovie.VoteAverage_Asc:
                        sb.Append("vote_average.asc");

                        break;
                    case SortByMovie.VoteAverage_Desc:
                        sb.Append("vote_average.desc");

                        break;
                    case SortByMovie.VoteCount_Asc:
                        sb.Append("vote_count.asc");

                        break;
                    case SortByMovie.VoteCount_Desc:
                        sb.Append("vote_count.desc");

                        break;
                    default:
                        sb.Append("popularity.desc");

                        break;
                }
            }
            if (!string.IsNullOrEmpty(certificationCountry))
            {
                sb.Append("&certification_country=");
                sb.Append(certificationCountry);
            }
            if (!string.IsNullOrEmpty(certification))
            {
                sb.Append("&certification=");
                sb.Append(certification);
            }

            if (!string.IsNullOrEmpty(certificationLte))
            {
                sb.Append("&certification.lte=");
                sb.Append(certificationLte);
            }
            if (!string.IsNullOrEmpty(certificationGte))
            {
                sb.Append("&certification.gte=");
                sb.Append(certificationGte);
            }
            if (includeAdult.HasValue)
            {
                sb.Append("&include_adult=");
                sb.Append(includeAdult);
            }
            if (includeVideo.HasValue)
            {
                sb.Append("&include_video=");
                sb.Append(includeVideo);
            }

            if (page.HasValue)
            {
                sb.Append("&page=");
                sb.Append(page);
            }
            if (primaryReleaseYear.HasValue)
            {
                sb.Append("&primary_release_year=");
                sb.Append(primaryReleaseYear);
            }

            if (!string.IsNullOrEmpty(primaryReleaseDateGte))
            {
                sb.Append("&primary_release_date.gte=");
                sb.Append(primaryReleaseDateGte);
            }
            if (!string.IsNullOrEmpty(primaryReleaseDateLte))
            {
                sb.Append("&primary_release_date.lte=");
                sb.Append(primaryReleaseDateLte);
            }
            if (!string.IsNullOrEmpty(releaseDateGte))
            {
                sb.Append("&release_date.gte=");
                sb.Append(releaseDateGte);
            }
            if (!string.IsNullOrEmpty(releaseDateLte))
            {
                sb.Append("&release_date.lte=");
                sb.Append(releaseDateLte);
            }

            if (withReleaseType.HasValue)
            {
                sb.Append("&with_release_type=");
                sb.Append(withReleaseType);
            }
            if (year.HasValue)
            {
                sb.Append("&year=");
                sb.Append(year);
            }
            if (voteCountGte.HasValue)
            {
                sb.Append("&vote_count.gte=");
                sb.Append(voteCountGte);
            }
            if (voteCountLte.HasValue)
            {
                sb.Append("&vote_count.lte=");
                sb.Append(voteCountLte);
            }

            if (voteAverageGte.HasValue)
            {
                sb.Append("&vote_average.gte=");
                sb.Append(voteAverageGte);
            }
            if (voteAverageLte.HasValue)
            {
                sb.Append("&vote_average.lte=");
                sb.Append(voteAverageLte);
            }

            if (!string.IsNullOrEmpty(withCast))
            {
                sb.Append("&with_cast=");
                sb.Append(withCast);
            }
            if (!string.IsNullOrEmpty(withCrew))
            {
                sb.Append("&with_crew=");
                sb.Append(withCrew);
            }
            if (!string.IsNullOrEmpty(withPeople))
            {
                sb.Append("&with_people=");
                sb.Append(withPeople);
            }
            if (!string.IsNullOrEmpty(withCompanies))
            {
                sb.Append("&with_companies=");
                sb.Append(withCompanies);
            }
            if (!string.IsNullOrEmpty(withGenres))
            {
                sb.Append("&with_genres=");
                sb.Append(withGenres);
            }
            if (!string.IsNullOrEmpty(withoutGenres))
            {
                sb.Append("&without_genres=");
                sb.Append(withoutGenres);
            }
            if (!string.IsNullOrEmpty(withKeywords))
            {
                sb.Append("&with_keywords=");
                sb.Append(withKeywords);
            }
            if (!string.IsNullOrEmpty(withoutKeywords))
            {
                sb.Append("&without_keywords=");
                sb.Append(withoutKeywords);
            }


            if (withRuntimeGte.HasValue)
            {
                sb.Append("&with_runtime.gte=");
                sb.Append(withRuntimeGte);
            }
            if (withRuntimeLte.HasValue)
            {
                sb.Append("&with_runtime.lte=");
                sb.Append(withRuntimeLte);
            }
            if (!string.IsNullOrEmpty(withOriginalLanguage))
            {
                sb.Append("&with_original_language=");
                sb.Append(withOriginalLanguage);
            }
            if (!string.IsNullOrEmpty(withWatchProviders))
            {
                sb.Append("&with_watch_providers=");
                sb.Append(withWatchProviders);
            }
            if (!string.IsNullOrEmpty(watchRegion))
            {
                sb.Append("&watch_region=");
                sb.Append(watchRegion);
            }

            if (withWatchMonetizationTypes.HasValue)
            {
                sb.Append("&with_watch_monetization_types=");

                switch (withWatchMonetizationTypes)
                {
                    case MonetizationTypes.Flatrate:
                        sb.Append("flatrate");
                        break;
                    case MonetizationTypes.Free:
                        sb.Append("free");
                        break;
                    case MonetizationTypes.Ads:
                        sb.Append("ads");
                        break;
                    case MonetizationTypes.Rent:
                        sb.Append("rent");
                        break;
                    case MonetizationTypes.Buy:
                        sb.Append("buy");
                        break;
                    default:
                        break;
                }
            }
            if (!string.IsNullOrEmpty(withoutCompanies))
            {
                sb.Append("&without_companies=");
                sb.Append(withoutCompanies);
            }

            return Api.Get<MovieContainer>(sb.ToString());
        }

        #endregion

        #region TV Discover
        /// <summary>
        /// 
        /// </summary>
        /// <param name="language">ISO 639-1 dil kodu. Minimum 2 karakter, Maksimum 4 karakter alir</param>
        /// <param name="sortBy"><see cref="SortByTv"/></param>
        /// <param name="airDateGte">Yayin tarihi buyuk esittir filtresi</param>
        /// <param name="airDateLte">Yayin tarihi kucuk esittir filtresi</param>
        /// <param name="firstAirDateGte">Ilk Yayinlanma tarihi buyuk esittir filtresi</param>
        /// <param name="firstAirDateLte">Ilk Yayinlanma tarihi kucuk esittir filtresi</param>
        /// <param name="firstAirDateYear">Ilk yainlanma yili</param>
        /// <param name="page">Sayfa sayisi</param>
        /// <param name="timezone">Uygun UTC hesaplamak icin <paramref name="airDateGte"/> ve <paramref name="airDateLte"/> ile birlikte kullanilir</param>
        /// <param name="voteAverageGte">Oy ortalamasi buyuk esit olan filtresi</param>
        /// <param name="voteCountGte">Oy sayisi buyuk esit olan filtresi </param>
        /// <param name="withGenres">Tur Id degeri virgul konularak birden fazla filtreleme yapilabilir</param>
        /// <param name="withNetworks">Network Id degeri birden fazla filtreleme yapmak icin Id degerlerinin arasina virgul konulabilir</param>
        /// <param name="withoutGenres">Haric. Tur Id degeri virgul konularak birden fazla filtreleme yapilabilir</param>
        /// <param name="withRuntimeGte">Suresi buyuk esit olan filtreleme</param>
        /// <param name="withRuntimeLte">Suresi kucuk esit olan filtreleme</param>
        /// <param name="includeNullFirstAirDates">Ilk yayin tarihi null olanlar dahil edilsin mi</param>
        /// <param name="withOriginalLanguage"> ISO 639-1  Orjinal dil</param>
        /// <param name="withoutKeywords">Haric. Anahtar kelime Id degeri. Aralarina virgul konularak birden fazla filtreleme yapilabilir</param>
        /// <param name="screenedTheatrically">Festival veya tiyatroda gosterild mi</param>
        /// <param name="withCompanies">Sirket Id degerine gore filtreleme. Aralarina virgul konularak birden fazla filtreleme yapilabilir</param>
        /// <param name="withKeywords">Anahtar kelime Id degerine gore filtreleme.  Aralarina virgul konularak birden fazla filtreleme yapilabilir</param>
        /// <param name="withWatchProviders">Yayin saglayici Id degerine gore filtreleme. Aralarina virgul konularak birden fazla filtreleme yapilabilir</param>
        /// <param name="watchRegion"><paramref name="withWatchProviders"/> ile birlikte kullanilir. Izlenecek olan bolgeye ait ISO 3166-1 kodu</param>
        /// <param name="withWatchMonetizationTypes"><see cref="MonetizationTypes"/></param>
        /// <param name="withStatus">Returning Series: 0 Planned: 1 In Production: 2 Ended: 3 Cancelled: 4 Pilot: 5</param>
        /// <param name="withType">Documentary: 0 News: 1 Miniseries: 2 Reality: 3 Scripted: 4 Talk Show: 5 Video: 6</param>
        /// <param name="withoutCompanies">Haric, Sirket Id degerine gore filtreleme</param>
        /// <returns></returns>
        public Response<TvContainer> TVDiscover(

                string? language = null,
                SortByTv? sortBy = null,
                string? airDateGte = null,
                string? airDateLte = null,
                string? firstAirDateGte = null,
                string? firstAirDateLte = null,
                int? firstAirDateYear = null,
                int? page = null,
                string? timezone = null,
                decimal? voteAverageGte = null,
                int? voteCountGte = null,
                string? withGenres = null,
                string? withNetworks = null,
                string? withoutGenres = null,
                int? withRuntimeGte = null,
                int? withRuntimeLte = null,
                bool? includeNullFirstAirDates = null,
                string? withOriginalLanguage = null,
                string? withoutKeywords = null,
                bool? screenedTheatrically = null,
                string? withCompanies = null,
                string? withKeywords = null,
                string? withWatchProviders = null,
                string? watchRegion = null,
                MonetizationTypes? withWatchMonetizationTypes = null,
                string? withStatus = null,
                string? withType = null,
                string? withoutCompanies = null
            )
        {
            StringBuilder sb = new(TVDiscoverLink);


            if (!string.IsNullOrEmpty(language))
            {
                sb.Append("&language=");
                sb.Append(language);
            }
            if (sortBy.HasValue)
            {
                sb.Append("&sort_by=");
                switch (sortBy)
                {
                    case SortByTv.VoteAverage_Desc:
                        sb.Append("vote_average.desc");
                        break;
                    case SortByTv.VoteAverage_Asc:
                        sb.Append("vote_average.asc");
                        break;
                    case SortByTv.FirstAirDate_Desc:
                        sb.Append("first_air_date.desc");
                        break;
                    case SortByTv.FirstAirDate_Asc:
                        sb.Append("first_air_date.asc");
                        break;
                    case SortByTv.Popularity_Desc:
                        sb.Append("popularity.desc");
                        break;
                    case SortByTv.Popularity_Asc:
                        sb.Append("popularity.asc");
                        break;
                    default:
                        sb.Append("popularity.desc");
                        break;
                }
            }
            if (!string.IsNullOrEmpty(airDateGte))
            {
                sb.Append("&air_date.gte=");
                sb.Append(airDateGte);
            }
            if (!string.IsNullOrEmpty(airDateLte))
            {
                sb.Append("&air_date.lte=");
                sb.Append(airDateLte);
            }
            if (!string.IsNullOrEmpty(firstAirDateGte))
            {
                sb.Append("&first_air_date.gte=");
                sb.Append(firstAirDateGte);
            }
            if (!string.IsNullOrEmpty(firstAirDateLte))
            {
                sb.Append("&first_air_date.lte=");
                sb.Append(firstAirDateLte);
            }
            if (firstAirDateYear.HasValue)
            {
                sb.Append("&first_air_date_year=");
                sb.Append(firstAirDateYear);
            }
            if (page.HasValue)
            {
                sb.Append("&page=");
                sb.Append(page);
            }
            if (!string.IsNullOrEmpty(timezone))
            {
                sb.Append("&timezone=");
                sb.Append(timezone);
            }
            if (voteAverageGte.HasValue)
            {
                sb.Append("&vote_average.gte=");
                sb.Append(voteAverageGte);
            }
            if (voteCountGte.HasValue)
            {
                sb.Append("&vote_count.gte=");
                sb.Append(voteCountGte);
            }
            if (!string.IsNullOrEmpty(withGenres))
            {
                sb.Append("&with_genres=");
                sb.Append(withGenres);
            }
            if (!string.IsNullOrEmpty(withNetworks))
            {
                sb.Append("&with_networks=");
                sb.Append(withNetworks);
            }
            if (!string.IsNullOrEmpty(withoutGenres))
            {
                sb.Append("&without_genres=");
                sb.Append(withoutGenres);
            }
            if (withRuntimeGte.HasValue)
            {
                sb.Append("&with_runtime.gte=");
                sb.Append(withRuntimeGte);
            }
            if (withRuntimeLte.HasValue)
            {
                sb.Append("&with_runtime.lte=");
                sb.Append(withRuntimeLte);
            }
            if (includeNullFirstAirDates.HasValue)
            {
                sb.Append("&include_null_first_air_dates=");
                sb.Append(includeNullFirstAirDates);
            }
            if (!string.IsNullOrEmpty(withOriginalLanguage))
            {
                sb.Append("&with_original_language=");
                sb.Append(withOriginalLanguage);
            }
            if (!string.IsNullOrEmpty(withoutKeywords))
            {
                sb.Append("&without_keywords=");
                sb.Append(withoutKeywords);
            }
            if (screenedTheatrically.HasValue)
            {
                sb.Append("&screened_theatrically=");
                sb.Append(screenedTheatrically);
            }
            if (!string.IsNullOrEmpty(withCompanies))
            {
                sb.Append("&with_companies=");
                sb.Append(withCompanies);
            }
            if (!string.IsNullOrEmpty(withKeywords))
            {
                sb.Append("&with_keywords=");
                sb.Append(withKeywords);
            }
            if (!string.IsNullOrEmpty(withWatchProviders))
            {
                sb.Append("&with_watch_providers=");
                sb.Append(withWatchProviders);
            }
            if (!string.IsNullOrEmpty(watchRegion))
            {
                sb.Append("&watch_region=");
                sb.Append(watchRegion);
            }
            if (withWatchMonetizationTypes.HasValue)
            {
                sb.Append("&with_watch_monetization_types=");

                switch (withWatchMonetizationTypes)
                {
                    case MonetizationTypes.Flatrate:
                        sb.Append("flatrate");
                        break;
                    case MonetizationTypes.Free:
                        sb.Append("free");
                        break;
                    case MonetizationTypes.Ads:
                        sb.Append("ads");
                        break;
                    case MonetizationTypes.Rent:
                        sb.Append("rent");
                        break;
                    case MonetizationTypes.Buy:
                        sb.Append("buy");
                        break;
                    default:
                        break;
                }
            }
            if (!string.IsNullOrEmpty(withStatus))
            {
                sb.Append("&with_status=");
                sb.Append(withStatus);
            }
            if (!string.IsNullOrEmpty(withType))
            {
                sb.Append("&with_type=");
                sb.Append(withType);
            }
            if (!string.IsNullOrEmpty(withoutCompanies))
            {
                sb.Append("&without_companies=");
                sb.Append(withoutCompanies);
            }
            return Api.Get<TvContainer>(sb.ToString());
        }
        #endregion
    }
}
