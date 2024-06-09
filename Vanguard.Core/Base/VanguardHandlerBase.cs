using Microsoft.AspNetCore.Http;
using Vanguard.Abstraction.Result;

namespace Vanguard.Core.Base
{
    public class VanguardHandlerBase 
    {
        public VanguardHandlerBase(IHttpContextAccessor httpContextAccessor) 
        {
        }

        protected Response<TBody> ProduceSuccessResponse<TBody>(TBody body) where TBody : class
        {
            // TODO: Header values
            return Response<TBody>.Success(body);
        }

        protected Response<TBody> ProduceFailResponse<TBody>(string message, int responseCode) where TBody : class
        {
            // TODO: Header values
            return Response<TBody>.Fail<TBody>(message, responseCode);
        }
    }
}
