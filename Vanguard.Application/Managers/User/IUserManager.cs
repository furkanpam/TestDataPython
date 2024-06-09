using Vanguard.Abstraction.Contracts.Dtos.UserDtos;
using Vanguard.Abstraction.Contracts.Responses;
using Vanguard.Abstraction.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanguard.Application.Managers.User
{
    public interface IUserManager
    {
        Task<Response<SignInResponse>> SignIn(SignInDto data);
    }
}
