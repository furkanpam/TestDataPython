using Vanguard.Abstraction;
using Vanguard.Abstraction.Contracts.Dtos.UserDtos;
using Vanguard.Abstraction.Contracts.Responses;
using Vanguard.Abstraction.Result;
using Vanguard.Abstraction.StatusCodes;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanguard.Application.Managers.User
{
    public class UserManager : IUserManager
    {

        public async Task<Response<SignInResponse>> SignIn(SignInDto data)
        {
            if (data is not null && data.Email is "Vanguard@asiselektronik.com.tr" && data.Password is "Password1234")
                return new Response<SignInResponse>
                {
                    Header = new ResponseHeader
                    {
                        Dt = DateTime.Now,
                        ResCode = VanguardStatusCodes.Status200OK,
                        Result = true,
                        Msg = "Success",
                        MsgId = Guid.NewGuid().ToString(),
                    },
                    Body = new SignInResponse
                    {
                        RefreshToken = "123",
                        UserId = 1,
                        Token = "123",
                        Name = "Test",
                        UserStatus = "Active"
                    }
                };
            else
                return new Response<SignInResponse>
                {
                    Header = new ResponseHeader
                    {
                        Dt = DateTime.Now,
                        ResCode = VanguardStatusCodes.Status401Unauthorized,
                        Result = false,
                        Msg = "Invalid User Infos",
                        MsgId = Guid.NewGuid().ToString(),
                    },
                    Body = new SignInResponse()
                };
        }
    }
}
