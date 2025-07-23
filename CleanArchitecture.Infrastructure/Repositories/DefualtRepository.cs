
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infrastructure.Context;
using System.Security.Cryptography.X509Certificates;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class DefualtRepository : RepositoryBase<Entity> , IDefualtRepository 
    {
        public DefualtRepository(RepositoryContext repositoryContext)
            :base(repositoryContext) 
        {
            
        }
    }
}
