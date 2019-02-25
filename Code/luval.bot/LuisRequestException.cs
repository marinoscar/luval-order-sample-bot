using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luval.bot
{
    public class LuisRequestException : Exception
    {

        public LuisRequestException()
        {

        }
        public LuisRequestException(string message) : base(message)
        {

        }
        public LuisRequestException(string message, Exception innerEx) : base(message, innerEx)
        {

        }
    }
}
