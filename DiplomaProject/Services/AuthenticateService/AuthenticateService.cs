using DiplomaProject.Services.EmployeeServiceNS;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;


namespace DiplomaProject.Services.AuthenticateServiceNS
{
    public class AuthenticateService : IAuthenticateService
    {
        #region Property  
        /// <summary>
        /// Property Declaration
        /// </summary>
        /// <returns></returns>
        private IConfiguration _config;
        private IEmployeeService employeeService;
        #endregion

        #region Constructor Injector  
        /// <summary>
        /// Constructor Injection to access all methods or simply DI(Dependency Injection)
        /// Property and Constructor to invoke the appsettings.json Secret JWT Key and its Issuer
        /// </summary>
        public AuthenticateService(IConfiguration config, IEmployeeService employeeService)
        {
            _config = config;
            this.employeeService = employeeService;
        }
        #endregion

        #region GenerateJWT  
        /// <summary>
        /// Generate Json Web Token Method
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public string GenerateJSONWebToken(LoginModel userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              null,
              expires: DateTime.Now.AddMinutes(120),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        #endregion

        #region AuthenticateUser  
        /// <summary>
        /// User authentication
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public async Task<LoginModel> AuthenticateUser(LoginModel login)
        {
            LoginModel user = null;

            var employee = await employeeService.GetEmployeeByUserName(login.UserName);

            if (employee != null && login.Password == employee.Password)
            {
                user = new LoginModel { UserName = employee.UserName, Password = employee.Password };
            }
            return user;
        }
        #endregion
    }

    #region JsonProperties  
    /// <summary>
    /// Json Properties
    /// </summary>
    public class LoginModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
    #endregion
}
