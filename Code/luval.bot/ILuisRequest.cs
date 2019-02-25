using luval.bot.Models;

namespace luval.bot
{
    public interface ILuisRequest
    {
        LuisQueryResult RunQuery(string query);
    }
}