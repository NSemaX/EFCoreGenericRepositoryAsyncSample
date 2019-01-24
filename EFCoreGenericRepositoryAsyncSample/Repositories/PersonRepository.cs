using EFCoreGenericRepositoryAsyncSample.Data;
using EFCoreGenericRepositoryAsyncSample.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreGenericRepositoryAsyncSample.Repositories
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        public PersonRepository(DataContext dbContext)
            : base(dbContext)
        {

        }
        public async Task<Person> GetCoolestPerson()
        {
            return await GetAll()
                .OrderByDescending(c => c.Name)
                .FirstOrDefaultAsync();
        }
    }
}
