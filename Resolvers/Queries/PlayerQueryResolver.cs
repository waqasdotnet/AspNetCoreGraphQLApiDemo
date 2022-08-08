using AspNetCoreGraphQLApiDemo.Models;
using AspNetCoreGraphQLApiDemo.Services;

namespace AspNetCoreGraphQLApiDemo.Resolvers.Queries
{
    [ExtendObjectType("Query")]
    public class PlayerQueryResolver
    {
        [GraphQLName("players")]
        [GraphQLDescription("Players API")]
        public async Task<IEnumerable<Player>> GetAllPlayersAsync(
                 [Service] IPlayerService playerService)
        {
            return await playerService.GetAllPlayersAsync();
        }

        [GraphQLName("player")]
        [GraphQLDescription("Get Player API")]
        public async Task<Player> GetPlayerAsync(int id,
            [Service] IPlayerService playerService)
        {
            return await playerService.GetPlayerAsync(id);
        }
    }
}
