using Vanguard.Abstraction.Exceptions;
using Vanguard.Abstraction.Result;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Vanguard.Application.Managers
{
    public class ManagerBase
    {
        protected readonly IHttpContextAccessor httpContextAccessor;
        protected readonly IMapper mapper;
        public ManagerBase(IHttpContextAccessor httpContextAccessor,
                           IMapper mapper)
        {
            this.httpContextAccessor = httpContextAccessor;
            this.mapper = mapper;
        }
        public bool IsAuthenticate()
        {
            return httpContextAccessor.HttpContext.User.Identity.IsAuthenticated;
        }
        public long GetCurrentUserId()
        {
            if (IsAuthenticate())
                return Convert.ToInt64(httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
            throw new BusinessException(StatusCodes.Status401Unauthorized, "Unauthorized User");
        }
        public bool IsAdmin()
        {
            return false;
        }
        public string GetCurrentUserName()
        {
            if (IsAuthenticate())
            {
                var result = httpContextAccessor.HttpContext.User.Identity.Name;
                return result;
            }
            throw new BusinessException(StatusCodes.Status401Unauthorized, "Unauthorized User");
        }

        protected Response<TBody> ProduceSuccessResponse<TBody>(TBody body) where TBody : class
        {
            // TODO: Header values
            return Response<TBody>.Success(body);
        }

        protected Response<TBody> ProduceFailResponse<TBody>(string message, int code) where TBody : class
        {
            // TODO: Header values
            return Response<TBody>.Fail<TBody>(message, code);
        }
    }
}