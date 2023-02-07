using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Proiect1.DAL.Entities
{
    public class Role : IdentityRole<int>
    {
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
