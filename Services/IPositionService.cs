using AspNetCoreGraphQLApiDemo.Models;

namespace AspNetCoreGraphQLApiDemo.Services
{
    public interface IPositionService
    {
        Task<IEnumerable<Position>> GetAllPositionsAsync();
    }
}