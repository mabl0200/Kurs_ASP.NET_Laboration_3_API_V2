using Labb3.API.Models;
using Labb3.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb3.API.Services
{
    public class LinkRepository : ILabbTreRepository<Link>
    {
        private Labb3DbContext _labb3DbContext;

        public LinkRepository(Labb3DbContext labb3DbContext)
        {
            _labb3DbContext = labb3DbContext;
        }

        public async Task<Link> Add(Link newEntity)
        {
            var newLink = await _labb3DbContext.Links.AddAsync(newEntity);
            await _labb3DbContext.SaveChangesAsync();
            return newLink.Entity;
        }

        public async Task<IEnumerable<Link>> GetAll()
        {
            return await _labb3DbContext.Links.ToListAsync();
        }

        public async Task<Link> GetSingle(int id)
        {
            return await _labb3DbContext.Links
                .FirstOrDefaultAsync(l => l.LinkId == id);
        }
    }
}
