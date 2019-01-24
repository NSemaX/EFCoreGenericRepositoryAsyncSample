using EFCoreGenericRepositoryAsyncSample.Data;
using EFCoreGenericRepositoryAsyncSample.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreGenericRepositoryAsyncSample.Repositories
{
    public interface IPersonRepository: IGenericRepository<Person>
    {
        Task<Person> GetCoolestPerson();
    }
}
