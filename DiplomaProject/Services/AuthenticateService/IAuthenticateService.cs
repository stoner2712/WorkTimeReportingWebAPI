using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomaProject.Services.AuthenticateServiceNS
{
    public interface IAuthenticateService
    {
        Task<LoginModel> AuthenticateUser(LoginModel login);
        string GenerateJSONWebToken(LoginModel userInfo);
    }
}
