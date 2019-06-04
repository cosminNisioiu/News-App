using NewsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Data
{
    public interface ISettings
    {
        SettingsModel Load();
        void Save(SettingsModel settings);
    }
}
