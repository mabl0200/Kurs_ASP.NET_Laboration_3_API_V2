using Labb3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb3.API.Services
{
    public interface IPersonHobbyRepository<T>
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> AddPersonToInterest(PersonHobby personHobby);

        Task<T> GetSingle(int id);
    }
}
