using NewsApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Data
{
    class Settings : ISettings
    {
        private const string SettingsFile = "settings.json";
        private readonly string FullPath = $"{AppDomain.CurrentDomain.BaseDirectory}\\{SettingsFile}";

        public SettingsModel Load()
        {
            string content;

            if (!File.Exists(FullPath))
            {
                var newFile = File.Create(FullPath);
                newFile.Close();

                return new SettingsModel();
            }

            var file = File.Open(FullPath, FileMode.Open);
            using (var sr = new StreamReader(file))
            {
                content = sr.ReadToEnd();
            }

            return JsonConvert.DeserializeObject<SettingsModel>(content) ?? new SettingsModel();           
        }

        public void Save(SettingsModel settings)
        {
            string json = JsonConvert.SerializeObject(settings); 

            File.WriteAllText(FullPath, json);
        }
    }
}
