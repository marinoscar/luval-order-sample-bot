using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luval.bot.Models
{
    public class LuisQueryResult
    {
        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }
        [JsonProperty(PropertyName = "topScoringIntent")]
        public LuisIntent TopScoringIntent { get; set; }
        [JsonProperty(PropertyName = "intents")]
        public List<LuisIntent> Intents { get; set; }
        [JsonProperty(PropertyName = "entities")]
        public List<LuisEntity> Entities { get; set; }
    }
}
