using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luval.bot.Models
{
    public class LuisEntity
    {
        [JsonProperty(PropertyName = "entity")]
        public string Entity { get; set; }
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "startIndex")]
        public int StartIndex { get; set; }
        [JsonProperty(PropertyName = "endIndex")]
        public int EndIndex { get; set; }
    }
}
