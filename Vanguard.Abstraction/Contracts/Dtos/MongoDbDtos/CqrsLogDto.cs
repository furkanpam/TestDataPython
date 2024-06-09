using Vanguard.Abstraction.Enums;

namespace Vanguard.Abstraction.Contracts.Dtos.MongoDbDtos
{
    public class CqrsLogDto
    {
        public string MethodName { get; set; }
        public CqrsLogTypes LogType { get; set; }
        public string Command { get; set; }
        public string Response { get; set; }
        public string ExpMessage { get; set; }
    }
}
