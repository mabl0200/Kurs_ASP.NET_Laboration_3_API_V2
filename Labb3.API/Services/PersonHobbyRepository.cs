using Labb3.API.Models;
using Labb3.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb3.API.Services
{
    public class PersonHobbyRepository : IPersonHobbyRepository<PersonHobby>
    {
        private Labb3DbContext _labb3DbContext;

        public PersonHobbyRepository(Labb3DbContext labb3DbContext)
        {
            _labb3DbContext = labb3DbContext;
        }
        public async Task<PersonHobby> AddPersonToInterest(PersonHobby personHobby)
        {
            var newPersonHobby = await _labb3DbContext.PersonHobbies.AddAsync(personHobby);
            await _labb3DbContext.SaveChangesAsync();
            return newPersonHobby.Entity;
            
        }

        public async Task<IEnumerable<PersonHobby>> GetAll()
        {
            return await _labb3DbContext.PersonHobbies.ToListAsync();
        }

        public async Task<PersonHobby> GetSingle(int id)
        {
            return await _labb3DbContext.PersonHobbies
                .FirstOrDefaultAsync(p => p.PersonHobbyId == id);
        }
        
            
    }
}
