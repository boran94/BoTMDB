using BoTMDB.Models.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Library
{
    /// <summary>
    /// Seriler hakkindaki metotlarin tutuldugu sinif
    /// <list type="bullet">
    /// <item><see cref="GetDetails(string, string?)"/></item>
    /// <item><see cref="GetDetails(int, string?)"/></item>
    /// <item><see cref="CheckItemStatus(string, int)"/></item>
    /// <item><see cref="CreateList(string, string, string, string)"/></item>
    /// <item><see cref="AddMovie(string, string, int)"/></item>
    /// <item><see cref="RemoveMovie(string, string, int)"/></item>
    /// <item><see cref="ClearList(string, string, bool)"/></item>
    /// <item><see cref="DeleteList(string, string)"/></item>
    /// </list>
    /// <see href="https://developers.themoviedb.org/3/lists"/>
    /// </summary>
    public class Lists
    {
        private string ApiKey { get; set; }
        private string GetDetailsLink { get; set; }
        private string CheckItemStatusLink { get; set; }
        private string CreateListLink { get; set; }
        private string AddMovieLink { get; set; }
        private string RemoveMovieLink { get; set; }
        private string ClearListLink { get; set; }
        private string DeleteListLink { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey">Api Key Degeri</param>
        public Lists(string apiKey)
        {
            ApiKey = apiKey;
            GetDetailsLink = ApiLinks.Lists.GetDetails.Replace("<<api_key>>", ApiKey);
            CheckItemStatusLink = ApiLinks.Lists.CheckItemStatus.Replace("<<api_key>>", ApiKey);
            CreateListLink = ApiLinks.Lists.CreateList.Replace("<<api_key>>", ApiKey);
            AddMovieLink = ApiLinks.Lists.AddMovie.Replace("<<api_key>>", ApiKey);
            RemoveMovieLink = ApiLinks.Lists.RemoveMovie.Replace("<<api_key>>", ApiKey);
            ClearListLink = ApiLinks.Lists.ClearList.Replace("<<api_key>>", ApiKey);
            DeleteListLink = ApiLinks.Lists.DeleteList.Replace("<<api_key>>", ApiKey);
        }

        #region GetDetails
        /// <summary>
        /// Liste detaylarini dondurmek icin kullanilan metod
        /// </summary>
        /// <param name="listId">Liste Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<ListsContainer> GetDetails(string listId,string? language=null)
        {
            StringBuilder sb = new(GetDetailsLink);
            sb.Replace("{list_id}", listId);
            if (!string.IsNullOrEmpty(language))
            {
                sb.Append("&language=");
                sb.Append(language);
            }

            return Api.Get<ListsContainer>(sb.ToString());   
        }
        /// <summary>
        /// Liste detaylarini dondurmek icin kullanilan metod
        /// </summary>
        /// <param name="listId">Liste Id degeri</param>
        /// <param name="language">ISO 639-1 Dil Kodu</param>
        /// <returns></returns>
        public Response<ListsContainer> GetDetails(int listId, string? language = null)
        {
            return GetDetails(listId.ToString(), language);
        }
        #endregion

        #region CheckItemStatus
        /// <summary>
        /// Listede filmin ekli olup olmadigini kontrol etmek icin kullanilan metod
        /// </summary>
        /// <param name="listId">Liste Id degeri</param>
        /// <param name="movieId">Film Id degeri</param>
        /// <returns></returns>
        public Response<PresentItem> CheckItemStatus(string listId,int movieId)
        {
            StringBuilder sb = new(CheckItemStatusLink);
            sb.Replace("{list_id}", listId);
            sb.Append("&movie_id=");
            sb.Append(movieId);
            return Api.Get<PresentItem>(sb.ToString());
        }
        /// <summary>
        /// Listede filmin ekli olup olmadigini kontrol etmek icin kullanilan metod
        /// </summary>
        /// <param name="listId">Liste Id degeri</param>
        /// <param name="movieId">Film Id degeri</param>
        /// <returns></returns>
        public Response<PresentItem> CheckItemStatus(int listId, int movieId)
        {
            return CheckItemStatus(listId.ToString(), movieId);
        }
        #endregion

        #region CreateList
        /// <summary>
        /// Yeni liste olusturmak icin kullanilan metod
        /// </summary>
        /// <param name="sessionId">Oturum Id degeri</param>
        /// <param name="name">Liste Adi</param>
        /// <param name="description">Liste Aciklamasi</param>
        /// <param name="language">Dil</param>
        /// <returns></returns>
        public Response<ListResult> CreateList(string sessionId,string name,string description,string language)
        {
            StringBuilder sb = new(CreateListLink);
            sb.Append("&session_id=");
            sb.Append(sessionId);
            return Api.Post<ListResult>(sb.ToString(), JsonContent.Create(new { name = name, description = description, language = language }));

        }
        #endregion

        #region AddMovie
        /// <summary>
        /// Listeye film eklemek icin kullanilan metod
        /// </summary>
        /// <param name="sessionId">Oturum Id degeri</param>
        /// <param name="listId">Liste Id degeri</param>
        /// <param name="mediaId">Film Id degeri</param>
        /// <returns></returns>
        public Response<Status> AddMovie(string sessionId,string listId, int mediaId)
        {
            StringBuilder sb = new(AddMovieLink);
            sb.Append("&session_id=");
            sb.Append(sessionId);
            sb.Replace("{list_id}", listId);

            return Api.Post<Status>(sb.ToString(), JsonContent.Create(new { media_id = mediaId }));

        }
        /// <summary>
        /// Listeye film eklemek icin kullanilan metod
        /// </summary>
        /// <param name="sessionId">Oturum Id degeri</param>
        /// <param name="listId">Liste Id degeri</param>
        /// <param name="mediaId">Film Id degeri</param>
        /// <returns></returns>
        public Response<Status> AddMovie(string sessionId, int listId, int mediaId)
        {
           return AddMovie(sessionId,listId.ToString(),mediaId);
        }
        #endregion

        #region RemoveMovie
        /// <summary>
        /// Listeden film silmek icin kullanilan metod
        /// </summary>
        /// <param name="sessionId">Oturum Id degeri</param>
        /// <param name="listId">Liste Id degeri</param>
        /// <param name="mediaId">Film Id degeri</param>
        /// <returns></returns>
        public Response<Status> RemoveMovie(string sessionId, string listId, int mediaId)
        {
            StringBuilder sb = new(RemoveMovieLink);
            sb.Append("&session_id=");
            sb.Append(sessionId);
            sb.Replace("{list_id}", listId);

            return Api.Post<Status>(sb.ToString(), JsonContent.Create(new { media_id = mediaId }));

        }

        /// <summary>
        /// Listeden film silmek icin kullanilan metod
        /// </summary>
        /// <param name="sessionId">Oturum Id degeri</param>
        /// <param name="listId">Liste Id degeri</param>
        /// <param name="mediaId">Film Id degeri</param>
        /// <returns></returns>
        public Response<Status> RemoveMovie(string sessionId, int listId, int mediaId)
        {
            return RemoveMovie(sessionId,listId.ToString(), mediaId);
        }
        #endregion

        #region ClearList
        /// <summary>
        /// Liste icerisindeki tum icerikleri silmek icin kullanilan metod
        /// </summary>
        /// <param name="sessionId">Oturum Id degeri</param>
        /// <param name="listId">Liste Id degeri</param>
        /// <param name="confirm">Onay</param>
        /// <returns></returns>
        public Response<Status> ClearList(string sessionId, string listId, bool confirm)
        {
            StringBuilder sb = new(ClearListLink);
            sb.Append("&session_id=");
            sb.Append(sessionId);
            sb.Replace("{list_id}", listId);
            sb.Append("&confirm=");
            sb.Append(confirm.ToString().ToLower());
            return Api.Post<Status>(sb.ToString(), JsonContent.Create(new { }));

        }

        /// <summary>
        /// Liste icerisindeki tum icerikleri silmek icin kullanilan metod
        /// </summary>
        /// <param name="sessionId">Oturum Id degeri</param>
        /// <param name="listId">Liste Id degeri</param>
        /// <param name="confirm">Onay</param>
        /// <returns></returns>
        public Response<Status> ClearList(string sessionId, int listId, bool confirm)
        {
            return ClearList(sessionId, listId.ToString(), confirm);

        }
        #endregion

        #region DeleteList
        /// <summary>
        /// Listeyi silmek icin kullanilan metod
        /// </summary>
        /// <param name="sessionId">Oturum Id degeri</param>
        /// <param name="listId">Liste Id degeri</param>
        /// <returns></returns>
        public Response<Status> DeleteList(string sessionId, string listId)
        {
            StringBuilder sb = new(DeleteListLink);
            sb.Append("&session_id=");
            sb.Append(sessionId);
            sb.Replace("{list_id}", listId);
            return Api.Delete<Status>(sb.ToString());

        }

        /// <summary>
        /// Listeyi silmek icin kullanilan metod
        /// </summary>
        /// <param name="sessionId">Oturum Id degeri</param>
        /// <param name="listId">Liste Id degeri</param>
        /// <returns></returns>
        public Response<Status> DeleteList(string sessionId, int listId)
        {
            return DeleteList(sessionId, listId.ToString());

        }
        #endregion

    }
}
