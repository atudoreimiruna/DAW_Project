using Proiect1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.BLL.Interfaces
{
    public interface ITokenHelper
    {
        Task<string> CreateAccessToken(User _User);
        string CreateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string _Token);
    }
}
