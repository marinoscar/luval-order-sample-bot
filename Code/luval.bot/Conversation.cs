using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luval.bot
{
    public class Conversation
    {
        public Conversation(ILuisRequest request)
        {
            Request = request;
        }

        public ILuisRequest Request { get; private set; }
    }
}
