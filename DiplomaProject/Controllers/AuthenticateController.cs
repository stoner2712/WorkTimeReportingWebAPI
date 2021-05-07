using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using DiplomaProject.DataTransferObjects;
using DiplomaProject.Services.AuthenticateServiceNS;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace DiplomaProject.Controllers
{
    public class AuthenticateController : ControllerBase
    {
        #region Property  
        /// <summary>
        /// Property Declaration
        /// </summary>
        /// <returns></returns>
        private IConfiguration _config;
        private IAuthenticateService authenticateService;
        #endregion

        #region Constructor Injector  
        /// <summary>
        /// Constructor Injection to access all methods or simply DI(Dependency Injection)
        /// Property and Constructor to invoke the appsettings.json Secret JWT Key and its Issuer
        /// </summary>
        public AuthenticateController(IConfiguration config, IAuthenticateService authenticateService)
        {
            _config = config;
            this.authenticateService = authenticateService;
        }
        #endregion

        #region Login Validation  
        /// <summary>
        /// Login Authenticaton using JWT Token Authentication
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost(nameof(Login))]
        public async Task<IActionResult> Login([FromBody] LoginModel data)
        {
            IActionResult response = Unauthorized();
            var user = await this.authenticateService.AuthenticateUser(data);
            if (user != null)
            {
                var tokenString = this.authenticateService.GenerateJSONWebToken(user);
                response = Ok(new { Token = tokenString, Message = "Success" });
            }
            return response;
        }
        #endregion
    }
}
