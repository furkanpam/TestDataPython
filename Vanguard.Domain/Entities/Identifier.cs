using Vanguard.Abstraction.Domain;

namespace Vanguard.Domain.Entities
{
    public class Identifier : CardEntity
    {
        public string AccountFrm { get; set; }
        public int BranchCode { get; set; }
        public int Number { get; set; }
        public string NumberDetail { get; set; }
        public int Suffix { get; set; }
    }

}
