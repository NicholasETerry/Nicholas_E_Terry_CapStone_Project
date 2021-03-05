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
        public NYTService()
        {

        }

        public async Task <Article> GetCurrentArticles()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"https://api.nytimes.com/svc/search/v2/articlesearch.json?api-key={APIKeys.NewYorkTimesKey}");
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Article>(json);
            }
            return null;
        }
    }
}
