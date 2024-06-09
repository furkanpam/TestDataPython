using Vanguard.Abstraction.Contracts.Dtos.MongoDbDtos;

namespace Vanguard.Application.Managers.MongoManagers.CqrsLogManager
{
    public interface ICqrsLogManager
    {
        Task SaveLog(CqrsLogDto request);
    }
}
