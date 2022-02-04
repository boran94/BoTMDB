using BoTMDB.Models.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Library
{
    /// <summary>
    /// Authentication metodlarinin bulundugu sinif
    /// Bu sinif icerisinde bulunan metodlar
    /// <list type="bullet">
    /// <item><see cref="CreateGuestSession"/></item>
    /// <item><see cref="CreateRequestToken"/></item>
    /// <item><see cref="CreateSession(string)"/></item>
    /// <item><see cref="CreateSessionWithLogin(string, string, string)"/></item>
    /// <item><see cref="CreateSessionV4(string)"/></item>
    /// </list>
    /// Detaylı Bilgi için : <see href="https://developers.themoviedb.org/3/authentication/"/>
    /// </summary>
    public class Authentication
    {
        private string ApiKey { get; set; }

        private string CreateGuestSessionLink { get; set; }
        private string CreateRequestTokenLink { get; set; }
        private string CreateSessionLink { get; set; }
        private string CreateSessionWithLoginLink { get; set; }
        private string CreateSessionFromV4AccessTokenLink { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey">Api Key Degeri</param>
        public Authentication(string apiKey)
        {
            ApiKey = apiKey;
            CreateGuestSessionLink = ApiLinks.Authentication.CreateGuestSession.Replace("<<api_key>>", ApiKey);
            CreateRequestTokenLink = ApiLinks.Authentication.CreateRequestToken.Replace("<<api_key>>", ApiKey);
            CreateSessionLink = ApiLinks.Authentication.CreateSession.Replace("<<api_key>>", ApiKey);
            CreateSessionWithLoginLink = ApiLinks.Authentication.CreateSessionWithLogin.Replace("<<api_key>>", ApiKey);
            CreateSessionFromV4AccessTokenLink = ApiLinks.Authentication.CreateSessionFromV4AccessToken.Replace("<<api_key>>", ApiKey);
        }

        #region Create Guest Session

        /// <summary>
        /// Yeni bir misafir oturumu olusturmak icin kullanilan metod.
        /// Bu metodla TMDB hesabi olmadan kullanicilarin Filmlere ve Tv Sovlarini derecelendirmesine izin verir.
        /// 24 saat boyunca kullanilmayan misafir oturumlari otomatik olarak silinir.
        /// </summary>
        /// <returns></returns>
        public Response<Session> CreateGuestSession()
        {
            return Api.Get<Session>(CreateGuestSessionLink);
        }

        #endregion


        #region Create Request Token
        /// <summary>
        /// TMDB kullanici oturumunu dogrulamak icin gecici sureligine Request Token olusturmak icin kullanilan metod 
        /// </summary>
        /// <returns></returns>
        public Response<RToken> CreateRequestToken()
        {
            return Api.Get<RToken>(CreateRequestTokenLink);
        }
        #endregion


        #region Create Session
        /// <summary>
        /// Bu metodla tamamen gecerli oturum olusturulur. Request Token degerine izin verilmis olmasi gerekmektedir.
        /// Detayli bilgi icin :<see href="https://developers.themoviedb.org/3/authentication/how-do-i-generate-a-session-id"/>
        /// </summary>
        /// <param name="requestToken">Onaylanmis Request Token Degeri</param>
        /// <returns></returns>
        public Response<Session> CreateSession(string requestToken)
        {
            return Api.Post<Session>(CreateSessionLink, JsonContent.Create(new { request_token = requestToken }));
        }
        #endregion

        #region Create Session With Login

        /// <summary>
        /// Request Token degerini onaylamak icin TMDB kullanici adi ve sifreyi kullanan metod.
        /// Bu metodla onaylanan Request Token degerini <see cref="CreateSession(string)"/> metodu ile kullanarak oturum acilabilir.
        /// </summary>
        /// <param name="username">TMDB Kullanici Adi</param>
        /// <param name="password">TMDB Sifre</param>
        /// <param name="requestToken">Onaylanmasi yapilacak olan Request Token</param>
        /// <returns></returns>
        public Response<RToken> CreateSessionWithLogin(string username,string password, string requestToken)
        {
            return Api.Post<RToken>(CreateSessionWithLoginLink, JsonContent.Create(new { username= username, password= password, request_token = requestToken }));
        }
        #endregion

        #region Create Session (from v4 access token)
        /// <summary>
        /// v4 anahtari ile oturum acmak icin kullanilan metod.V4 tokeni kullanici tarafindan dogrulanmalidir.
        /// </summary>
        /// <param name="accessToken">v4 access token degeri</param>
        /// <returns></returns>
        public Response<Session> CreateSessionV4(string accessToken)
        {
            return Api.Post<Session>(CreateSessionFromV4AccessTokenLink, JsonContent.Create(new { access_token = accessToken }));
        }
        #endregion
    }
}
