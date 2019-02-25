using luval.bot.Conversations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luval.bot.channel
{
    class Program
    {
        static void Main(string[] args)
        {
            var bot = new OrderConveration();
            Console.WriteLine("How can I help?");
            var query = Console.ReadLine();
            var res = bot.Request.RunQuery(query);
            Console.WriteLine();
            Console.WriteLine(res);
            Console.WriteLine();
            Console.WriteLine("Press any key to end");
            Console.ReadKey();
        }
    }
}
