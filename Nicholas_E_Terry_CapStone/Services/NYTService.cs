using Newtonsoft.Json;
using Nicholas_E_Terry_CapStone.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Nicholas_E_Terry_CapStone.Services
{
    public class NYTService
    {
        private string _apiKey;

        private HttpClient _httpClient;
        public NYTService(string apiKey, HttpClient httpClient)
        {
            _apiKey = apiKey;
            _httpClient = httpClient;
        }

        public async Task <Article> GetCurrentArticles()
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"svc/search/v2/articlesearch.json?api-key={_apiKey}");
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Article>(json);
            }
            return null;
        }
    }
}
