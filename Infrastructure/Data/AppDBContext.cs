using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Infrastructure.Data
{
    public class AppDBContext : IdentityDbContext<User>
    {

        public AppDBContext(DbContextOptions<AppDBContext> options) :
            base(options)
        {

        }
    }
}
