using AspNetCoreGraphQLApiDemo.Models;
using AspNetCoreGraphQLApiDemo.Services;

namespace AspNetCoreGraphQLApiDemo.Resolvers.Queries
{
    [ExtendObjectType("Query")]
    public class PositionQueryResolver
    {
        [GraphQLName("positions")]
        [GraphQLDescription("Positions API")]
        public async Task<IEnumerable<Position>> GetAllPositionsAsync(
            [Service] IPositionService positionService)
        {
            return await positionService.GetAllPositionsAsync();
        }
       
    }
}
