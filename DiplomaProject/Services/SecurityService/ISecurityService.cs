using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomaProject.Services.SecurityServiceNS
{
    public interface ISecurityService
    {
        string GetSalt();
        string GetHash(string data);
    }
}
