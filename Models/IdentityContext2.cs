using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace Fag_el_Gamous.Models
{
    public class IdentityContext2 : IdentityDbContext<IdentityUser>
    {
        public IdentityContext2(DbContextOptions<IdentityContext2> options)
        : base(options) { }
    }
}