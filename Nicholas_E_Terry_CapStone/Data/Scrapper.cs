using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Nicholas_E_Terry_CapStone.Data
{
    public static class Scrapper
    {
        public static async Task<List<string>> GetHtmlAsList(string url)
        {
            List<string> result = new List<string>();

            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);

            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            var ArticleHtml = htmlDocument.DocumentNode.Descendants("div")
                .Where(node => node.GetAttributeValue("class", "")
                .Equals("css-53u6y8")).ToList();
            foreach (var item in ArticleHtml)
            {
                result.Add(item.InnerText + "\n");
            }
            return result;
        }
        public static async Task<string> GetHtmlAsString(string url)
        {
            StringBuilder builderResult = new StringBuilder();

            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);

            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            var ArticleHtml = htmlDocument.DocumentNode.Descendants("div")
                .Where(node => node.GetAttributeValue("class", "")
                .Equals("css-53u6y8")).ToList();
            foreach (var item in ArticleHtml)
            {
                builderResult.Append(item.InnerText); // need line breaks inbetween. appendline and enviroment.newline not working for some reason.
            }
            string result = builderResult.ToString();
            return result;
        }
    }
}
