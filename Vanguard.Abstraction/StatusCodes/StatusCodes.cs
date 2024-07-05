using System.ComponentModel.DataAnnotations;

namespace Vanguard.Abstraction.StatusCodes
{
    public class StatusCodes : IStatusCode
    {
        [Display(ResourceType = typeof(Abstraction.StatusCodes.Resources.StatusCodeResources), Name = "Status408TimeOut")]
        public static readonly int Status408TimeOut = 408;

        [Display(ResourceType = typeof(Abstraction.StatusCodes.Resources.StatusCodeResources), Name = "Status111DataNotFound")]
        public static readonly int Status111DataNotFound = 408; 
    }
}
