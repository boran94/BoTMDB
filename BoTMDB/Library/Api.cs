using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BoTMDB.Library
{
    static class Api
    {
        static readonly HttpClient client = new HttpClient();
        private static async Task<string> GetPrivate(string apiLink)
        {
            string responseBody = "";
            try
            {
                Console.WriteLine(apiLink);
                HttpResponseMessage response = await client.GetAsync(apiLink);
                responseBody = await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException)
            {
            }
            return responseBody;
        }

        public static Response<T> Get<T>(string apiLink)
        {
            Response<T> response = new();
            string message = GetPrivate(apiLink).Result;
            try
            {
                Console.WriteLine(apiLink);
                response.Data = JsonSerializer.Deserialize<T>(message);
                Console.WriteLine(message);
                if (response.Data is null)
                {
                    response.Error = JsonSerializer.Deserialize<Status>(message);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + e.StackTrace);
            }
            return response;
        }

        public static Response<T> Get<T>(string apiLink, string appendText)
        {
            StringBuilder sb = new(apiLink);
            if (!string.IsNullOrEmpty(appendText))
                sb.Append(appendText);
            return Get<T>(sb.ToString());
        }


        private static async Task<string> PostPrivate(string apiLink, JsonContent jsonContent)
        {
            string responseBody = "";
            try
            {
                HttpResponseMessage response = await client.PostAsync(apiLink, jsonContent);


                responseBody = await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException)
            {
            }
            return responseBody;
        }


        public static Response<T> Post<T>(string apiLink, JsonContent jsonContent)
        {
            Response<T> response = new();
            string message = PostPrivate(apiLink, jsonContent).Result;
            try
            {
                Console.WriteLine(apiLink);
                response.Data = JsonSerializer.Deserialize<T>(message);
                Console.WriteLine(message);
                if (response.Data is null)
                {
                    response.Error = JsonSerializer.Deserialize<Status>(message);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + e.StackTrace);
            }
            return response;
        }


        public static Response<T> Post<T>(string apiLink, string appendText, JsonContent jsonContent)
        {
            StringBuilder sb = new(apiLink);
            if (!string.IsNullOrEmpty(appendText))
                sb.Append(appendText);
            return Post<T>(sb.ToString(),jsonContent);
        }


        private static async Task<string> DeletePrivate(string apiLink)
        {
            string responseBody = "";
            try
            {
                HttpResponseMessage response = await client.DeleteAsync(apiLink);
                responseBody = await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException)
            {
            }
            return responseBody;
        }

        public static Response<T> Delete<T>(string apiLink)
        {
            Response<T> response = new();
            string message = DeletePrivate(apiLink).Result;
            try
            {
                Console.WriteLine(apiLink);
                response.Data = JsonSerializer.Deserialize<T>(message);
                Console.WriteLine(message);
                if (response.Data is null)
                {
                    response.Error = JsonSerializer.Deserialize<Status>(message);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + e.StackTrace);
            }
            return response;
        }


        public static Response<T> Delete<T>(string apiLink, string appendText)
        {
            StringBuilder sb = new(apiLink);
            if (!string.IsNullOrEmpty(appendText))
                sb.Append(appendText);
            return Delete<T>(sb.ToString());
        }

       

    }
}
