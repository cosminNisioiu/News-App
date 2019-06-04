using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Models
{
    public class SettingsModel
    {
        public string Category { get; set; }
        public string Country { get; set; }
        public string Language { get; set; }
        public string SearchText { get; set; }
        public bool IsStartup { get; set; }
        public DateTime LastNewsDate { get; set; }
    }
}
