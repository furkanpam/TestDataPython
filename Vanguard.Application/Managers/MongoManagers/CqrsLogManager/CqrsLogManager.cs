using Vanguard.Abstraction.Contracts.Dtos.MongoDbDtos;
using Vanguard.Domain.MongoCollections;
using Vanguard.Infrastructre.Repositories.MongoDb.CqrsLogRepositories;
using AutoMapper;
using Microsoft.AspNetCore.Http;

namespace Vanguard.Application.Managers.MongoManagers.CqrsLogManager
{
    public class CqrsLogManager : ICqrsLogManager
    {
        private readonly ICqrsLogRepository cqrsLogRepository;
        private readonly IMapper mapper;
        public CqrsLogManager(IMapper mapper, ICqrsLogRepository cqrsLogRepository)
        {
            this.cqrsLogRepository = cqrsLogRepository;
            this.mapper = mapper;
        }

        public async Task SaveLog(CqrsLogDto request)
        {
            var log = mapper.Map<CqrsLog>(request);
            await cqrsLogRepository.InsertOneAsync(log);
        }
    }
}
