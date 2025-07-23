using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Domain.Interfaces;

namespace CleanArchitecture.Application.Services;

public sealed class ServiceManager : IServiceManager
{
    private readonly Lazy<IDefaultService> _defaultService;
    public ServiceManager(IRepositoryManager repositoryManager, ILoggerService logger)
    {
        _defaultService = new Lazy<IDefaultService>(()=> new 
        DefualtService(logger,repositoryManager));
    }
    public IDefaultService DefaultService => _defaultService.Value;
}
