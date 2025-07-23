namespace CleanArchitecture.Domain.Interfaces;

public interface IRepositoryManager
{
    IDefualtRepository DefualtRepository { get; }
    void Save();
}
