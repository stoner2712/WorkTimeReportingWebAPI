using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaProject.Services.SecurityServiceNS
{
    public class SecurityService : ISecurityService
    {
        #region Create Salt 
        ///<summary>
        ///Password encryption
        ///</summary>
        ///<returns></returns>
        public string GetSalt() 
        {
            var rngService = new RNGCryptoServiceProvider();

            // Maximum length of salt
            int max_length = 32;
            byte[] salt = new byte[max_length];

            // Build the random bytes
            rngService.GetNonZeroBytes(salt);
            return Convert.ToBase64String(salt);
        }
        #endregion

        #region Create Hash 
        ///<summary>
        ///Password encryption
        ///</summary>
        ///<param name="data"></param>
        ///<returns></returns>
        public string GetHash(string data)
        {
            var sha512 = SHA512.Create();
            byte[] hash = sha512.ComputeHash(Encoding.UTF8.GetBytes(data));
            for (int i = 0; i < 99; i++)
            {
                hash = sha512.ComputeHash(hash);
            }
            return Convert.ToBase64String(hash);
        }
        #endregion
    }
}
