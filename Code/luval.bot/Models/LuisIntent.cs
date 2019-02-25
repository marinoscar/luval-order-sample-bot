using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luval.bot.Models
{
    public class LuisIntent
    {
        [JsonProperty(PropertyName = "intent")]
        public string Intent { get; set; }
        [JsonProperty(PropertyName = "score")]
        public double Score { get; set; }
    }
}
