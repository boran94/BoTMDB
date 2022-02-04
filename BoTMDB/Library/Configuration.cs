using BoTMDB.Models.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Library
{
    /// <summary>
    /// Sistem hakkindaki genel bilgileri almak icin kullanilan metodlarin bulundugu sinif
    /// Bu sinif icerisinde bulunan metodlar
    /// <list type="bullet">
    /// <item><see cref="GetAPIConfiguration"/></item>
    /// <item><see cref="GetCountries"/></item>
    /// <item><see cref="GetJobs"/></item>
    /// <item><see cref="GetLanguages"/></item>
    /// <item><see cref="GetPrimaryTranslations"/></item>
    /// <item><see cref="GetTimezones"/></item>
    /// </list>
    /// <see href="https://developers.themoviedb.org/3/configuration"/>
    /// </summary>
    public class Configuration
    {
        private string ApiKey { get; set; }
        private string GetAPIConfigurationLink { get; set; }
        private string GetCountriesLink { get; set; }
        private string GetJobsLink { get; set; }
        private string GetLanguagesLink { get; set; }
        private string GetPrimaryTranslationsLink { get; set; }
        private string GetTimezonesLink { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey">Api Key Degeri</param>
        public Configuration(string apiKey)
        {
            ApiKey = apiKey;
            GetAPIConfigurationLink = ApiLinks.Configuration.GetAPIConfiguration.Replace("<<api_key>>", ApiKey);
            GetCountriesLink = ApiLinks.Configuration.GetCountries.Replace("<<api_key>>", ApiKey);
            GetJobsLink = ApiLinks.Configuration.GetJobs.Replace("<<api_key>>", ApiKey);
            GetLanguagesLink = ApiLinks.Configuration.GetLanguages.Replace("<<api_key>>", ApiKey);
            GetPrimaryTranslationsLink = ApiLinks.Configuration.GetPrimaryTranslations.Replace("<<api_key>>", ApiKey);
            GetTimezonesLink = ApiLinks.Configuration.GetTimezones.Replace("<<api_key>>", ApiKey);
        }

        #region GetAPIConfiguration
        /// <summary>
        /// Resim verileri ile degisen anahtar kelimeler hakkindaki temel bilgilere ulasmak icin kullanilan metod
        /// </summary>
        /// <returns></returns>
        public Response<ConfigContainer> GetAPIConfiguration()
        {
            return Api.Get<ConfigContainer>(GetAPIConfigurationLink);
        }


        #endregion

        #region GetCountries
        /// <summary>
        /// TMDB genelinde kullanilan ulkelerin adlarini ISO 3166-1 kodu ile birlikte donduren metod
        /// </summary>
        /// <returns></returns>
        public Response<CountryList> GetCountries()
        {
            Response<List<CountryItem>> countries = Api.Get<List<CountryItem>>(GetCountriesLink);
            Response <CountryList> response=new() { Data =new()};
            if (countries.Data is not null)
                response.Data.Countries.AddRange(countries.Data);
            foreach (var item in response.Data.Countries)
            {
                if (string.IsNullOrEmpty(item.Name))
                {
                    item.Name = item.EnglishName;
                }
            }
            return response;

        }

        #endregion

        #region GetJobs
        /// <summary>
        /// TMDB'de kullanilan islerin ve departmanlarin bir listesini almak icin kullanilan metod.
        /// </summary>
        /// <returns></returns>
        public Response<JobContainer> GetJobs()
        {
            Response<List<JobItem>> jobs = Api.Get<List<JobItem>>(GetJobsLink);
            Response<JobContainer> response = new() { Data = new() };
            if (jobs.Data is not null)
                response.Data.JobList.AddRange(jobs.Data);
            return response;
        }
        #endregion

        #region GetLanguages
        /// <summary>
        /// TMDB kullanilan ISO 639-1 dil kodu ile birlikte dil adini donduren metod
        /// </summary>
        /// <returns></returns>
        public Response<LanguageContainer> GetLanguages()
        {
            Response<List<LanguageItem>> languages = Api.Get<List<LanguageItem>>(GetLanguagesLink);
            Response<LanguageContainer> response = new() { Data = new() };
            if (languages.Data is not null)
                response.Data.Languages.AddRange(languages.Data);
            return response;
        }
        #endregion

        #region GetPrimaryTranslations

        /// <summary>
        /// TMDB'de resmi olarak desteklenen cevirileri donduren metod
        /// </summary>
        /// <returns></returns>
        public Response<List<string>> GetPrimaryTranslations()
        {
            return Api.Get<List<string>>(GetPrimaryTranslationsLink);
        }
        #endregion

        #region GetTimezones
        /// <summary>
        /// TMDB icerisinde kullanilan zaman dilimlerini donduren metod
        /// </summary>
        /// <returns></returns>
        public Response<TimezoneList> GetTimezones()
        {
            Response<List<Timezone>> tiemzones = Api.Get<List<Timezone>>(GetTimezonesLink);
            Response<TimezoneList> response = new() { Data = new() };
            if (tiemzones.Data is not null)
                response.Data.Timezones.AddRange(tiemzones.Data);
            return response;
        }
        #endregion


    }
}
