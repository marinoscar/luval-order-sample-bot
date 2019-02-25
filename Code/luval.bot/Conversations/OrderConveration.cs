using luval.bot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luval.bot.Conversations
{
    public class OrderConveration : Conversation
    {
        public OrderConveration() : this(new LuisRequest(new LuisSession()))
        {

        }

        public OrderConveration(ILuisRequest request) : base(request)
        {
           

        }


    }
}
