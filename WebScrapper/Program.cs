using HtmlAgilityPack;
using System;
using System.Net.Http;

namespace WebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            String url = "https://weather.com/weather/today/l/220847d71fafc35aa68b0a22ac9bd012d25dcf161e70c8d18ac014f973b95563";
            var httpClient = new HttpClient();
            var html = httpClient.GetStringAsync(url).Result;
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);
        }
    }
}