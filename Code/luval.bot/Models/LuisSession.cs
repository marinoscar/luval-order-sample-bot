using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luval.bot.Models
{
    public class LuisSession : ConfigModel
    {

        public LuisSession(string appId, string key)
        {
            IsStaging = GetSetting<bool>("luis.istaging", false);
            IsVerbose = GetSetting<bool>("luis.isverbose", true);
            TimeZoneOffset = GetSetting<short>("luis.tzoffset", -360);
            Key = GetSetting<string>("luis.key", key);
            Endpoint = GetSetting<string>("luis.endpoint", "");
            AppId = GetSetting<string>("luis.appid", appId);
        }
        public LuisSession(string endpoint, string appId, string key)
        {
            IsStaging = GetSetting<bool>("luis.istaging", false);
            IsVerbose = GetSetting<bool>("luis.isverbose", true);
            TimeZoneOffset = GetSetting<short>("luis.tzoffset", -360);
            Key = GetSetting<string>("luis.key", key);
            Endpoint = GetSetting<string>("luis.endpoint", endpoint);
            AppId = GetSetting<string>("luis.appid",appId);
        }
        public LuisSession() : this("", "")
        {
        }

        public bool IsStaging { get; set; }
        public bool IsVerbose { get; set; }
        public short TimeZoneOffset { get; set; }
        public string Key { get; set; }
        public string Endpoint { get; set; }
        public string AppId { get; set; }

    }
}
