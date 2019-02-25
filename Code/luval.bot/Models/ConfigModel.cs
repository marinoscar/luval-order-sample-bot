using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luval.bot.Models
{
    public class ConfigModel
    {
        protected virtual T GetSetting<T>(string name, T defaultValue)
        {
            var res = ConfigurationManager.AppSettings[name];
            if (string.IsNullOrWhiteSpace(res)) return defaultValue;
            var val = Convert.ChangeType(res, typeof(T));
            return (T)val;
        }
    }
}
