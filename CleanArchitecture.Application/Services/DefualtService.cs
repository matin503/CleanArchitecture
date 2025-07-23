using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Domain.Interfaces;
using NLog;

namespace CleanArchitecture.Application.Services;

internal sealed class DefualtService:IDefaultService
{
    private readonly ILoggerService _logger;
    private readonly IRepositoryManager _repository;
    public DefualtService(ILoggerService logger,IRepositoryManager repository)
    {
        _logger = logger;
        _repository = repository;
    }

}
