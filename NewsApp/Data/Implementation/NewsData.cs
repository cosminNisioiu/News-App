using News.Models;
using NewsApp.Models;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace NewsApp.Data.Implementation
{
    public class NewsData
    {
        private readonly ISettings _settings;
        private string Url;
        private string Title;

        public NewsData(ISettings settings)
        {
            _settings = settings;
        }

        public void BuildUrl()
        {
            string url = @"https://newsapi.org/v2/top-headlines?apiKey=3e1d103c002747b684a8bc46cea35080";
            SettingsModel settingsModel = _settings.Load();

            //Set Category
            if (!string.IsNullOrEmpty(settingsModel.Category))
            {
                url += $"&category={settingsModel.Category.ToLower()}";
            }
            else
            {
                url += $"&category=general";
            }

            //Set Country
            url += $"&country={CountryAbbreviation(settingsModel.Country)}";

            //Set Language
            url += $"&language={LanguageAbbreviation(settingsModel.Language)}";

            //Set global variable to the final url
            Url = url;

        }

        public NewsModel GetNews()
        {
            string html = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }

            NewsModel newsModel = JsonConvert.DeserializeObject<NewsModel>(html);

            Title = newsModel.Articles[0].Title;

            return newsModel;
        }

        private string CountryAbbreviation(string country)
        {
            switch (country)
            {
                case "Romania":
                    return "ro";
                default:
                    return "eg";
            }
        }

        private string LanguageAbbreviation(string language)
        {
            switch (language)
            {
                case "Italian":
                    return "it";
                default:
                    return "en";
            }
        }
    }
}
