using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infrastructure.Context;

namespace CleanArchitecture.Infrastructure.Repositories;

public sealed class RepositoryManager: IRepositoryManager
{
    private readonly RepositoryContext _repositoryContext;
    private readonly Lazy<IDefualtRepository> _defualtRepository;
    public RepositoryManager(RepositoryContext repositoryContext)
    {
        _repositoryContext = repositoryContext;
        _defualtRepository= new Lazy<IDefualtRepository>(() => new DefualtRepository(repositoryContext));
    }
    public IDefualtRepository DefualtRepository => _defualtRepository.Value;


    public void Save()=> _repositoryContext.SaveChanges();
}
