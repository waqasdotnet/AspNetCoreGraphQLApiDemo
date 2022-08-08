using AspNetCoreGraphQLApiDemo.Data;
using AspNetCoreGraphQLApiDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreGraphQLApiDemo.Services
{
    public class PositionService : IPositionService
    {
        private readonly SportsDbContext _context;

        public PositionService(SportsDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Position>> GetAllPositionsAsync()
        {
            return await _context.Positions
                .ToListAsync();
        } 
    }
}
