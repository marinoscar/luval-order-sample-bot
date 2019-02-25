using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luval.bot.Models
{
    public class LuisEntityResolution
    {
        [JsonProperty(PropertyName = "values")]
        public List<LuisEntityResolutionValue> Values { get; set; }
    }
}
