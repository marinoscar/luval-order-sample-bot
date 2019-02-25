using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luval.bot.Models
{
    public class LuisEntityResolutionValue
    {
        [JsonProperty(PropertyName = "timex")]
        public string Timex { get; set; }
        [JsonProperty(PropertyName = "Mod")]
        public string Mod { get; set; }
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "start")]
        public string Start { get; set; }
        [JsonProperty(PropertyName = "end")]
        public string End { get; set; }
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
    }
}
